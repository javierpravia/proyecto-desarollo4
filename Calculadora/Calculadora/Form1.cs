using System;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            tbHistorial.Text = " Historial de operaciones \r\n\r\n";
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (tbCalculos.Text == "0")
                tbCalculos.Text = "";
            tbCalculos.Text += boton.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(tbCalculos.Text);
            double resultado = 0;
            string operacionTxt = "";

            if (Operador == '+')
            {
                operacionTxt = $"{Numero1} + {Numero2}";
                resultado = Numero1 + Numero2;
                tbCalculos.Text = resultado.ToString();
                Numero1 = resultado;

            }
            else if (Operador == '-')
            {
                operacionTxt = $"{Numero1} - {Numero2}";
                resultado = Numero1 - Numero2;
                tbCalculos.Text = resultado.ToString();
                Numero1 = resultado;
            }
            else if (Operador == 'X')
            {
                operacionTxt = $"{Numero1} * {Numero2}";
                resultado = Numero1 * Numero2;
                tbCalculos.Text = resultado.ToString();
                Numero1 = resultado;
            }
            else if (Operador == '/')
            {
                if (tbCalculos.Text != "0")
                {
                    operacionTxt = $"{Numero1} / {Numero2}";
                    resultado = Numero1 / Numero2;
                    tbCalculos.Text = resultado.ToString();
                    Numero1 = resultado;
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!!");
                }
            }

            if (operacionTxt != "")
            {
                GuardarEnHistorial(operacionTxt, resultado);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            tbCalculos.Text = "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!tbCalculos.Text.Contains("."))
            {
                tbCalculos.Text += ".";
            }
        }

        private void btnSimbolo_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(tbCalculos.Text);
            Numero1 *= -1;
            tbCalculos.Text = Numero1.ToString();
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            Numero1 = Convert.ToDouble(tbCalculos.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                double resultado = Math.Pow(Numero1, 2);
                tbCalculos.Text = resultado.ToString();

                GuardarEnHistorial($"{Numero1}²", resultado);

                Numero1 = resultado;
            }
            else if (Operador == '√')
            {
                if (Numero1 >= 0)
                {
                    double resultado = Math.Sqrt(Numero1);
                    tbCalculos.Text = resultado.ToString();

                    GuardarEnHistorial($"√{Numero1}", resultado);

                    Numero1 = resultado;
                }
                else
                {
                    MessageBox.Show("No se puede calcular la raíz de un número negativo!");
                }
            }
            else
            {
                tbCalculos.Text = "0";
            }
        }

        private void GuardarEnHistorial(string operacion, double resultado)
        {
            string lineaHistorial = $"{operacion} = {resultado}\r\n";

            int posicionInsertar = tbHistorial.Text.IndexOf("\r\n\r\n") + 4;
            tbHistorial.Text = tbHistorial.Text.Insert(posicionInsertar, lineaHistorial);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            tbHistorial.Visible = !tbHistorial.Visible;
        }
    }
}