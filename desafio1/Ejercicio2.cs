using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio1
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void TextBox_Validating (object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Se recibe el valor del TextBox */
            String textValue = TextBox1.Text;

            /* Se verifica que el dato no esté vacío */
            if (textValue.Trim() == "")
            {
                MessageBox.Show("Escribe un valor", "ERROR");
                return;
            }

            /* Se verifica que sea un número */
            if (double.TryParse(textValue, out double grade))
            {
                /* Se crea la varible que contendra el mensaje final */
                String msg;

                /* Se hacen las validaciones respectivas */
                if (grade >= 9 && grade <= 10)
                {
                    msg = "¡Felicidades! La nota en tu materia es: A.";
                }
                else if (grade >= 8 && grade < 9)
                {
                    msg = "¡Enhorabuena! La nota en tu materia es: B";
                }
                else if (grade >= 7 && grade < 8)
                {
                    msg = "¡Nada mal! La nota en tu materia es: C";
                }
                else if (grade >= 6 && grade < 7)
                {
                    msg = "¡Vamos! La nota en tu materia es: D, demuestra que eres capaz de más.";
                }
                else if (grade >= 0 && grade < 6)
                {
                    msg = "¡Ups! La nota en tu materia es: F, esfuérzate más a la próxima.";
                }
                else
                {
                    msg = "La nota que ingresaste no existe en el sistema de notas, inténtalo de nuevo";
                }

                /* Se imprime el mensaje final */
                MessageBox.Show(msg, "RESULTADO");
            }
            else
            {
                /* En caso de que el valor ingresado no sea un número, se le pide ingresarlo de nuevo */
                TextBox1.Text = "";
                MessageBox.Show("El valor a ingresar debe ser un número válido", "ERROR");
            }
        }
    }
}
