using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perritos
{
    public partial class FormPerritos : Form
    {
        Perritos[] objPerritos;

        int con = 1;
        int i = 0;
        int cantidad = 0;
        int fila = 2;
        double[] promedio;
        int acumF = 0;

        public FormPerritos()
        {
            InitializeComponent();

            cmbSexo.Items.Add("Cachorro");
            cmbSexo.Items.Add("Cachorra");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                errorProvider1.SetError(txtCantidad, "Ingrese cantidad");
                txtCantidad.Focus();
                return;
            }
            errorProvider1.SetError(txtCantidad, "");

            cantidad = int.Parse(txtCantidad.Text);

            txtCantidad.Enabled = false;
            btnEnter.Enabled = false;
            gpbDatos.Enabled = true;
            btnRegistrar.Enabled = true;

            if (con == 1)
            {
                objPerritos = new Perritos[cantidad];
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtEdad.Text == "")
            {
                errorProvider1.SetError(txtEdad, "Ingrese la edad");
                txtEdad.Focus();
                return;
            }
            errorProvider1.SetError(txtEdad, "");

            if (txtPeso.Text == "")
            {
                errorProvider1.SetError(txtPeso, "Ingrese el peso");
                txtPeso.Focus();
                return;
            }
            errorProvider1.SetError(txtPeso, "");

            if (txtColor1.Text == "")
            {
                errorProvider1.SetError(txtColor1, "Ingrese el primer color del perrito");
                txtColor1.Focus();
                return;
            }
            errorProvider1.SetError(txtColor1, "");

            if (txtColor2.Text == "")
            {
                errorProvider1.SetError(txtColor2, "Ingrese el segundo color del perrito, si no tiene, ingrese 'Ninguno'");
                txtColor2.Focus();
                return;
            }
            errorProvider1.SetError(txtColor2, "");

            if (con < cantidad)
            {
                con++;

                objPerritos[i] = new Perritos();

                objPerritos[i].Perrito = new string[fila, cantidad];

                for (int f = 0; f < fila; f++)
                {
                    objPerritos[i].Nombre = txtNombre.Text;
                    objPerritos[i].Perrito[f, 0] = objPerritos[i].Nombre;

                    for (int c = 0; c < cantidad; c++)
                    {
                        objPerritos[i].Edad = int.Parse(txtEdad.Text);
                        objPerritos[i].Perrito[f, c] = objPerritos[i].Edad.ToString();
                    }
                }

                objPerritos[i].Peso = double.Parse(txtPeso.Text);
                objPerritos[i].Sexo = cmbSexo.Text;
                objPerritos[i].Color = new string[2];
                objPerritos[i].Color[0] = txtColor1.Text;
                objPerritos[i].Color[1] = txtColor2.Text;
                objPerritos[i].FechaIn = dtpFechaIn.Value;
                objPerritos[i].FechaEgre = dtpFechaTer.Value;

                txtNombre.Clear();
                txtEdad.Clear();
                txtPeso.Clear();
                txtColor1.Clear();
                txtColor2.Clear();

                i++;
            }
            else if (con == cantidad)
            {
                objPerritos[i] = new Perritos();

                objPerritos[i].Perrito = new string[fila, cantidad];

                for (int f = 0; f < fila; f++)
                {
                    objPerritos[i].Nombre = txtNombre.Text;
                    objPerritos[f].Perrito[f, 0] = objPerritos[i].Nombre;

                    for (int c = 0; c < cantidad; c++)
                    {
                        objPerritos[i].Edad = int.Parse(txtEdad.Text);
                        objPerritos[c].Perrito[f, c] = objPerritos[i].Edad.ToString();
                    }
                }

                objPerritos[i].Peso = double.Parse(txtPeso.Text);
                objPerritos[i].Sexo = cmbSexo.Text;
                objPerritos[i].Color = new string[2];
                objPerritos[i].Color[0] = txtColor1.Text;
                objPerritos[i].Color[1] = txtColor2.Text;
                objPerritos[i].FechaIn = dtpFechaIn.Value;
                objPerritos[i].FechaEgre = dtpFechaTer.Value;

                txtNombre.Clear();
                txtEdad.Clear();
                txtPeso.Clear();
                txtColor1.Clear();
                txtColor2.Clear();

                MessageBox.Show("Se han registrado correctamente los datos de los perritos", "Registro Correcto", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                gpbDatos.Enabled = false;
                btnRegistrar.Enabled = false;
                btnImprimir.Enabled = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dgvDatosPerritos.Rows.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                if (objPerritos[i].Nombre != "" & objPerritos[i].Edad != 0)
                {
                    dgvDatosPerritos.Rows.Add(objPerritos[i].Nombre, objPerritos[i].Edad, objPerritos[i].Peso, objPerritos[i].Sexo, objPerritos[i].Color[0], objPerritos[i].Color[1], objPerritos[i].FechaIn, objPerritos[i].FechaEgre);
                }
            }

            btnPromedio.Enabled = true;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            promedio = new double[cantidad];

            for (int f = 1; f < objPerritos[i].Perrito.GetLength(0); f++)
            {
                int suma = 0;

                for (int c = 1; c < objPerritos[i].Perrito.GetLength(1); c++)
                {
                    suma += Convert.ToInt32(objPerritos[i].Perrito[f, c]);
                    acumF += suma;
                }
                promedio[f] = acumF / cantidad;
            }

            for (int f = 1; f < objPerritos[i].Perrito.GetLength(0); f++)
            {
                acumF += Convert.ToInt32(promedio[f]);
                MessageBox.Show("El promedio de las edades de los perritos que ingresaron es: " + acumF);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

