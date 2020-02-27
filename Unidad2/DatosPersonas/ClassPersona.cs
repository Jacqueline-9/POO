using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPersonas
{
    class ClassPersona
    {
        //Atributos de la clase
        public string nombre, apPaterno, apMaterno, estadoN, tipo, alumno, maestro, administrativo;
        public int anioA, anioN, diaA, diaN, mesA, mesN, Telefono;

        //Variable de la clase 
        public int contadorMayoresEdad = 0, contadorestadoNay = 0, contadorAlumno = 0, contadorMaestro = 0, contadorAdministrativo = 0;
        public string mayorEdad;


        //OtrasVariables 
        public string nombreM, apPaternoM, apMaternoM;
        
        
        //Metodo de la clase 
        public void RegistrarPersona()
        {
            nombre = nombreM;
            apPaterno = apPaternoM;
            apMaterno = apMaternoM;
        }
        public void MayoresEdad()
        {
            if (anioA - anioN > 18)
            {
                mayorEdad = "Es Mayor de Edad";
                contadorMayoresEdad++;
            }
            else if (anioA - anioN == 18)
            {
                if (mesA > mesN)
                {
                    mayorEdad = "Es Mayor de Edad";
                    contadorMayoresEdad++;
                }
                else if (mesA == mesN)
                {
                    if (diaA >= diaN)
                    {

                        mayorEdad = "Es Mayor de Edad";
                        contadorMayoresEdad++;
                    }
                }
            }

        }
        public void contabilizarEstadoNay()
        {
            if (estadoN == "Nayarit")
            {
                contadorestadoNay++;
            }
        }
        public void ContabilizarTipo()
        {
            switch (tipo)
            {
                case "Alumno":
                    {
                        contadorAlumno++;
                        break;
                    }
                case "Maestro":
                    {
                        contadorMaestro++;
                        break;
                    }
                default:
                    {
                        contadorAdministrativo++;
                        break;
                    }

            }
        }
    }
}

