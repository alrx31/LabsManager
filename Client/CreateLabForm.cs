using domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabsManager
{
    public partial class CreateLabForm : Form
    {
        string filePath = string.Empty;
        int teacherId;

        public CreateLabForm(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    label5.Text = filePath;
                    label5.Visible = true;
                }
            }
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var description = textBox2.Text;
            var materials = textBox3.Text;
            var filePath = label5.Text;
            var date = dateTimePicker1.Value.ToUniversalTime().ToString("O");

            if (name == "" || description == "" || materials == "" || filePath == "")
            {
                label6.Text = "Заполните все поля";
                label6.Visible = true;
                return;
            }


            await UploadLabAsync(name, description, materials, filePath,date);
        }

        private async Task UploadLabAsync(string name, string description, string materials, string filePath,string date)
        {
            using (HttpClient client = new HttpClient())
            {
                using (var content = new MultipartFormDataContent())
                {
                    content.Add(new StringContent(name), "Name");
                    content.Add(new StringContent(description), "Description");
                    content.Add(new StringContent(materials), "Materials");
                    content.Add(new StringContent(teacherId.ToString()), "TeacherId");
                    content.Add(new StringContent(date.ToString()), "LastTimeToPass");


                    byte[] fileData = File.ReadAllBytes(filePath);
                    var fileContent = new ByteArrayContent(fileData);
                    fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("multipart/form-data");
                    content.Add(fileContent, "File", Path.GetFileName(filePath));

                    HttpResponseMessage response = await client.PutAsync("http://localhost:5000/api/labs", content);

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
