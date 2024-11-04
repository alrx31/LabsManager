using domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabsManager
{
    public partial class AddReportForm : Form
    {
        private int _personId;
        private Lab _Lab;

        public AddReportForm(int personId, Lab Lab)
        {
            _Lab = Lab;
            _personId = personId;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    label1.Text = filePath;
                    label1.Visible = true;
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var filePath = label1.Text;

            if (filePath == "")
            {
                label2.Text = "Заполните все поля";
                label2.Visible = true;
                return;
            }


            await UploadLabAsync(_Lab.id.ToString(),_personId.ToString(),_Lab.teacherId.ToString(),label1.Text);
        }

        private async Task UploadLabAsync(string labId, string studentId, string teacherId, string filePath)
        {
            using (HttpClient client = new HttpClient())
            {
                using (var content = new MultipartFormDataContent())
                {
                    content.Add(new StringContent(labId), "labId");
                    content.Add(new StringContent(studentId), "studentId");
                    content.Add(new StringContent(teacherId), "teacherId");


                    byte[] fileData = File.ReadAllBytes(filePath);
                    var fileContent = new ByteArrayContent(fileData);
                    fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("multipart/form-data");
                    content.Add(fileContent, "report", Path.GetFileName(filePath));

                    HttpResponseMessage response = await client.PutAsync("http://localhost:5000/api/pass", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Лабораторная работа успешно добавлена");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при добавлении лабораторной работы");
                    }
                }
            }
        }
    }
}
