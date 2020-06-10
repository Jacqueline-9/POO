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

namespace DatosPaisesMundo
{
    public partial class FormDatosPaisesMundoAr : Form
    {
        //Creación del objeto
        DatosPaisessAr Paises = new DatosPaisessAr();

        TextWriter archivo;
        string datosArchivo;

        public FormDatosPaisesMundoAr()
        {
            InitializeComponent();

            //Elementos que se encuentran en el combobox Idioma
            cmbIdioma.Items.Add("Afrikaans");
            cmbIdioma.Items.Add("Albanés");
            cmbIdioma.Items.Add("Alemán");
            cmbIdioma.Items.Add("Amharico");
            cmbIdioma.Items.Add("Árabe");
            cmbIdioma.Items.Add("Armenio");
            cmbIdioma.Items.Add("Bengali");
            cmbIdioma.Items.Add("Bieloruso");
            cmbIdioma.Items.Add("Birmanés");
            cmbIdioma.Items.Add("Bulgaro");
            cmbIdioma.Items.Add("Catalan");
            cmbIdioma.Items.Add("Checo");
            cmbIdioma.Items.Add("Chino");
            cmbIdioma.Items.Add("Coreano");
            cmbIdioma.Items.Add("Croata");
            cmbIdioma.Items.Add("Danés");
            cmbIdioma.Items.Add("Dari");
            cmbIdioma.Items.Add("Dzongkha");
            cmbIdioma.Items.Add("Escocés");
            cmbIdioma.Items.Add("Eslovaco");
            cmbIdioma.Items.Add("Esloveniano");
            cmbIdioma.Items.Add("Español");
            cmbIdioma.Items.Add("Esperanto");
            cmbIdioma.Items.Add("Estoniano");
            cmbIdioma.Items.Add("Faroese");
            cmbIdioma.Items.Add("Farsi");
            cmbIdioma.Items.Add("Finlandés");
            cmbIdioma.Items.Add("Francés");
            cmbIdioma.Items.Add("Gaelico");
            cmbIdioma.Items.Add("Galese");
            cmbIdioma.Items.Add("Gallego");
            cmbIdioma.Items.Add("Griego");
            cmbIdioma.Items.Add("Hebreo");
            cmbIdioma.Items.Add("Hindi");
            cmbIdioma.Items.Add("Holandés");
            cmbIdioma.Items.Add("Hungaro");
            cmbIdioma.Items.Add("Inglés");
            cmbIdioma.Items.Add("Indonesio");
            cmbIdioma.Items.Add("Inuktitu (Eskimo)");
            cmbIdioma.Items.Add("Islandico");
            cmbIdioma.Items.Add("Italiano");
            cmbIdioma.Items.Add("Jápones");
            cmbIdioma.Items.Add("Khmer");
            cmbIdioma.Items.Add("Kurdo");
            cmbIdioma.Items.Add("Lao");
            cmbIdioma.Items.Add("Laponico");
            cmbIdioma.Items.Add("Latviano");
            cmbIdioma.Items.Add("Lituano");
            cmbIdioma.Items.Add("Macedonio");
            cmbIdioma.Items.Add("Malayés");
            cmbIdioma.Items.Add("Maltés");
            cmbIdioma.Items.Add("Nepali");
            cmbIdioma.Items.Add("Noruego");
            cmbIdioma.Items.Add("Pashto");
            cmbIdioma.Items.Add("Polaco");
            cmbIdioma.Items.Add("Portugués");
            cmbIdioma.Items.Add("Rumano");
            cmbIdioma.Items.Add("Ruso");
            cmbIdioma.Items.Add("Serbio");
            cmbIdioma.Items.Add("Somali");
            cmbIdioma.Items.Add("Suahili");
            cmbIdioma.Items.Add("Sueco");
            cmbIdioma.Items.Add("Tagalog-Filipino");
            cmbIdioma.Items.Add("Tajik");
            cmbIdioma.Items.Add("Tamil");
            cmbIdioma.Items.Add("Tailandés");
            cmbIdioma.Items.Add("Tibetano");
            cmbIdioma.Items.Add("Triginia");
            cmbIdioma.Items.Add("Tonganés");
            cmbIdioma.Items.Add("Turco");
            cmbIdioma.Items.Add("Turkmenistano");
            cmbIdioma.Items.Add("Ucraniano");
            cmbIdioma.Items.Add("Urdo");
            cmbIdioma.Items.Add("Uzbekistano");
            cmbIdioma.Items.Add("Vasco");
            cmbIdioma.Items.Add("Vietnamés");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tsbGuardarImprimir_Click(object sender, EventArgs e)
        {
            archivo = new StreamWriter("archivo.txt");

            //Validación de las cajas de texto
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Introducir nombre del país");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            if (txtPoblacion.Text == "")
            {
                errorProvider1.SetError(txtPoblacion, "Introducir cantidad de población");
                txtPoblacion.Focus();
                return;
            }
            errorProvider1.SetError(txtPoblacion, "");

            if (txtColor1.Text == "")
            {
                errorProvider1.SetError(txtColor1, "Introduzca color 1 de la bandera");
                txtColor1.Focus();
                return;
            }
            errorProvider1.SetError(txtColor1, "");

            if (txtColor2.Text == "")
            {
                errorProvider1.SetError(txtColor2, "Introduzca color 2 de la bandera");
                txtColor2.Focus();
                return;
            }
            errorProvider1.SetError(txtColor2, "");

            if (txtColor3.Text == "")
            {
                errorProvider1.SetError(txtColor3, "Introduzca color 3 de la bandera");
                txtColor3.Focus();
                return;
            }
            errorProvider1.SetError(txtColor3, "");

            //Guardar datos
            Paises.NombrePais = txtNombre.Text;
            datosArchivo += "Nombre del país: " + Paises.NombrePais + "\n";

            Paises.Poblacion = int.Parse(txtPoblacion.Text);
            datosArchivo += "Población: " + Paises.Poblacion + "\n";

            Paises.Idioma = cmbIdioma.Text;
            datosArchivo += "Idioma: " + Paises.Idioma + "\n";

            Paises.Colores = new string[3];

            datosArchivo += "Principales colores de la bandera" + "\n";

            Paises.Colores[0] = txtColor1.Text;
            datosArchivo += "Color 1: " + Paises.Colores[0]+ "\n";

            Paises.Colores[1] = txtColor2.Text;
            datosArchivo += "Color 2: " + Paises.Colores[1] + "\n";

            Paises.Colores[2] = txtColor3.Text;
            datosArchivo += "Color 3: " + Paises.Colores[2] + "\n";

            //Método para limpiar las cajas de texto
            txtNombre.Clear();
            txtPoblacion.Clear();
            txtColor1.Clear();
            txtColor2.Clear();
            txtColor3.Clear();

            //Imprimir datos en los labeles 
            lblNombrePais.Text = "Nombre del País: " + Paises.NombrePais;
            lblTotalPoblacion.Text = "Total de Población: " + Paises.Poblacion.ToString();
            lblIdiomaI.Text = "Idioma: " + Paises.Idioma;
            lblPrimerColor.Text = "Primer color: " + Paises.Colores[0];
            lblSegundoColor.Text = "Segundo color: " + Paises.Colores[1];
            lblTercerColor.Text = "Tercer color: " + Paises.Colores[2];

            archivo.WriteLine(datosArchivo);
            archivo.Close();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
