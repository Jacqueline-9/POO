﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehículos
{
    public partial class FormVehiculos : Form
    {
        Aereo objAereo = new Aereo();

        public FormVehiculos()
        {
            InitializeComponent();

            cmbTipoVehiculo.Items.Add("Helicóptero");
            cmbTipoVehiculo.Items.Add("Avión");
            cmbTipoVehiculo.Items.Add("Avioneta");
            cmbTipoVehiculo.Items.Add("Globo Aerostático");
            cmbTipoVehiculo.Items.Add("Dirigible");
            cmbTipoVehiculo.Items.Add("Paramotor");
            cmbTipoVehiculo.Items.Add("Avión Deportivo");
            cmbTipoVehiculo.Items.Add("Cohete");
        }

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            if (txtTipoCombustible.Text == "")
            {
                errorProvider1.SetError(txtTipoCombustible, "Debe Introducir el Tipo de Combustible");
                txtTipoCombustible.Focus();
                return;
            }
            errorProvider1.SetError(txtTipoCombustible, "");

            if (txtColor.Text == "")
            {
                errorProvider1.SetError(txtColor, "Debe Introducir el Color del Vehículo");
                txtColor.Focus();
                return;
            }
            errorProvider1.SetError(txtColor, "");

            if (txtNumeroLlantas.Text == "")
            {
                errorProvider1.SetError(txtNumeroLlantas, "Debe introducir el número de llantas del vehículo");
                txtNumeroLlantas.Focus();
                return;
            }
            errorProvider1.SetError(txtNumeroLlantas, "");

            if (txtNumeroVentanas.Text == "")
            {
                errorProvider1.SetError(txtNumeroVentanas, "Debe introducir el número de ventanas del vehículo");
                txtNumeroVentanas.Focus();
                return;
            }
            errorProvider1.SetError(txtNumeroVentanas, "");

            if (txtNumAlas.Text == "")
            {
                errorProvider1.SetError(txtNumAlas, "Debe introducir el número de alas del vehículo aéreo");
                txtNumAlas.Focus();
                return;
            }
            errorProvider1.SetError(txtNumAlas, "");

            if (txtNumTurbinas.Text == "")
            {
                errorProvider1.SetError(txtNumTurbinas, "Debe introducir el número de turbinas del vehículo aéreo");
                txtNumTurbinas.Focus();
                return;
            }
            errorProvider1.SetError(txtNumTurbinas, "");

            if (txtNumHelices.Text == "")
            {
                errorProvider1.SetError(txtNumHelices, "Debe introducir el número de hélices del vehículo aéreo");
                txtNumHelices.Focus();
                return;
            }
            errorProvider1.SetError(txtNumHelices, "");

            if (cmbTipoVehiculo.Text == "")
            {
                errorProvider1.SetError(cmbTipoVehiculo, "Debe introducir el tipo de vehículo aéreo");
                cmbTipoVehiculo.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipoVehiculo, "");

            MessageBox.Show(objAereo.ArrancarMotor(txtSonido.Text));
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objAereo.PararMotor(txtParar.Text));
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            objAereo.estado = btnEstado.Text;
            objAereo.tipoAereo = cmbTipoVehiculo.Text.ToString();
            objAereo.enVuelo();
            MessageBox.Show(objAereo.enVuelo());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objAereo.tipoCombustible = txtTipoCombustible.Text;
            objAereo.color = txtColor.Text;
            objAereo.numeroLlantas = int.Parse(txtNumeroLlantas.Text);
            objAereo.numeroVentanas = int.Parse(txtNumeroVentanas.Text);
            objAereo.numAlas = int.Parse(txtNumAlas.Text);
            objAereo.numTurbinas = int.Parse(txtNumTurbinas.Text);
            objAereo.numHelices = int.Parse(txtNumHelices.Text);
            objAereo.tipoAereo = cmbTipoVehiculo.Text;
            MessageBox.Show("La indormación de " + cmbTipoVehiculo.Text + " se guardo correctamente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
