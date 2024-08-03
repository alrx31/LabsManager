﻿using domain.entities;
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

namespace LabsManager
{
    public partial class SubjectMenuForm : Form
    {
        private readonly string _toParse;

        public SubjectMenuForm(Subject sbj)
        {
            InitializeComponent();

            _toParse = sbj.name;
            label1.Text = _toParse;
        }
        
    }



}
