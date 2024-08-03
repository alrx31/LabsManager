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

        public SubjectMenuForm(Subject sbj,PersonsBase person, int ruleLevel)
        {
            _service = new SubjectsService();

            InitializeComponent();

            _toParse = sbj.author.name;
            _toParse = sbj.id + "" + ". Название: " + sbj.name + "\nКоличество Лабораторных: " + (sbj.labs != null ? sbj.labs.Count + "" : 0 + "") + "\nОписание: " + sbj.description + "\nНужно часов: " + sbj.needHours + "\nАвтор: " + sbj.author.name;
            label1.Text = _toParse;
            if(ruleLevel == 1)
            {
                var SubscButton = new Button();
                SubscButton.FlatStyle = FlatStyle.Flat;
                SubscButton.FlatAppearance.BorderSize = 0;
                SubscButton.Visible = true;

                if (!checkIsFollow(sbj, person))
                {
                    SubscButton.Text = "Записаться";
                }
                else
                {
                    SubscButton.Text = "Отписаться";
                }
            }else if(ruleLevel >= 2)
            {
                throw new NotImplementedException();
            }


        }



        bool checkIsFollow(Subject sbj, PersonsBase person)
        {
            return true;
        }
        
    }



}
