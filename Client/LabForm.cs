using domain.entities;
using System.Net;
using System.Net.Http.Json;

namespace LabsManager
{
    public partial class LabForm : Form
    {
        Lab laba;
        int user_id;
        bool isAdmin;

        public LabForm(int user_id, Lab lab, bool isAdmin)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.laba = lab;
            this.isAdmin = isAdmin;
        }

        private void LabForm_Load(object sender, EventArgs e)
        {
            this.Text = laba.name;

            button3.Visible = false;

            if (isAdmin
                 || laba.teacherId == user_id)
            {
                button3.Visible = true;
            }

            label1.Text = laba.name;
            label2.Text = laba.description;
            label3.Text = laba.materials;
            label6.Text = "Срок сдачи: " + laba.lastTimeToPass.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var url = $"{ENV.BASEURL}/api/labs/{laba.id}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var labData = await response.Content.ReadFromJsonAsync<LabResponse>();

                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "All files (*.*)|*.*", // Set a generic filter; the specific one can be handled later
                    FileName = $"{labData.name}{labData.fileExtension}" // Use the extension here
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileData = Convert.FromBase64String(labData.FileBase64);
                    File.WriteAllBytes(saveFileDialog.FileName, fileData);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var AddReportForm = new AddReportForm(user_id, laba);
            AddReportForm.ShowDialog();
            this.Close();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var messageResult = MessageBox.Show("Вы уверены, что хотите удалить лабораторную работу?", "Удаление лабораторной работы", MessageBoxButtons.YesNo);

            if (messageResult == DialogResult.Yes)
            {
                var url = $"{ENV.BASEURL}/api/labs/{laba.id}";

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Лабораторная работа успешно удалена");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении лабораторной работы");
                    }
                }
            }
        }
    }
}
