using System.Data.SqlClient;

namespace shag_classwork_21_12_22;

public partial class Form2 : Form
{
    Form1.GetInfo getInfo;
    private string cmd = "INSERT INTO Processors(name, frequency, cores) " +
        "VALUES(@name, @frequency, @cores)";

    public Form2(Form1.GetInfo getInfo)
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
            command.Parameters.Add(new SqlParameter("@frequency", freq.Text));
            command.Parameters.Add(new SqlParameter("@cores", cores.Value));

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Вставка успешна!");

            getInfo();

            this.Close();
        }
    }
}
