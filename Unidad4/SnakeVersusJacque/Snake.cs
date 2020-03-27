using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeVersusJacque
{
    public partial class Snake : Form
    {
        Graphics g;
        Serpiente cabeza;
        Comida comidita;
        int xdirec = 0, ydirec = 0, puntaje = 0, cuadro = 10;
        Boolean ejex = true, ejey = true;
        
        public Snake()
        {
            InitializeComponent();
            cabeza = new Serpiente(10, 10);
            comidita = new Comida();
            g = canvas.CreateGraphics();  
        }

        public void movimiento()
        {
            cabeza.setxy(cabeza.VerX() + xdirec, cabeza.VerY() + ydirec);
        }

        private void Bucle_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            cabeza.Dibujar(g);
            comidita.Dibujar(g);
            movimiento();
            ChoqueCuerpo();

            if (cabeza.Interseccion(comidita))
            {
                comidita.NuevaPosicion();
                cabeza.Siguiente();
                puntaje++;
                lblPuntosAcumulados.Text = puntaje.ToString();
            }
        }

        public void GameOver()
        {
            puntaje = 0;
            lblPuntosAcumulados.Text = "0";
            ejex = true;
            ejey = true;
            xdirec = 0;
            ydirec = 0;
            cabeza = new Serpiente(10, 10);
            comidita = new Comida();
            MessageBox.Show("El juego ha Terminado :c", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
       
        public void ChoqueCuerpo()
        {
            Serpiente choque;
            try
            {
                choque = cabeza.VerSiguiente().VerSiguiente();
            }
            catch (Exception colita)
            {
                choque = null;
            }

            while(choque != null)
            {
                if (cabeza.Interseccion(choque))
                {
                    GameOver();
                }
                else
                {
                    choque = choque.VerSiguiente();
                }
            }
        }
        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            if(ejex)
            {
                if (e.KeyCode == Keys.Up)
                {
                    ydirec = -cuadro;
                    xdirec = 0;
                    ejex = false;
                    ejey = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    ydirec = cuadro;
                    xdirec = 0;
                    ejex = false;
                    ejey = true;
                }
            }
            if (ejey)
            {
                if (e.KeyCode == Keys.Right)
                {
                    ydirec = 0;
                    xdirec = cuadro;
                    ejex = true;
                    ejey = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    ydirec = 0;
                    xdirec = -cuadro;
                    ejex = true;
                    ejey = false;
                }
            }
        }
    }
}
