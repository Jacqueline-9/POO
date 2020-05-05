using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
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
                for (int p = 0; p < SumaPuntaje.Length; p++)
                {
                    for (int c = 1; c < PuntajePartidos.GetLength(1); c++)
                    {
                        SumaPuntaje[p] = Convert.ToInt16(PuntajePartidos[f, c]);
                    }
                }
            }
        }

        public string EquipoGanador()
        {
            int PunMayor=0;
            string equipoGanador = "";
            int indGanador = 0;

            for ( int i = 0; i < SumaPuntaje.Length; i++)
            {
               if (SumaPuntaje[i] > PunMayor)
               {
                    PunMayor = SumaPuntaje[i];

               }    
            }
            equipoGanador = "El equipo ganador es: " + PuntajePartidos[indGanador,0] + "\n" +"Punto(s) obtenido(s): " + PunMayor;
            return equipoGanador;
        }
    }
}
