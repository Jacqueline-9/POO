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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
        }
        private void personalizardiseno()
        {
            //codigo de diseño
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = panelChild.Controls.OfType<T>().FirstOrDefault();
            if (formulario != null)
            {
                //Si la instancia o esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = new T();
            formulario.TopLevel = false;
            panelChild.Controls.Add(formulario);
            panelChild.Tag = formulario;
            formulario.Show();
        }

        private void btnUnidad1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Unidad1>();
        }

        private void btnUnidad2_3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Unidad2>();
        }

        private void btnUnidad4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Unidad4>();
        }

        private void btnUnidad5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Unidad5>();
        }

        private void btnUnidad6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Unidad6>();
        }
    }
}
