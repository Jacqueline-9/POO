using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    class TorneoAr
    {
        public string Nombre { set; get; }
        public int NumEquipos { set; get; }
        public int NumPartidos { set; get; }
        public DateTime FechaIn { set; get; }
        public DateTime FechaTer { set; get; }
        public int PunGanados { set; get; }
        public int PunEmpatados { set; get; }
        public int PunPerdidos { set; get; }
        public string[,] PuntajePartidos { set; get; }
        public int[] SumaPuntaje { set; get; }

        public int Resta()
        {
            NumPartidos = NumEquipos - 1;
            return NumPartidos;
        }

        public void SumaPuntos()
        {
            for (int f = 0; f < PuntajePartidos.GetLength(0); f++)
            {
                int suma = 0;

                for (int c = 1; c < PuntajePartidos.GetLength(1); c++)
                {
                    suma += Convert.ToInt32(PuntajePartidos[f, c]);

                }
                SumaPuntaje[f] = suma;
            }
        }

        public string Ganador()
        {
            int puntajeMayor = 0;
            string ganador = "";
            int f = 0;

            for (int c = 0; c < NumPartidos; c++)
            {
                if (SumaPuntaje[c] > puntajeMayor)
                {
                    PunGanados = SumaPuntaje[c];
                }
                else if (SumaPuntaje[c] == puntajeMayor)
                {
                    PunEmpatados = SumaPuntaje[c];
                }
                else
                {
                    PunPerdidos = SumaPuntaje[c];
                }
                f++;
            }
            ganador = "El equipo ganador es: " + PuntajePartidos[f, 0] + "\n" + "Punto(s) obtenido(s): " + PunGanados;
            return ganador;

        }
    }
}
