using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehículos
{
    class Vehiculos
    {
        //Atributos de la clase 
        public string tipoCombustible, color;
        public int numeroLlantas, numeroPuertas, numeroVentanas;

        //Constructor de la clase, es un metodo que se llama igual que la clase y  
        //se ejecuta automaticamente al crear el objeto
        public Vehiculos()
        {
            tipoCombustible = "";
            color = "Blanco";
            numeroLlantas = 1;
            numeroPuertas = 0;
            numeroVentanas = 0;
        }

        //Métodos de la clase 
        public string ArrancarMotor(string arrancarMotor)
        {
            return "Se arrancó el motor " + arrancarMotor;
        }
        public string PararMotor(string pararMotor)
        {
            return "Se paro el motor " + pararMotor;
        }
    }
}
