using domain.entities;
using LabsManager.domain.DTO;
using System.Text;
using System.Text.Json;

namespace LabsManager
{
    public partial class LoginForm : Form
    {
        private PersonsBase _person;
        private int ruleLevel;

        public LoginForm()
        {
            InitializeComponent();
        }

        public int Login(ref int RuleLevel, ref PersonsBase person)
        {
            this.ShowDialog();
            if(_person != null && ruleLevel != 0)
            {
                person = _person;
                RuleLevel = ruleLevel;
                return 1;
            }
            return 0;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string role = cbRole.Checked ? "Teacher" : "Student";
            string loginUrl = role == "Student"
                ? "http://localhost:5000/api/person/student-login"
                : "http://localhost:5000/api/person/teacher-login";

            var loginDTO = new
            {
                login = txtLogin.Text,
                password = txtPassword.Text
            };

            using (HttpClient client = new HttpClient())
            {
                var json = JsonSerializer.Serialize(loginDTO);
                
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                
                var response = await client.PostAsync(loginUrl, data);

                if (response.IsSuccessStatusCode)
                {
                    //todo
                    var responseContent = await response.Content.ReadAsStringAsync();
                    
                    if(role == "Student")
                    {
                        var Tdata = JsonSerializer.Deserialize<LoginStResponse>(responseContent);
                        if (!Tdata.isLoggedIn)
                        {
                            MessageBox.Show("Неверный логин или пароль.");
                            return;
                        }
                        _person = Tdata.student;
                        ruleLevel = 1;
                    }
                    else
                    {
                        var Tdata = JsonSerializer.Deserialize<LoginTeResponse>(responseContent);
                        if(!Tdata.isLoggedIn)
                        {
                            MessageBox.Show("Неверный логин или пароль.");
                            return;
                        }
                        _person = Tdata.teacher;
                        if (((Teacher)_person).isAdmin)
                        {
                            ruleLevel = 3;
                        }
                        else
                        {
                            ruleLevel = 2;
                        }
                    }
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
        }


        private void DisaibleLoginForm()
        {
            txtLogin.Visible = false;
            txtPassword.Visible = false;
            loginbutton1.Visible = false;
            loginlabel1.Visible = false;
            loginlabel2.Visible = false;
            loginlinkLabel1.Visible = false;
        }
        private void EnableLoginForm()
        {
            txtLogin.Visible = true;
            txtPassword.Visible = true;
            loginbutton1.Visible = true;
            loginlabel1.Visible = true;
            loginlabel2.Visible = true;
            loginlinkLabel1.Visible = true;
        }

        private void loginlinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
