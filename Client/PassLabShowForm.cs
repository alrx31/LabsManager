﻿using domain.entities;
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
    public partial class PassLabShowForm : Form
    {
        public PassLabShowForm(int personId, PassLabModel model)
        {
            InitializeComponent();
        }
    }
}