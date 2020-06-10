using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumMayMen
{
    public partial class FormNumMayMenAr : Form
    {
        NumerosArc objnumeros = new NumerosArc();

        int cantidadNum = 0;
        int con = 1;
        int i = 0;

        TextWriter archivo;
        String datosArchivo;

        public FormNumMayMenAr()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            archivo = new StreamWriter("archivo.txt");

            if (txtCantidad.Text == "")
            {
                errorProvider1.SetError(txtCantidad, "Ingresar cantidad");
                txtCantidad.Focus();
                return;
            }
            errorProvider1.SetError(txtCantidad, "");

            cantidadNum = int.Parse(txtCantidad.Text);
            datosArchivo += "Cantidad de números: " + cantidadNum + "\n";

            txtNumero.Enabled = true;
            btnGuardar.Enabled = true;
            txtCantidad.Enabled = false;
            btnEnter.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                errorProvider1.SetError(txtNumero, "Ingresar número");
                txtNumero.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero, "");

            if (con == 1)
            { objnumeros.arregloNum = new int[cantidadNum]; }

            if (con < cantidadNum)
            {
                con++;

                objnumeros.arregloNum[i] = int.Parse(txtNumero.Text);
                datosArchivo += "Número: " + objnumeros.arregloNum[i].ToString() + "\n";

                txtNumero.Clear();

                i++;
            }
            else if (con == cantidadNum)
            {
                objnumeros.arregloNum[i] = int.Parse(txtNumero.Text);
                datosArchivo += "Número: " + objnumeros.arregloNum[i].ToString() + "\n";

                MessageBox.Show("La cantidad de números se registraron correctamente", "Proceso Correcto", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                txtNumero.Clear();

                btnCalcular.Enabled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objnumeros.MayorMenor(), "Número Mayor y Menor", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            datosArchivo += "El número menor es: " + objnumeros.Menor + "\n";
            datosArchivo += "El número mayor es: " + objnumeros.Mayor + "\n";

            archivo.WriteLine(datosArchivo);
            archivo.Close();

            txtCantidad.Enabled = true;
            txtNumero.Enabled = false;
            btnEnter.Enabled = true;
            btnGuardar.Enabled = false;
            btnCalcular.Enabled = false;
            txtCantidad.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
