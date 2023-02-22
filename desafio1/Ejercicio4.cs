using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace desafio1
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Se recibe el valor del TextBox */
            String textValue = textBox1.Text;

            /* Se verifica que el dato no esté vacío */
            if (textValue.Trim() == "")
            {
                MessageBox.Show("Escribe un valor", "ERROR");
                return;
            }

            if(double.TryParse(textValue, out double Value) && Value > 0 && Value <= 12) 
            {
                /* Se crea la varible que contendra el mensaje final */
                String msg;

                switch(Value)
                {
                    case 1:
                        msg = "Usted ha Seleccionado ENERO, El cual tiene 31 Días";
                        break;
                    case 2:
                        msg = "Usted ha Seleccionado FEBRERO, El cual tiene 29 Días";
                        break;
                    case 3:
                        msg = "Usted ha Seleccionado MARZO, El cual tiene 31 Días";
                        break;
                    case 4:
                        msg = "Usted ha Seleccionado ABRIL, El cual tiene 30 Días";
                        break;
                    case 5:
                        msg = "Usted ha Seleccionado MAYO, El cual tiene 31 Días";
                        break;
                    case 6:
                        msg = "Usted ha Seleccionado JUNIO, El cual tiene 30 Días";
                        break;
                    case 7:
                        msg = "Usted ha Seleccionado JULIO, El cual tiene 31 Días";
                        break;
                    case 8:
                        msg = "Usted ha Seleccionado AGOSTO, El cual tiene 31 Días";
                        break;
                    case 9:
                        msg = "Usted ha Seleccionado SEPTIEMBRE, El cual tiene 30 Días";
                        break;
                    case 10:
                        msg = "Usted ha Seleccionado OCTUBRE, El cual tiene 31 Días";
                        break;
                    case 11:
                        msg = "Usted ha Seleccionado NOVIEMBRE, El cual tiene 30 Días";
                        break;
                    case 12:
                        msg = "Usted ha Seleccionado DICIEMBRE, El cual tiene 31 Días";
                        break;
                    default:
                        msg = "El valor a ingresar debe ser un número válido";
                        break;
                }

                /* Se imprime el mensaje final */
                MessageBox.Show(msg, "RESULTADO");
            } else
            {
                textBox1.Text = "";
                MessageBox.Show("El valor a ingresar debe ser un número válido", "ERROR");
            }
        }
    }
}
