using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegodePreguntas
{
    public partial class Preguntas : Form
    {
        double resultadoFinal = 0; //Variable para decir el resultado final

        public Preguntas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //Salir del programa 
        }

        private void btnEvaluar_Click(object sender, EventArgs e) //Boton para evaluar la primer pregunta
        {
            Pregunta1 ObjPregunta1 = new Pregunta1(); //Creador de objeto de la primer pregunta
           
            if (this.rdbNo.Checked == true)
            {
                MessageBox.Show(ObjPregunta1.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else if (this.rdbSi.Checked == true)
            {
                MessageBox.Show(ObjPregunta1.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }  
        }

        private void btnEvaluar2_Click(object sender, EventArgs e) //Boton para evaluar la pregunta dos
        {
            Pregunta2 ObjPregunta2 = new Pregunta2(); //Creador de objeto de la pregunta dos

            if (this.rdbNaranja.Checked == true)
            {
                MessageBox.Show(ObjPregunta2.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta2.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
           
        }

        private void btnEvaluar3_Click(object sender, EventArgs e) //Boton para evaluar la pregunta tres
        {
            Pregunta3 ObjPregunta3 = new Pregunta3(); //Creador de objeto de la pregunta tres

            if (this.rdbNinguna.Checked == true)
            {
                MessageBox.Show(ObjPregunta3.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta3.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }          
        }

        private void btnEvaluar4_Click(object sender, EventArgs e) //Boton para evaluar la pregunta cuatro
        {
            Pregunta4 ObjPregunta4 = new Pregunta4(); //Creador de objeto de la pregunta cuatro

            if (this.rdbOtroLugar.Checked == true)
            {
                MessageBox.Show(ObjPregunta4.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta4.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEvaluar5_Click(object sender, EventArgs e) //Boton para evaluar la pregunta cinco
        {
            Pregunta5 ObjPregunta5 = new Pregunta5(); //Creador de objeto de la pregunta cinco

            if (this.rdb116.Checked == true)
            {
                MessageBox.Show(ObjPregunta5.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta5.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        private void btnEvaluar6_Click(object sender, EventArgs e) //Boton para evaluar la pregunta seis
        {
            Pregunta6 ObjPregunta6 = new Pregunta6(); //Creador de objeto de la pregunta seis

            if (this.rdbGris.Checked == true)
            {
                MessageBox.Show(ObjPregunta6.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta6.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn7_Click_1(object sender, EventArgs e) //Boton para evaluar la pregunta siete
        {
            Pregunta7 ObjPregunta7 = new Pregunta7(); //Creador de objeto de la pregunta siete

            if (this.rdb720.Checked == true)
            {
                MessageBox.Show(ObjPregunta7.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta7.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn8_Click_1(object sender, EventArgs e) //Boton para evaluar la pregunta ocho
        {
            Pregunta8 ObjPregunta8 = new Pregunta8(); //Creador de objeto de la pregunta cocho

            if (this.rdb85.Checked == true)
            {
                MessageBox.Show(ObjPregunta8.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta8.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn9_Click_1(object sender, EventArgs e) //Boton para evaluar la pregunta nueve
        {
            Pregunta9 ObjPregunta9 = new Pregunta9(); //Creador de objeto de la pregunta nueve

            if (this.rdb996.Checked == true)
            {
                MessageBox.Show(ObjPregunta9.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta9.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn10_Click_1(object sender, EventArgs e) //Boton para evaluar la pregunta diez
        {
            Pregunta10 ObjPregunta10 = new Pregunta10(); //Creador de objeto de la pregunta diez

            if (this.rdb10Ninguno.Checked == true)
            {
                MessageBox.Show(ObjPregunta10.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta10.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn11_Click_1(object sender, EventArgs e) //Boton para evaluar la pregunta once
        {
            Pregunta11 ObjPregunta11 = new Pregunta11(); //Creador de objeto de la pregunta once

            if (this.rdb113.Checked == true)
            {
                MessageBox.Show(ObjPregunta11.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta11.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btn12_Click_1(object sender, EventArgs e) //Boton para evaluar la pregunta doce
        {
            Pregunta12 ObjPregunta12 = new Pregunta12(); //Creador de objeto de la pregunta doce

            if (this.rdb121.Checked == true)
            {
                MessageBox.Show(ObjPregunta12.ResultadoCorrecto(), "Respuesta Correcta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                resultadoFinal = resultadoFinal + 8.33333333333333;
            } //If para mandar un mensajebox dependiendo si la pregunta es correcta o incorrecta, en caso de que se corecta también le sumara 8.33333333333333
            else
            {
                MessageBox.Show(ObjPregunta12.ResultadoIncorrecto(), "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnResultado_Click(object sender, EventArgs e) //Boton para obtener el resultado final
        {
            if (resultadoFinal >= 80)
            {
                MessageBox.Show("¡Excelente! Tus resultados son de : " + resultadoFinal);
            } //if que si el resultafoFinal es mayor o igual a 80 mandara un mensaje de excelente y el resultado de las sumas que se fueron acumulando
            else if (resultadoFinal <= 79 & resultadoFinal >= 50)
            {
                MessageBox.Show("¡Muy Bien! Estudia un poco más, tus resultados son de: " + resultadoFinal);
            } //else if que si el resultado final es menos o igual a 79 pero mayor o igual que 50, se mandara un mensaje diciendo muy bien y la suma acumulada 
            else
            {
                MessageBox.Show("¡Bien Hecho! Sigue estudiando, tus resultados son de: " + resultadoFinal);
            } // un elsede que en caso que sea menos que 50, se envie un mensaje diciendo bien pero que siga estudiando y el resultado de las sumas acumuladas 

            resultadoFinal = 0; //El resultado final obtiene el valor 0, pra que este listo a contar de nuevo 
        }

    }
}
