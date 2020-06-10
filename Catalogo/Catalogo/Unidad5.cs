using BidimensionalEjemplo1;
using DatosAlumnosDocentes;
using DatosNPaises;
using DatosPaisMundo;
using Matriz_FCD;
using MiPrimerArrayList;
using NumMayMen;
using Perritos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Torneo;
using WFBidimensional1;
using WFBidimensional2;

namespace Catalogo
{
    public partial class Unidad5 : Form
    {
        public Unidad5()
        {
            InitializeComponent();
        }

        private void btnBidi1_Click(object sender, EventArgs e)
        {
            string programa;
            string ruta;

            programa = "Bidimensional1.exe";
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

        private void btnBidi2_Click(object sender, EventArgs e)
        {
            string programa;
            string ruta;

            programa = "Bidimensional2.exe";
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

        private void btnBidiEjem_Click(object sender, EventArgs e)
        {
            FormBidimensionalEjemplo1 frm = new FormBidimensionalEjemplo1();
            frm.Show();
        }

        private void btnDatosAD_Click(object sender, EventArgs e)
        {
            FormDatosAlumnoDocnte frm = new FormDatosAlumnoDocnte();
            frm.Show();
        }

        private void btnDastosAsDs_Click(object sender, EventArgs e)
        {
            FormDatosAlumnosDocentes frm = new FormDatosAlumnosDocentes();
            frm.Show();
        }

        private void btnDatosPaises_Click(object sender, EventArgs e)
        {
            FormDatosNPaises frm = new FormDatosNPaises();
            frm.Show();
        }

        private void btnDPaisMundo_Click(object sender, EventArgs e)
        {
            FormDatosPaisesMundo frm = new FormDatosPaisesMundo();
            frm.Show();
        }

        private void btnEjemPropuesto_Click(object sender, EventArgs e)
        {
            string programa;
            string ruta;

            programa = "Ejemplo1Propuesto.exe";
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

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            FormMatriz frm = new FormMatriz();
            frm.Show();
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            FormMiPrimerArrayList frm = new FormMiPrimerArrayList();
            frm.Show();
        }

        private void btnNumMayMen_Click(object sender, EventArgs e)
        {
            FormNumMayMen frm = new FormNumMayMen();
            frm.Show();
        }

        private void btnPerritos_Click(object sender, EventArgs e)
        {
            FormPerritos frm = new FormPerritos();
            frm.Show();
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            FormTorneo frm = new FormTorneo();
            frm.Show();
        }

        private void btnWFBidi1_Click(object sender, EventArgs e)
        {
            FormWFBidi1 frm = new FormWFBidi1();
            frm.Show();
        }

        private void btnWFBidi2_Click(object sender, EventArgs e)
        {
            FormWFBidi2 frm = new FormWFBidi2();
            frm.Show();
        }
    }
}
