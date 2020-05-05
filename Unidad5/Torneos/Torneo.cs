using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneos
{
    class Torneo
    {
        public string Nombre { set; get; }
        public int NumEquipos { set; get; }
        public int NumPartidos { set; get; }
        public DateTime FechaIn { set; get; }
        public DateTime FechaTer { set; get; }
        public int PunGanados { set; get; }
        public int PunEmpatados { set; get; }
        public int PunPerdidos { set; get; }
        public string [,] PuntajePartidos { set; get; }
        public int[] SumaPuntaje { set; get; }

        public void SumaPuntos()
        {
            int p = 0;
            int suma = 0;
            int pAcumulados = 0;

            for ( int f = 0; f < PuntajePartidos.GetLength(0); f++)
            {              
                for (int c = 1; c < PuntajePartidos.GetLength(1); c++)
                {
                    suma = Convert.ToInt32(PuntajePartidos[f, c]);
                    pAcumulados += suma;
                }
                SumaPuntaje[p] = pAcumulados;
                p++;
            }
        }

        public string EquipoGanador()
        {
            int puntajeMayor = 0;
            string equipoGanador = "";
            int indGanador = 0;
            int f = 0;
            for (int i = 0; i < SumaPuntaje.Length; i++ )
            {
                if (SumaPuntaje[i] > puntajeMayor)
                {
                    puntajeMayor = SumaPuntaje[i];
                    indGanador = f;     
                }
                f++;
            }
            equipoGanador = "El equipo ganador es: " + PuntajePartidos[indGanador, 0] + "\n" + "Punto(s) obtenido(s):" + puntajeMayor;
            return equipoGanador;
        }
    }
}
