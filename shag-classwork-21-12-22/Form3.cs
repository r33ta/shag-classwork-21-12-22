using System.Data.SqlClient;

namespace shag_classwork_21_12_22;

public partial class Form3 : Form
{
    Form1.GetInfo getInfo;
    private string cmd = "INSERT INTO Videoadapters(name, memory_size, frequency) " +
        "VALUES(@name, @memory_size, @frequency)";

    public Form3(Form1.GetInfo getInfo)
    {
        InitializeComponent();

        this.getInfo = getInfo;
    }

    private void btn_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(Form1.conStr))
        {
            con.Open();

            SqlCommand command = new(cmd, con);

            command.Parameters.Add(new SqlParameter("@name", name.Text));
            command.Parameters.Add(new SqlParameter("@memory_size", memory_size.Text));
            command.Parameters.Add(new SqlParameter("@frequency", freq.Text));

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Вставка успешна!");

            getInfo();

            this.Close();
        }
    }
}
