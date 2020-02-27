using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoElectricidad
{
    public partial class Form1 : Form
    {
        ClassRecibo objRecibo = new ClassRecibo();

        public Form1()
        {
            InitializeComponent();

            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbTipo.Items.Add("Hogar");
            cmbTipo.Items.Add("Negocio");

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeterminarCosto_Click(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "")
            {
                errorProvider1.SetError(cmbTipo, "Debe seleccionar un tipo");
                cmbTipo.Focus();
                return;
            }

            if (txtKW.Text == "")
            {
                errorProvider2.SetError(txtKW, "Debe introducir cantidad de KW");
                txtKW.Focus();
                return;
            }
            
            objRecibo.tipo = cmbTipo.Text;
            objRecibo.kW = Convert.ToDouble (txtKW.Text);
            objRecibo.DeterminarConsumo();
            txtConsumo.Text = objRecibo.consumoelec.ToString();
        }
    }
}