﻿using System;
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
        public LabCreateForm(int userId)
        {
            _userId = userId;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: open and load files 
            throw new NotImplementedException("Not implemented yet");
        }
    }
}
