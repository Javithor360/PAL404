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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Se recibe el valor del TextBox */
            String textValue = TextBox1.Text;

            if (textValue.Trim() == "")
            {
                MessageBox.Show("Escribe su nota...", "ERROR");
                return;
            }

            if (double.TryParse(textValue, out double grade) && grade >= 0 && grade <= 10)
            {
                /* Se crea la varible que contendra el mensaje final */
                String msg;

                /* Se hacen las validaciones respectivas */
                if (grade >= 6)
                {
                    msg = "¡Felicidades! Usted ha aprobado PAL con: " + grade;
                }
                else if (grade < 6)
                {
                    msg = "¡Lo Lamentamos! Usted ha reprobado PAL con: " + grade;
                }
                else
                {
                    msg = "La nota que ingresaste no es valida, inténtalo de nuevo";
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
