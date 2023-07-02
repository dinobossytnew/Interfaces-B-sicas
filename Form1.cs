using System;
using System.Windows.Forms;

namespace CalculadoraApp
{
    public partial class Form1 : Form
    {
        private Calculadora calculadora;

        public Form1()
        {
            InitializeComponent();
            calculadora = new Calculadora();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            RealizarOperacion(calculadora.Sumar);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            RealizarOperacion(calculadora.Restar);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            RealizarOperacion(calculadora.Dividir);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            RealizarOperacion(calculadora.Multiplicar);
        }

        private void RealizarOperacion(Func<int, int, int> operacion)
        {
            int numero1, numero2;
            if (int.TryParse(txtNumero1.Text, out numero1) && int.TryParse(txtNumero2.Text, out numero2))
            {
                int resultado = operacion(numero1, numero2);
                lblResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, introduce números válidos.");
            }
        }
    }
}
