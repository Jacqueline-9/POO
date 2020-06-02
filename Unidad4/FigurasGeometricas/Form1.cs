using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{

    public partial class Form1 : Form
    {

        Cuadrado objCuadrado = new Cuadrado();
        Triangulo objTriangulo = new Triangulo();
        Circulo objCirculo = new Circulo();

        public Form1()
        {
            InitializeComponent();
            cmbFigura.Items.Add("Cuadrado");
            cmbFigura.Items.Add("Triángulo");
            cmbFigura.Items.Add("Circulo");

            cmbTipo.Items.Add("Isósceles");
            cmbTipo.Items.Add("Escaleno");
            cmbTipo.Items.Add("Equilatero");
            cmbTipo.Items.Add("Rectángulo");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cmbFigura.Text == "")
            {
                errorProvider1.SetError(cmbFigura, "Seleccione una figura");
                cmbFigura.Focus();
                return;
            }
            errorProvider1.SetError(cmbFigura, "");

            if (cmbFigura.Text == "Triángulo")
            {
                this.lblLado.Visible = true;
                this.txtLadoo.Visible = true;
                this.btnSelec.Visible = true;
                this.lblLado.Visible = true;
                this.txtLadoo.Visible = true;
                this.btnSelec.Visible = true;
                this.lblTipo.Visible = true;
                this.cmbTipo.Visible = true;
                this.lblAltura.Visible = true;
                this.txtAltura.Visible = true;
                this.btnCalcular.Visible = true;
            }
           else
            {
                this.lblLado.Visible = true;
                this.txtLadoo.Visible = true;
                this.btnSelec.Visible = false;
                this.lblTipo.Visible = false;
                this.cmbTipo.Visible = false;
                this.lblLados.Visible = false;
                this.txtLados.Visible = false;
                this.lblLadoIz.Visible = false;
                this.lblLadoDe.Visible = false;
                this.txtLadoIz.Visible = false;
                this.txtLadoD.Visible = false;
                this.lblAltura.Visible = false;
                this.txtAltura.Visible = false;
                this.btnCalcular.Visible = true;
            }
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            if (txtLadoo.Text == "")
            {
                errorProvider1.SetError(txtLadoo, "Introducir el valor del lado");
                txtLadoo.Focus();
                return;
            }
            errorProvider1.SetError(txtLadoo, "");

            if (cmbFigura.Text == "Cuadrado")
            {
                objCuadrado.Lado = Convert.ToDouble(txtLadoo.Text);
                objCuadrado.CalArea();
                objCuadrado.CalPerimetro();

                double Lado = Convert.ToDouble(txtLadoo.Text);
                CuadradoForm CuaForm = new CuadradoForm(Lado);
                CuaForm.txtAreaC.Text = objCuadrado.Area.ToString();
                CuaForm.txtPerimetroC.Text = objCuadrado.Perimetro.ToString();
                CuaForm.Show();
            }

            if (cmbFigura.Text == "Triángulo")
            {
                if (txtAltura.Text == "")
                {
                    errorProvider1.SetError(txtAltura, "Inroducir el valor de la altura");
                    txtAltura.Focus();
                    return;
                }
                errorProvider1.SetError(txtAltura, "");

                if (cmbTipo.Text =="Isósceles")
                {
                    objTriangulo.Lado = double.Parse(txtLadoo.Text);
                    objTriangulo.Altura = double.Parse(txtAltura.Text);
                    objTriangulo.Lados = double.Parse(txtLados.Text);
                    objTriangulo.Tipo = cmbTipo.Text;
                    objTriangulo.CalArea();
                    objTriangulo.CalPerimetro();
                }
                else if (cmbTipo.Text == "Escaleno")
                {
                    objTriangulo.Tipo = cmbTipo.Text;
                    objTriangulo.Lado = double.Parse(txtLadoo.Text);
                    objTriangulo.Altura = double.Parse(txtAltura.Text);
                    objTriangulo.LadoDe = double.Parse(txtLadoD.Text);
                    objTriangulo.LadoIz = double.Parse(txtLadoIz.Text);
                    objTriangulo.CalArea();
                    objTriangulo.CalPerimetro();
                }
                else if (cmbTipo.Text == "Equilatero")
                {
                    objTriangulo.Tipo = cmbTipo.Text;
                    objTriangulo.Lado = double.Parse(txtLadoo.Text);
                    objTriangulo.Altura = double.Parse(txtAltura.Text);
                    objTriangulo.CalArea();
                    objTriangulo.CalPerimetro();
                }
                else if (cmbTipo.Text == "Rectángulo")
                {
                    objTriangulo.Tipo = cmbTipo.Text;
                    objTriangulo.Lado = double.Parse(txtLadoo.Text);
                    objTriangulo.Altura = double.Parse(txtAltura.Text);
                    objTriangulo.Hipotenusa = double.Parse(txtHipotenusa.Text);
                    objTriangulo.CalArea();
                    objTriangulo.CalPerimetro();
                }

                double Lado = Convert.ToDouble(txtLadoo.Text);
                TrianguloForm TrainForm = new TrianguloForm(Lado);
                TrainForm.txtAreaT.Text = objTriangulo.Area.ToString();
                TrainForm.txtPerimetroT.Text = objTriangulo.Perimetro.ToString();
                TrainForm.Show();

            }

            if (cmbFigura.Text == "Circulo")
            {
                objCirculo.Lado = Convert.ToDouble(txtLadoo.Text);
                objCirculo.CalArea();
                objCirculo.CalPerimetro();

                double Lado = Convert.ToDouble(txtLadoo.Text);
                CirculoForm CirForm = new CirculoForm(Lado);
                CirForm.txtArea.Text = objCirculo.Area.ToString();
                CirForm.txtPerimetro.Text = objCirculo.Perimetro.ToString();
                CirForm.Show();
            }

        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Isósceles")
            {
                this.lblLados.Visible = true;
                this.txtLados.Visible = true;
            }
            else if (cmbTipo.Text == "Escaleno")
            {
                this.lblLados.Visible = false;
                this.txtLados.Visible = false;
                this.lblLadoIz.Visible = true;
                this.lblLadoDe.Visible = true;
                this.txtLadoIz.Visible = true;
                this.txtLadoD.Visible = true;
                this.lblHipotenusa.Visible = false;
                this.txtHipotenusa.Visible = false;
            }
            else if (cmbTipo.Text == "Equilatero")
            {
                this.lblLados.Visible = false;
                this.txtLados.Visible = false;
                this.lblLadoIz.Visible = false;
                this.lblLadoDe.Visible = false;
                this.txtLadoIz.Visible = false;
                this.txtLadoD.Visible = false;
                this.lblHipotenusa.Visible = false;
                this.txtHipotenusa.Visible = false;
            }
            else if (cmbTipo.Text == "Rectángulo")
            {
                this.lblHipotenusa.Visible = true;
                this.txtHipotenusa.Visible = true;
                this.lblLados.Visible = false;
                this.txtLados.Visible = false;
                this.lblLadoIz.Visible = false;
                this.lblLadoDe.Visible = false;
                this.txtLadoIz.Visible = false;
                this.txtLadoD.Visible = false;
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
