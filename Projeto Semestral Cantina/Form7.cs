﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Semestral_Cantina
{
    public partial class FormChamada : Form
    {
        public FormChamada()
        {
            InitializeComponent();
        }

        private void btnRetornarLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
