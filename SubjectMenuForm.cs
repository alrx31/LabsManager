using domain.entities;
using LabsManager.domain.services;
using LabsManager.infastructure.repositories;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabsManager
{
    public partial class SubjectMenuForm : Form
    {
        private readonly string _toParse;
        private readonly ISubjectsService _service;
        private readonly int _ruleLevel;
        private readonly Subject sbj;
        private readonly PersonsBase person;

        public SubjectMenuForm(Subject sbj, PersonsBase person, int ruleLevel)
        {
            this.person = person;
            this.sbj = sbj;
            _service = new SubjectsService();
            _ruleLevel = ruleLevel;
            _toParse = sbj.author.name;
            _toParse = sbj.id + "" + ". Название: " + sbj.name + "\nКоличество Лабораторных: " + (sbj.labs != null ? sbj.labs.Count + "" : 0 + "") + "\nОписание: " + sbj.description + "\nНужно часов: " + sbj.needHours + "\nАвтор: " + sbj.author.name;

            InitializeComponent();
            DrawUI();
        }

        async void DrawUI()
        {
            label1.Text = _toParse;
            if (_ruleLevel == 1)
            {
                SubscButton.FlatStyle = FlatStyle.Flat;
                SubscButton.FlatAppearance.BorderSize = 0;
                SubscButton.Visible = true;


                if (!await checkIsFollow(sbj, person))
                {
                    SubscButton.Text = "Записаться";
                }
                else
                {
                    SubscButton.Text = "Отписаться";
                }
            }
            else if (_ruleLevel >= 2 && sbj.authorId == person.id)
            {

                SubscButton.FlatStyle = FlatStyle.Flat;
                SubscButton.FlatAppearance.BorderSize = 0;
                SubscButton.Visible = true;

                SubscButton.Text = "Редактировать";
            }
            else
            {
                SubscButton.Visible = false;
            }
        }

        async Task<bool> checkIsFollow(Subject sbj, PersonsBase person)
        {
            return await _service.checkFollow(sbj,person.id);
        }

        private void SubscButton_Click(object sender, EventArgs e)
        {
            if(_ruleLevel == 1)
            {
                if (SubscButton.Text == "Записаться")
                {
                    _service.createRegistration(sbj, person.id);
                    MessageBox.Show("Success");
                    SubscButton.Text = "Отписаться";
                }
                else
                {
                    _service.canselRegistration(sbj, person.id);
                    MessageBox.Show("Success");
                    SubscButton.Text = "Записаться";

                }
            }
        }
    }



}
