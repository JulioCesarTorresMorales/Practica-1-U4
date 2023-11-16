namespace Practica_1_U4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int _numero1;
        private int _numero2;

        public int Numero1 { get => _numero1; set => _numero1 = value; }
        public int Numero2 { get => _numero2; set => _numero2 = value; }

        private void button4_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int numero1;
            int numero2;
            Double resultado;
            //Leer los datos
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            //Llamar a la funcion operaciones
            resultado = operaciones(numero1, numero2, "d");
            //Mostrar la informacion
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();

        }

        private int sumar(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;
            return resultado;

        }
        private Double operaciones(int num1, int num2, string op)
        {
            Double resultado;
            if (op == "s")
            {
                resultado = num1 + num2;
            }
            else if (op == "r")
            {
                resultado = num1 - num2;
            }
            else if (op == "m")
            {
                resultado = num1 * num2;
            }
            else
            {
                resultado = num1 / num2;
            }
            return resultado;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            //Entrada de datos
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);
            //Declarar la variable suma
            int suma;
            suma = sumar(numero1, numero2);
            txtResultado.Text = Convert.ToString(suma);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int numero1;
            int numero2;
            Double resultado;
            //Leer los datos
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            //Llamar a la funcion operaciones
            resultado = operaciones(numero1, numero2, "r");
            //Mostrar la informacion
            txtResultado.Text = Convert.ToString(resultado);

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int numero1;
            int numero2;
            Double resultado;
            //Leer los datos
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);

            //Llamar a la funcion operaciones
            resultado = operaciones(numero1, numero2, "m");
            //Mostrar la informacion
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Numero1 = 10;
            Numero2 = 30;
            int suma;
            suma = Numero1 + Numero2;
            txtResultado.Text = Convert.ToString(suma);

        }
    }
}