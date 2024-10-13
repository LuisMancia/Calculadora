using System;
using System.Windows.Forms;

namespace RetoCalculadora
{
    public partial class Calculadora : Form
    {
        double numero1, numero2, solucion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {
            resultado.Enabled = false;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            CalcularResta();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            CalcularMultiplicacion();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            CalcularDivision();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            CalcularSuma();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            CalcularRaiz();
        }

        private void reiniciar_Click(object sender, EventArgs e)
        {
            primerNumero.Clear();
            segundoNumero.Clear();
            segundoNumero.Enabled = true;
            resultado.Clear();
        }

        private void primerNumero_TextChanged(object sender, EventArgs e)
        {
            ValidarEntrada(primerNumero.Text, out numero1);
        }

        private void segundoNumero_TextChanged(object sender, EventArgs e)
        {
            ValidarEntrada(segundoNumero.Text, out numero2);
        }

        private void CalcularResta()
        {
            solucion = numero1 - numero2;
            resultado.Text = Convert.ToString(solucion);
        }

        private void CalcularMultiplicacion()
        {
            solucion = numero1 * numero2;
            resultado.Text = Convert.ToString(solucion);
        }

        private void CalcularDivision()
        {
            if (numero2 == 0)
            {
                resultado.Text = "Syntax Error";
            }
            else
            {
                solucion = numero1 / numero2;
                resultado.Text = Convert.ToString(solucion);
            }
        }

        private void CalcularSuma()
        {
            solucion = numero1 + numero2;
            resultado.Text = Convert.ToString(solucion);
        }

        private void CalcularRaiz()
        {
            //se inhabilita el segundo campo al momento de hacer raiz cuadrada,
            //es decir, solamente se considera el numero en el primer campo
            solucion = Math.Sqrt(numero1);
            segundoNumero.Enabled = false;
            resultado.Text = Convert.ToString(solucion);
        }

        private void ValidarEntrada(string texto, out double numero)
        {
            //Si el numero No se convierte a double de manera exitosa entonces da error
            if (!double.TryParse(texto, out numero))
            {
                resultado.Text = "Syntax Error";
            }
        }
    }
}
