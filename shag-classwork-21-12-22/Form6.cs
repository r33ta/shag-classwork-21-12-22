using Newtonsoft.Json;
using System.Net;
using static shag_classwork_21_12_22.Form1;

namespace shag_classwork_21_12_22;

public partial class Form6 : Form
{
    UpdateForm updateForm;

    class Login
    {
        public string? name { get; set; }
        public string? password { get; set; }
    }

    public Form6(UpdateForm updateForm)
    {
        InitializeComponent();
        this.updateForm = updateForm;
    }
    private void loginBtn_Click(object sender, EventArgs e)
    {
        var login = new Login()
        {
            name = loginBox.Text,
            password = passwordBox.Text
        };

        string json = JsonConvert.SerializeObject(login);
        WebClient client = new();

        string url = "http://192.168.88.30:3002/auth/login";

        string answer = client.UploadString(url, json);

        User result = JsonConvert.DeserializeObject<User>(answer);

        if (result != null)
        {
            updateForm(_name: result.name, _avatar: result.avatar, _jwt: result.jwt);
            Close();
        }

    }

    private void exitBtn_Click(object sender, EventArgs e) => Close();

}
