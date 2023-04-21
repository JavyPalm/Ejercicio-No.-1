using System;
using System.Windows.Forms;

namespace Tarea_1_lenguaje_3
{
    public partial class Form1 : Form

    {
        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(textBox1.Text);

            int result = numero / 2;

            if (result == 0)
            {
                textBox2.Text = "El numero ingresado es par y positivo";
            }

            else
            {
                textBox2.Text = "El numero ingresado es impar y positivo";
            }

            if (result > 0)
            {
                textBox2.Text = "El numero ingresado es positivo";

            }
            else
            {
                textBox2.Text = "El numero ingresado es negativo";
            }
        }
    }

}

