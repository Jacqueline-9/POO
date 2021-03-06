﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embotelladora
{
    public partial class FormEmbotelladora : Form
    {
        public FormEmbotelladora()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            ClassBotella objBotella = new ClassBotella();

            objBotella.nivelLlenado = Convert.ToInt32(txtNivelLlenado.Text);
            MessageBox.Show(objBotella.verificarLlenado());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
