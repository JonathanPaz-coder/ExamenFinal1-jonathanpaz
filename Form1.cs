using System;
using System.Windows.Forms;

namespace ExamenFinal1_jonathanpaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer los valores de los TextBox
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            // Validar si los valores de los números son válidos
            if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
            {



                // Comparar los dos números
                if (num1 > num2)
                {
                    MessageBox.Show($"El número {num1} es mayor que {num2}");
                }
                else if (num1 < num2)
                {
                    MessageBox.Show($"El número {num2} es mayor que {num1}");
                }
                else
                {
                    MessageBox.Show($"Ambos números, {num1} y {num2}, son iguales");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese números válidos en ambos campos.");
            }
           
        }
    }
}