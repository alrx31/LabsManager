using LabsManager.domain.DTO;
using System.Text;
using System.Text.Json;

namespace LabsManager
{
    public partial class RegisterForm : Form
    {


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void DisaibleStudentInput()
        {
            registerlabel5.Visible = false;
            registertextBox4.Visible = false;
        }
        private void EnableStudentInput()
        {
            registerlabel5.Visible = true;
            registertextBox4.Visible = true;
        }
        private void DisableTeacherInput()
        {
            registerlabel6.Visible = false;
            registertextBox5.Visible = false;
        }

        private void EnableTeacherInput()
        {
            registerlabel6.Visible = true;
            registertextBox5.Visible = true;
        }

        private void registercheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (registercheckBox2.Checked)
            {
                DisaibleStudentInput();
                EnableTeacherInput();
            }
            else
            {
                EnableStudentInput();
                DisableTeacherInput();
            }
        }

        private async void registerbutton1_ClickAsync(object sender, EventArgs e)
        {
            string role = registercheckBox2.Checked ? "Teacher" : "Student";
            string registerUrl = role == "Student"
                ? $"{ENV.BASEURL}/api/person/student-register"
                : $"{ENV.BASEURL}/api/person/teacher-register";

            var ST = new RegisterStudentDTO();
            var TE = new RegisterTeacherDTO();
            var json = "";

            if (role == "Student")
            {
                ST = new RegisterStudentDTO
                {
                    name = registertextBox3.Text,
                    login = registertextBox1.Text,
                    password = registertextBox2.Text,
                    group = registertextBox4.Text
                };
                json = JsonSerializer.Serialize(ST);
            }
            if(role == "Teacher")
            {
                TE = new RegisterTeacherDTO
                {
                    name = registertextBox3.Text,
                    login = registertextBox1.Text,
                    password = registertextBox2.Text,
                    cafedra = registertextBox5.Text,
                };
                json = JsonSerializer.Serialize(TE);
            }

            using (HttpClient client = new HttpClient())
            {
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync(registerUrl, data);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Регистрация прошла успешно!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка регистрации");
                }
            }
        }
    }
}
