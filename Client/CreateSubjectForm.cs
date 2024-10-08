﻿using domain.entities;
using LabsManager.domain.services;
using LabsManager.infastructure.repositories;
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
    public partial class CreateSubjectForm : Form
    {
        private readonly ISubjectsService _servise;
        private readonly int userId;

        private List<Lab> labs = new List<Lab>();  

        public CreateSubjectForm(int userId)
        {
            _servise = new SubjectsService();
            InitializeComponent();
            this.userId = userId;
        }

        private void buttonCreateSubject_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(this.textBoxName.Text) ||
                String.IsNullOrEmpty(this.richTextBoxDesc.Text) ||
                this.numericUpDownNeedHours.Value == 0
                )
            {
                MessageBox.Show("Заполните все поля");
            }




            var sbj = new Subject
            {
                name = this.textBoxName.Text,
                description = this.richTextBoxDesc.Text,
                needHours = (int)this.numericUpDownNeedHours.Value,
                authorId = this.userId,
                labs = labs
            };


            foreach(var lab in labs)
            {
                _servise.addLaboratory(lab);
            }
            
            _servise.AddSubject(sbj);

            MessageBox.Show("Done");
            this.Close();
        }

        private void buttonAddLaboratory_Click(object sender, EventArgs e)
        {
            var laboratoryForm = new LabCreateForm(userId);
            
            if(laboratoryForm.ShowDialog() == DialogResult.OK)
            {
                var res = laboratoryForm.laboratory;
                labs.Add(res);
                MessageBox.Show("Лабораторная работа добавлена");
                updateLabsList();
            }
        }

        private void updateLabsList()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var lab in labs)
            {
                Panel panel = new Panel();
                panel.Size = new Size(100,100);
                panel.BackColor = Color.White;
                Label label = new Label();
                label.Text = lab.name;
                label.TextAlign = ContentAlignment.MiddleCenter;

                panel.Controls.Add(label);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

    }
}
