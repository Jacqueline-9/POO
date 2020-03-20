﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesEjercicio1
{
    class Cerveza : Bebida
    {
        private string alcohol, marca;
        private int cantidad, sobranteFaltante, nuevaCantidad;

        public string Alcohol { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public int SobranteFaltante { set; get; }
        public int NuevaCantidad { get; set; }

        public Cerveza()
        {
            alcohol = "";
            marca = "";
            cantidad = 0;
            SobranteFaltante = 0;
            nuevaCantidad = 0;
        }

        public void Llenar()
        {
             if (cantidad == 100)
             {
                nuevaCantidad = cantidad;
             }

            if (cantidad > 100)
            {
                SobranteFaltante = 100 - cantidad;
                nuevaCantidad = cantidad - SobranteFaltante;
            }   
            else if (cantidad < 100 )
                SobranteFaltante = 100 - cantidad;
                nuevaCantidad = cantidad + SobranteFaltante;
        }

        public string Mostrar()
        {
            return "La cantidad de la Cerveza es: " + this.nuevaCantidad;
        }
    }
}
