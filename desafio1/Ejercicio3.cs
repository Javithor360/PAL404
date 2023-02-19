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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
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
                switch (grade)
                {
                    case > 10:
                        msg = "La nota que ingresaste no existe en el sistema de notas, inténtalo de nuevo";
                        break;
                    case >= 9:
                        msg = "¡Felicidades! La nota en tu materia es: A.";
                        break;
                    case >= 8:
                        msg = "¡Enhorabuena! La nota en tu materia es: B";
                        break;
                    case >= 7:
                        msg = "¡Nada mal! La nota en tu materia es: C";
                        break;
                    case >= 6:
                        msg = "¡Vamos! La nota en tu materia es: D, demuestra que eres capaz de más.";
                        break;
                    case >= 0:
                        msg = "¡Ups! La nota en tu materia es: F, esfuérzate más a la próxima.";
                        break;
                    default:
                        msg = "La nota que ingresaste no existe en el sistema de notas, inténtalo de nuevo";
                        break;
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
