using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        string conexion = "Server=.\\SQLEXPRESS;Database=CalculadoraDB;Integrated Security=True;";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            CargarHistorial();  
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
            
            GuardarEnBD(operacion, resultado);

            
            string lineaHistorial = $"{operacion} = {resultado}\r\n";
            int posicionInsertar = tbHistorial.Text.IndexOf("\r\n\r\n") + 4;
            tbHistorial.Text = tbHistorial.Text.Insert(posicionInsertar, lineaHistorial);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            tbHistorial.Visible = !tbHistorial.Visible;
        }
        private void GuardarEnBD(string operacion, double resultado)
        {
            
            SqlConnection conn = new SqlConnection(conexion);

            
            conn.Open();

            
            string sql = "INSERT INTO Historial (Operacion, Resultado) VALUES (@op, @res)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            
            cmd.Parameters.AddWithValue("@op", operacion);
            cmd.Parameters.AddWithValue("@res", resultado);

            
            cmd.ExecuteNonQuery();

            
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCalculos.Text = "0";
        }

        private void CargarHistorial()
        {
            
            tbHistorial.Text = " Historial de operaciones \r\n\r\n";

            
            SqlConnection conn = new SqlConnection(conexion);
            conn.Open();

           
            string sql = "SELECT Operacion, Resultado FROM Historial ORDER BY Id DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader lector = cmd.ExecuteReader();

           
            while (lector.Read())
            {
                string op = lector["Operacion"].ToString();
                string res = lector["Resultado"].ToString();
                tbHistorial.Text += $"{op} = {res}\r\n";
            }

            
            lector.Close();
            conn.Close();
        }
    }
}