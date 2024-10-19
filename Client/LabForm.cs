using domain.entities;
using System.Net;
using System.Net.Http.Json;

namespace LabsManager
{
    public partial class LabForm : Form
    {
        Lab laba;
        int user_id;

        public LabForm(int user_id, Lab lab)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.laba = lab;
        }

        private void LabForm_Load(object sender, EventArgs e)
        {
            this.Text = laba.name;

            label1.Text = laba.name;
            label2.Text = laba.description;
            label3.Text = laba.materials;
            label6.Text = "Срок сдачи: "+laba.lastTimeToPass.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                var url = $"http://localhost:5000/api/labs/{laba.id}";
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
    }
}
