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

namespace DatosPaisesN
{
    public partial class FormDatosNPaisesAr : Form
    {
        //Variables globales que se necesitaran en el transcurso del proyecto
        int cantidadPaises;
        int con = 1;
        int i = 0;

        //Declaración el arreglo de objetos
        DatosNPaisesAr[] Paises;

        TextWriter archivo;
        string datosArchivo;

        public FormDatosNPaisesAr()
        {
            InitializeComponent();

            //Idiomas que se encuentran en el combobox idioma
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

            //Paises que se encuentran en el combobox pais
            cmbPais.Items.Add("Afganistán");
            cmbPais.Items.Add("Albania");
            cmbPais.Items.Add("Alemania");
            cmbPais.Items.Add("Andorra");
            cmbPais.Items.Add("Angola");
            cmbPais.Items.Add("Antigua y Barbuda");
            cmbPais.Items.Add("Arabia Saudita");
            cmbPais.Items.Add("Argelia");
            cmbPais.Items.Add("Argentina");
            cmbPais.Items.Add("Armenia");
            cmbPais.Items.Add("Australia");
            cmbPais.Items.Add("Austria");
            cmbPais.Items.Add("Azerbaiyán");
            cmbPais.Items.Add("Bahamas");
            cmbPais.Items.Add("Bangladés");
            cmbPais.Items.Add("Barbados");
            cmbPais.Items.Add("Baréin");
            cmbPais.Items.Add("Bélgica");
            cmbPais.Items.Add("Belice");
            cmbPais.Items.Add("Benín");
            cmbPais.Items.Add("Bielorrusa");
            cmbPais.Items.Add("Birmania");
            cmbPais.Items.Add("Bolivia");
            cmbPais.Items.Add("Bosnia-Herzegovina");
            cmbPais.Items.Add("Botsuna");
            cmbPais.Items.Add("Brasil");
            cmbPais.Items.Add("Brunéi");
            cmbPais.Items.Add("Bulgaria");
            cmbPais.Items.Add("Burkina Faso");
            cmbPais.Items.Add("Burundi");
            cmbPais.Items.Add("Bután");
            cmbPais.Items.Add("Cabo Verde");
            cmbPais.Items.Add("Camboya");
            cmbPais.Items.Add("Camerún");
            cmbPais.Items.Add("Canadá");
            cmbPais.Items.Add("Catar");
            cmbPais.Items.Add("Chad");
            cmbPais.Items.Add("Chile");
            cmbPais.Items.Add("China");
            cmbPais.Items.Add("Chipre");
            cmbPais.Items.Add("Colombia");
            cmbPais.Items.Add("Comoras");
            cmbPais.Items.Add("Congo");
            cmbPais.Items.Add("Corea del Norte");
            cmbPais.Items.Add("Corea del Sur");
            cmbPais.Items.Add("Costa de Marfil");
            cmbPais.Items.Add("Costa Rica");
            cmbPais.Items.Add("Croacia");
            cmbPais.Items.Add("Cuba");
            cmbPais.Items.Add("Dinamarca");
            cmbPais.Items.Add("Dominicana");
            cmbPais.Items.Add("Ecuador");
            cmbPais.Items.Add("Egipto");
            cmbPais.Items.Add("El Salvador");
            cmbPais.Items.Add("Emirantes Árabes Unidos");
            cmbPais.Items.Add("Eritrea");
            cmbPais.Items.Add("Eslovaquia");
            cmbPais.Items.Add("Eslovenia");
            cmbPais.Items.Add("España");
            cmbPais.Items.Add("Estados Unidos");
            cmbPais.Items.Add("Estonia");
            cmbPais.Items.Add("Etiopía");
            cmbPais.Items.Add("Filipinas");
            cmbPais.Items.Add("Finlandia");
            cmbPais.Items.Add("Fiyi");
            cmbPais.Items.Add("Francia");
            cmbPais.Items.Add("Gabón");
            cmbPais.Items.Add("Gambia");
            cmbPais.Items.Add("Georgia");
            cmbPais.Items.Add("Ghana");
            cmbPais.Items.Add("Granada");
            cmbPais.Items.Add("Grecia");
            cmbPais.Items.Add("Guatemala");
            cmbPais.Items.Add("Guinea");
            cmbPais.Items.Add("Guinea Ecuatorial");
            cmbPais.Items.Add("Guinea-Bisáu");
            cmbPais.Items.Add("Guyana");
            cmbPais.Items.Add("Haití");
            cmbPais.Items.Add("Honduras");
            cmbPais.Items.Add("Hungría");
            cmbPais.Items.Add("India");
            cmbPais.Items.Add("Indonesia");
            cmbPais.Items.Add("Irak");
            cmbPais.Items.Add("Irán");
            cmbPais.Items.Add("Irlandia");
            cmbPais.Items.Add("slandia");
            cmbPais.Items.Add("Islas Marshall");
            cmbPais.Items.Add("Islas Salomón");
            cmbPais.Items.Add("Israel");
            cmbPais.Items.Add("Italia");
            cmbPais.Items.Add("Jamaica");
            cmbPais.Items.Add("Japón");
            cmbPais.Items.Add("Jordania");
            cmbPais.Items.Add("Kazajistán");
            cmbPais.Items.Add("Kenia");
            cmbPais.Items.Add("Kirguistán");
            cmbPais.Items.Add("Kiribati");
            cmbPais.Items.Add("Kosovo");
            cmbPais.Items.Add("Kuwait");
            cmbPais.Items.Add("Laos");
            cmbPais.Items.Add("Lesoto");
            cmbPais.Items.Add("Letonia");
            cmbPais.Items.Add("Líbano");
            cmbPais.Items.Add("Liberia");
            cmbPais.Items.Add("Libia");
            cmbPais.Items.Add("Liechtenstein");
            cmbPais.Items.Add("Lituana");
            cmbPais.Items.Add("Luxemburgo");
            cmbPais.Items.Add("Macedonia");
            cmbPais.Items.Add("Madagascar");
            cmbPais.Items.Add("Malasia");
            cmbPais.Items.Add("Malaui");
            cmbPais.Items.Add("Maldivas");
            cmbPais.Items.Add("Malí");
            cmbPais.Items.Add("Malta");
            cmbPais.Items.Add("Marruecos");
            cmbPais.Items.Add("Mauricio");
            cmbPais.Items.Add("Mauritania");
            cmbPais.Items.Add("México");
            cmbPais.Items.Add("Micronesia");
            cmbPais.Items.Add("Moldovia");
            cmbPais.Items.Add("Mónaco");
            cmbPais.Items.Add("Mongolia");
            cmbPais.Items.Add("Montenegro");
            cmbPais.Items.Add("Mozambique");
            cmbPais.Items.Add("Namibia");
            cmbPais.Items.Add("Nauru");
            cmbPais.Items.Add("Nepal");
            cmbPais.Items.Add("Nicaragua");
            cmbPais.Items.Add("Níger");
            cmbPais.Items.Add("Nigeria");
            cmbPais.Items.Add("Noruega");
            cmbPais.Items.Add("Nueva Zelanda");
            cmbPais.Items.Add("Omán");
            cmbPais.Items.Add("Países Bajos");
            cmbPais.Items.Add("Pakistán");
            cmbPais.Items.Add("Palaos");
            cmbPais.Items.Add("Palestina");
            cmbPais.Items.Add("Panamá");
            cmbPais.Items.Add("Papúa Nueva Guinea");
            cmbPais.Items.Add("Paraguay");
            cmbPais.Items.Add("Perú");
            cmbPais.Items.Add("Polonia");
            cmbPais.Items.Add("Portugal");
            cmbPais.Items.Add("Reino Unido");
            cmbPais.Items.Add("República Centroafricana");
            cmbPais.Items.Add("República Checa");
            cmbPais.Items.Add("República Democrática del Congo");
            cmbPais.Items.Add("República Dominicana");
            cmbPais.Items.Add("Ruanda");
            cmbPais.Items.Add("Rumania");
            cmbPais.Items.Add("Rusia");
            cmbPais.Items.Add("Samoa");
            cmbPais.Items.Add("San Cristóbal y Nieves");
            cmbPais.Items.Add("San Marino");
            cmbPais.Items.Add("San Vicente y las Granadinas");
            cmbPais.Items.Add("Santa Lucía");
            cmbPais.Items.Add("Santo Tomé y Príncipe");
            cmbPais.Items.Add("Senegal");
            cmbPais.Items.Add("Serbia");
            cmbPais.Items.Add("Seychelles");
            cmbPais.Items.Add("Sierra Leona");
            cmbPais.Items.Add("Singapur");
            cmbPais.Items.Add("Siria");
            cmbPais.Items.Add("Somalia");
            cmbPais.Items.Add("Sri Lanka");
            cmbPais.Items.Add("Suazilandia");
            cmbPais.Items.Add("Sudáfrica");
            cmbPais.Items.Add("Sudán");
            cmbPais.Items.Add("Sudán del Sur");
            cmbPais.Items.Add("Suecia");
            cmbPais.Items.Add("Suiza");
            cmbPais.Items.Add("Surinam");
            cmbPais.Items.Add("Tailandia");
            cmbPais.Items.Add("Taiwán");
            cmbPais.Items.Add("Tanzania");
            cmbPais.Items.Add("Tayikistán");
            cmbPais.Items.Add("Timor Oriental");
            cmbPais.Items.Add("Togo");
            cmbPais.Items.Add("Tonga");
            cmbPais.Items.Add("Trinidad y Tobago");
            cmbPais.Items.Add("Túnez");
            cmbPais.Items.Add("Turkmenistán");
            cmbPais.Items.Add("Turquía");
            cmbPais.Items.Add("Tuvalu");
            cmbPais.Items.Add("Ucrania");
            cmbPais.Items.Add("Uganda");
            cmbPais.Items.Add("Uruguay");
            cmbPais.Items.Add("Uzbekistán");
            cmbPais.Items.Add("Vanuatu");
            cmbPais.Items.Add("Vaticano");
            cmbPais.Items.Add("Venezuela");
            cmbPais.Items.Add("Vietnam");
            cmbPais.Items.Add("Yemen");
            cmbPais.Items.Add("Yibuti");
            cmbPais.Items.Add("Zambia");
            cmbPais.Items.Add("Zimbabue");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //El valor será indicada por el valor que el usuario ingrese en el txtPaisesRegistrar 
            cantidadPaises = int.Parse(txtPaisesRegistrar.Text);

            //Habilitar los textbox
            this.cmbPais.Enabled = true;
            this.txtPoblacion.Enabled = true;
            this.cmbIdioma.Enabled = true;
            this.txtColor1.Enabled = true;
            this.txtColor2.Enabled = true;
            this.txtColor3.Enabled = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            //Variable para validar un textbox
            decimal Poblacion;

            //Validar un textbox de números
            if (!Decimal.TryParse(txtPoblacion.Text, out Poblacion))
            {
                errorProvider1.SetError(txtPoblacion, "Debe ingresar números en el campo población");
                txtPoblacion.Focus();
                return;
            }

            //Validad textbox
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

            //Condición para sabe que tamaño tendrá el arreglo de objetos
            if (con == 1) { Paises = new DatosNPaisesAr[cantidadPaises]; }

            //Condición para que se inicie el programa 
            if (con < cantidadPaises)
            {
                //Aumento del contador 
                con++;

                //Instancia del arreglo de objetos
                Paises[i] = new DatosNPaisesAr();
                //Paises[i] Indica los datos que se encontrarán en la posición del arreglo de objetos
                datosArchivo += "Nombre del país: ";
                Paises[i].NombrePais = cmbPais.Text;
                datosArchivo = Paises[i].NombrePais + "\n";

                datosArchivo += "Población: ";
                Paises[i].Poblacion = Poblacion;
                datosArchivo += Paises[i].Poblacion + "\n";

                Paises[i].Idioma = cmbIdioma.Text;
                //Indica el tamaño que tiene el arreglo colores
                Paises[i].Colores = new string[3];
                //Se indicá la posición del arreglo colores y de donde tomará su valor
                datosArchivo += "Colores de la bandera" + "\n";

                datosArchivo += "Color 1: ";
                Paises[i].Colores[0] = txtColor1.Text;
                datosArchivo += Paises[i].Colores[0] + "\n";

                datosArchivo += "Color 2: ";
                Paises[i].Colores[1] = txtColor2.Text;
                datosArchivo += Paises[i].Colores[1] + "\n";

                datosArchivo += "Color 3: ";
                Paises[i].Colores[2] = txtColor3.Text;
                datosArchivo += Paises[i].Colores[2] + "\n";

                //Método pata limpiar las cajas de texto
                txtPoblacion.Clear();
                txtColor1.Clear();
                txtColor2.Clear();
                txtColor3.Clear();

                //Incremento de la variable i, que es la posición del arreglo de objeto
                i++;
            }
            //Condición por si la primera no se cumple
            else if (con == cantidadPaises)
            {
                //Instancia del arreglo de objetos
                Paises[i] = new DatosNPaisesAr();
                //Paises[i] Indica los datos que se encontrarán en la posición del arreglo de objetos
                datosArchivo += "\n" + "Nombre: ";
                Paises[i].NombrePais = cmbPais.Text;
                datosArchivo += Paises[i].NombrePais + "\n";

                datosArchivo += "Población: ";
                Paises[i].Poblacion = Poblacion;
                datosArchivo += Paises[i].Poblacion.ToString() + "\n";

                datosArchivo += "Idioma: ";
                Paises[i].Idioma = cmbIdioma.Text;
                datosArchivo += Paises[i].Idioma + "\n";

                //Indica el tamaño que tiene el arreglo colores
                Paises[i].Colores = new string[3];
                //Se indicá la posición del arreglo colores y de donde tomará su valor
                datosArchivo += "Colores de la bandera: " + "\n";
                datosArchivo += "Color 1: " + "\n";
                Paises[i].Colores[0] = txtColor1.Text;
                datosArchivo += Paises[i].Colores[0] + "\n";

                datosArchivo += "Color 2: " + "\n";
                Paises[i].Colores[1] = txtColor2.Text;
                datosArchivo += Paises[i].Colores[1] + "\n";

                datosArchivo += "Color 3: " + "\n";
                Paises[i].Colores[2] = txtColor3.Text;
                datosArchivo += Paises[i].Colores[2] + "\n";

                //Método pata limpiar las cajas de texto
                txtPoblacion.Clear();
                txtColor1.Clear();
                txtColor2.Clear();
                txtColor3.Clear();

                //Mensaje para que el usuario tome en cuenta que el registo de la cantidad de paises se ha realizado de manera correcta y todos han sido registrados
                MessageBox.Show("Los paises han sido guardados correctamente", "Registro Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                //Hacer visibles e invisibles cajas de texto, labes y botones
                this.lblCantidadpaises.Visible = false;
                this.txtPaisesRegistrar.Visible = false;
                this.btnRegistrar.Visible = false;
                this.gbBuscar.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Variable que indica que se buscará
            string nombre;
            //De donde obtendrá el dato la varible, para que este se busque
            nombre = txtPaisBuscar.Text;

            //Condición para que la variable i recorra de un en uno, la cantidad de paises que se registraron 
            for (int i = 0; i < cantidadPaises; i++)
            {
                //Condición que indica si la variable "nombre" se encuentrá entre los paises registrados
                if (Paises[i].NombrePais.Equals(nombre))
                {
                    cmbPais.Text = Paises[i].NombrePais;
                    txtPoblacion.Text = Paises[i].Poblacion.ToString();
                    cmbIdioma.Text = Paises[i].Idioma;
                    txtColor1.Text = Paises[i].Colores[0];
                    txtColor2.Text = Paises[i].Colores[1];
                    txtColor3.Text = Paises[i].Colores[2];
                }
            }
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            archivo = new StreamWriter("archivo.txt");

            //Objeto del Form Imprimir
            ImprimirAr Documento = new ImprimirAr();
            //Se llama al form
            Documento.Show();
            //Dice en que lugares y que valores se imprimiran
            Documento.lblNombrePais.Text = "Nombre del País: " + cmbPais.Text;
            Documento.lblTotalPoblacion.Text = "Total de Población: " + txtPoblacion.Text;
            Documento.lblIdiomaI.Text = "Idioma: " + cmbIdioma.Text;
            Documento.lblPrimerColor.Text = "Primer color: " + txtColor1.Text;
            Documento.lblSegundoColor.Text = "Segundo color: " + txtColor2.Text;
            Documento.lblTercerColor.Text = "Tercer color: " + txtColor3.Text;

            archivo.WriteLine(datosArchivo);
            archivo.Close();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
