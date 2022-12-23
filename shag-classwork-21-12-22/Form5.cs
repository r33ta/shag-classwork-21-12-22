using System.Data.SqlClient;
using static shag_classwork_21_12_22.Form1;
namespace shag_classwork_21_12_22;

public partial class Form5 : Form
{
    Computers computer;
    private SqlConnection con;
    string cmd = "SELECT " +
        "Computers.name, " +
        "Processors.name AS p_name, Processors.frequency as p_frequency, Processors.cores, " +
        "Videoadapters.name AS v_name, Videoadapters.memory_size as v_memory_size, Videoadapters.frequency AS v_frequency, " +
        "Memory.name AS m_name, Memory.memory_size AS m_memory_size " +
        "FROM Computers " +
        "INNER JOIN Processors ON Processors.id = Computers.processor_id " +
        "INNER JOIN Videoadapters ON Videoadapters.id = Computers.videoadapter_id " +
        "INNER JOIN Memory ON Memory.id = Computers.memory_id " +
        "WHERE Computers.id = @id;";

    class Result
    {
        public string? name;

        public string? p_name;
        public double p_frequency;
        public int cores;

        public string? v_name;
        public int v_memory_size;
        public double v_frequency;

        public string? m_name;
        public int m_memory_size;
    }
    Result res;

    public Form5(Computers computer)
    {
        InitializeComponent();
        this.computer = computer;

        con = new SqlConnection(conStr);
        con.Open();

        SqlCommand command = new(cmd, con);
        command.Parameters.Add(new SqlParameter("@id", computer.id));

        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    res = new Result
                    {
                        name = reader.GetString(0).Trim(),

                        p_name = reader.GetString(1).Trim(),
                        p_frequency = reader.GetDouble(2),
                        cores = reader.GetInt32(3),

                        v_name = reader.GetString(4).Trim(),
                        v_memory_size = reader.GetInt32(5),
                        v_frequency = reader.GetDouble(6),

                        m_name = reader.GetString(7).Trim(),
                        m_memory_size = reader.GetInt32(8)
                    };
                }
            }
        }

        if (res != null)
        {
            pc_name.Text = $"Сведения об {res.name}:";

            p_name.Text = res.p_name;
            p_freq.Text = $"{res.p_frequency}ГГц";
            p_cores.Text = res.cores.ToString();

            v_name.Text = res.v_name;
            v_memory.Text = $"{res.v_memory_size}ГБ";
            v_freq.Text = $"{res.v_frequency}мГц";

            m_name.Text = res.m_name;
            m_memory.Text = $"{res.m_memory_size}ГБ";
        }
    }
    ~Form5() => con.Close();
}
