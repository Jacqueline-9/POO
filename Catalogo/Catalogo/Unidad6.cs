using BidimensionalEjemplo1;
using DatosAlumnoDocente;
using DatosAlumnosDocentesAr;
using DatosPaisesMundo;
using DatosPaisesN;
using Matriz_FCD;
using MiPrimerArrayListArc;
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

namespace Catalogo
{
    public partial class Unidad6 : Form
    {
        public Unidad6()
        {
            InitializeComponent();
        }

        private void btnBidi1_Click(object sender, EventArgs e)
        {
            string programa;
            string ruta;

            programa = "Bidi1Arc.exe";
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

            programa = "Bidi2Arc.exe";
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
            FormBidiEjemploAr frm = new FormBidiEjemploAr();
            frm.Show();
        }

        private void btnDatosAD_Click(object sender, EventArgs e)
        {
            FormDatosAlumnoDocenteAr frm = new FormDatosAlumnoDocenteAr();
            frm.Show();
        }

        private void btnDastosAsDs_Click(object sender, EventArgs e)
        {
            FormDatosAlumnosDocentesAr frm = new FormDatosAlumnosDocentesAr();
            frm.Show();
        }

        private void btnDatosPaises_Click(object sender, EventArgs e)
        {
            FormDatosNPaisesAr frm = new FormDatosNPaisesAr();
            frm.Show();
        }

        private void btnDPaisMundo_Click(object sender, EventArgs e)
        {
            FormDatosPaisesMundoAr frm = new FormDatosPaisesMundoAr();
            frm.Show();
        }

        private void btnEjemPropuesto_Click(object sender, EventArgs e)
        {
            string programa;
            string ruta;

            programa = "EjemPropuestoArc.exe";
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
            FormMatrizAr frm = new FormMatrizAr();
            frm.Show();
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            FormArrayListArc frm = new FormArrayListArc();
            frm.Show();
        }

        private void btnNumMayMen_Click(object sender, EventArgs e)
        {
            FormNumMayMenAr frm = new FormNumMayMenAr();
            frm.Show();
        }

        private void btnPerritos_Click(object sender, EventArgs e)
        {
            FormPerritosAr frm = new FormPerritosAr();
            frm.Show();
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            FormTorneoAr frm = new FormTorneoAr();
            frm.Show();
        }

        private void btnWFBidi1_Click(object sender, EventArgs e)
        {
            FormWFBidi1Arc frm = new FormWFBidi1Arc();
            frm.Show();
        }
    }
}
