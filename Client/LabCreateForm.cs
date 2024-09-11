using domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabsManager
{
    public partial class LabCreateForm : Form
    {
        private readonly int _userId;
        private byte[] fileData;
        public Lab laboratory;

        public LabCreateForm(int userId)
        {
            _userId = userId;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Word Documents|*.docx",
                Title = "Выберите файл Word"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                fileData = File.ReadAllBytes(filePath);
                MessageBox.Show("Файл успешно загружен");
            }
        }

        private void buttonCreate2_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var description = richTextBoxDesc.Text;
            var materials = richTextBoxMaterials.Text;
            var lab = new Lab()
            {
                name = name,
                description = description,
                materials = materials,
                exercises = fileData,
            };

            laboratory = lab;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
