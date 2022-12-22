using System.Data.SqlClient;

namespace shag_classwork_21_12_22;

public partial class Form1 : Form
{
    public static string conStr = "Server=192.168.88.30;" +
    "Database=Components;User Id=root;Password=root;";

    private string cmdSelectComputers = "SELECT * FROM Computers";
    private string cmdSelectProcessors = "SELECT * FROM Processors";
    private string cmdSelectVideoadapters = "SELECT * FROM Videoadapters";
    private string cmdSelectMemory = "SELECT * FROM Memory";

    private SqlConnection con;

    public delegate void GetInfo();

    class Computers
    {
        public int id;
        public string? name;
        public int processor_id;
        public int videoadapter_id;
        public int memory_id;

        public override string ToString() => name ?? "PC";
    }
    
    class Processors
    {
        public int id;
        public string? name;
        public double frequency;
        public int cores;

        public override string ToString() => $"{name} {frequency}GHz";
    }
    class Videoadapters
    {
        public int id;
        public string? name;
        public int memory_size;
        public double frequency;

        public override string ToString() => $"{name}, {memory_size}GB";
    }
    class Memory
    {
        public int id;
        public string? name;
        public int memory_size;

        public override string ToString() => $"{name}, {memory_size}GB";
    }

    public Form1()
    {
        InitializeComponent();

        con = new SqlConnection(conStr);
        con.Open();

        GetComputersList();
        GetProcessorsList();
        GetVideoadaptersList();
        GetMemoryList();
    }
    ~Form1() => con.Close();

    public void GetComputersList() 
    { 
        list.Items.Clear();

        SqlCommand command = new(cmdSelectComputers, con);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Computers temp = new Computers
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1).Trim(),
                        processor_id = reader.GetInt32(2),
                        videoadapter_id = reader.GetInt32(3),
                        memory_id = reader.GetInt32(4)
                    };

                    list.Items.Add(temp);
                }
            }

        }
    }
    public void GetProcessorsList() 
    {
        processorsBox.Items.Clear();

        SqlCommand command = new(cmdSelectProcessors, con);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Processors temp = new Processors
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1).Trim(),
                        frequency = reader.GetDouble(2),
                        cores = reader.GetInt32(3),
                    };

                    processorsBox.Items.Add(temp);
                }
            }
        }
    }
    public void GetVideoadaptersList() 
    {
        videoadaptersBox.Items.Clear();

        SqlCommand command = new(cmdSelectVideoadapters, con);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Videoadapters temp = new Videoadapters
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1).Trim(),
                        memory_size = reader.GetInt32(2),
                        frequency = reader.GetDouble(3)
                    };

                    videoadaptersBox.Items.Add(temp);
                }
            }
        }
    }
    public void GetMemoryList()
    {
        memoryBox.Items.Clear();

        SqlCommand command = new(cmdSelectMemory, con);
        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Memory temp = new Memory
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1).Trim(),
                        memory_size = reader.GetInt32(2)
                    };

                    memoryBox.Items.Add(temp);
                }
            }
        }
    }

    private void AddComputerBtn_Click(object sender, EventArgs e)
    {
        string cmd = "INSERT INTO Computers(name, processor_id, videoadapter_id, memory_id) " +
            "VALUES(@name, @processor_id, @videoadapter_id, @memory_id)";

        SqlCommand command = new(cmd, con);

        command.Parameters.Add(new SqlParameter("@name", nameBox.Text));
        command.Parameters.Add(new SqlParameter("@processor_id", ((Processors)processorsBox.SelectedItem).id));
        command.Parameters.Add(new SqlParameter("@videoadapter_id", ((Videoadapters)videoadaptersBox.SelectedItem).id));
        command.Parameters.Add(new SqlParameter("@memory_id", ((Memory)memoryBox.SelectedItem).id));

        if (command.ExecuteNonQuery() > 0)
            MessageBox.Show("Вставка успешна!");

        GetComputersList();
    }

    private void list_SelectedIndexChanged(object sender, EventArgs e)
    {
        Computers computer = (Computers)list.SelectedItem;

        nameBox.Text = computer.name;

        for (int i = 0; i < processorsBox.Items.Count; ++i)
            if (((Processors)processorsBox.Items[i]).id == computer.processor_id)
                processorsBox.SelectedIndex = i;

        for (int i = 0; i < videoadaptersBox.Items.Count; ++i)
            if (((Videoadapters)videoadaptersBox.Items[i]).id == computer.videoadapter_id)
                videoadaptersBox.SelectedIndex = i;

        for (int i = 0; i < memoryBox.Items.Count; ++i)
            if (((Memory)memoryBox.Items[i]).id == computer.memory_id)
                memoryBox.SelectedIndex = i;
    }

    private void AddProcessorBtn_Click(object sender, EventArgs e)
    {
        GetInfo getInfo = new(GetProcessorsList);

        Form2 form = new(getInfo);
        form.Show();
    }

    private void AddVideoadapterBtn_Click(object sender, EventArgs e)
    {
        GetInfo getInfo = new(GetVideoadaptersList);

        Form3 form = new(getInfo);
        form.Show();
    }

    private void AddMemoryBtn_Click(object sender, EventArgs e)
    {
        GetInfo getInfo = new(GetMemoryList);

        Form4 form = new(getInfo);
        form.Show();
    }
}
