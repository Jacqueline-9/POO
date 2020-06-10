using MiPrimerProyectoWindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class Unidad1 : Form
    {
        public Unidad1()
        {
            InitializeComponent();
        }

        private void btnConsola_Click(object sender, EventArgs e)
        {
            string programa;
            string ruta;

            programa = "MiPrimerProyectoConsola.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", programa, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = string.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo pSI = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = pSI;
            p.Start();
        }

        private void btnForm_Click_1(object sender, EventArgs e)
        {
            FormMiPrimerProyecto frm = new FormMiPrimerProyecto();
            frm.Show();
        }
    }
}
