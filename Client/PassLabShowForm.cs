using domain.entities;
using System.Text.Json;

namespace LabsManager
{
    public partial class PassLabShowForm : Form
    {
        private int _personId;
        private PassLabModel _model;
        private bool _isTeacher;

        public PassLabShowForm(int personId,bool isTeacher, PassLabModel model)
        {
            _personId = personId;
            _model = model;
            _isTeacher = isTeacher;

            InitializeComponent();
        }

        private void PassLabShowForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Студент: " + _model.student.name;
            label2.Text = "Лабораторная: " + _model.lab.name;
            label3.Text = _model.isChecked ? "Проверена" : "Не проверена";
            label4.Text = _model.isChecked ? $"Оценка: {_model.mark}" : "";
            label5.Text = "Отчет студента";
            label6.Text = "Оценка";

            if (!_isTeacher)
            {
                label6.Visible = false;
                numericUpDown1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "All files (*.*)|*.*", // Set a generic filter; the specific one can be handled later
                FileName = $"{_model.LabId}_{_model.StudentId}{_model.fileExtension}" // Use the extension here
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                byte[] fileData = _model.report;
                File.WriteAllBytes(saveFileDialog.FileName, fileData);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var url = $"{ENV.BASEURL}/api/pass/{_model.id}/{numericUpDown1.Value}";
            var client = new HttpClient();
            var response = await client.SendAsync(new HttpRequestMessage(new HttpMethod("POST"), url));

            MessageBox.Show("оценка выставлена ");
            this.Close();
        }
    }
}
