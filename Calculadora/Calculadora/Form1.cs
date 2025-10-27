using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool pendingOperation = false;

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            // Esta parte agrega el número al TextBox para mostrar el cálculo completo
            tbCalculos.Text += button.Text;
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            tbCalculos.Text += button.Text;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            tbCalculos.Text += button.Text;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            tbCalculos.Text += button.Text;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            tbCalculos.Text += button.Text;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            tbCalculos.Text += button.Text;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            tbCalculos.Text += button.Text;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            tbCalculos.Text += button.Text;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            tbCalculos.Text += button.Text;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            tbCalculos.Text += button.Text;
        }

        private void Evaluar()
        {
            if (pendingOperation)
            {
                double segundoNumero = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += segundoNumero;                        
                        break;
                    case "-":
                        result -= segundoNumero;
                        break;
                    case "x":
                        result *= segundoNumero;
                        break;
                    case "÷":
                        if (segundoNumero != 0)
                            result /= segundoNumero;
                        else
                            tbCalculos.Text = "Error: División por cero";
                        break;
                }

                tbCalculos.Text = result.ToString();
                pendingOperation = false;
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (pendingOperation)
            {
                Evaluar();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            pendingOperation = true;

            // Esta parte agrega el símbolo de la operación al TextBox
            tbCalculos.Text += button.Text;
            // Reinicia la entrada actual para el siguiente número ingresado
            currentInput = "";

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (pendingOperation)
            {
                Evaluar();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            pendingOperation = true;

            tbCalculos.Text += button.Text;
            currentInput = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (pendingOperation)
            {
                Evaluar();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            pendingOperation = true;

            tbCalculos.Text += button.Text;
            currentInput = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (pendingOperation)
            {
                Evaluar();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            pendingOperation = true;

            tbCalculos.Text += button.Text;
            currentInput = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Evaluar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            pendingOperation = false;
            tbCalculos.Text = "";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            tbCalculos.Text += button.Text;
        }
    }
}
