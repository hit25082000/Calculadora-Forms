namespace Calculadora
{
    public partial class Form1 : Form
    {
        Calculadora calculadora = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button0.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            textBox1.Text += buttonV.Text;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            calculadora.AdicionarNumero(double.Parse(textBox1.Text));
            calculadora.AdicionarOperacao("-");
            textBox2.Text += textBox1.Text + " - ";
            textBox1.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            calculadora.AdicionarNumero(double.Parse(textBox1.Text));
            calculadora.AdicionarOperacao("+");
            textBox2.Text += textBox1.Text + " + ";
            textBox1.Text = "";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            calculadora.AdicionarNumero(double.Parse(textBox1.Text));
            calculadora.AdicionarOperacao("*");
            textBox2.Text += textBox1.Text + " * ";
            textBox1.Text = "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            calculadora.AdicionarNumero(double.Parse(textBox1.Text));
            calculadora.AdicionarOperacao("/");
            textBox2.Text += textBox1.Text + " / ";
            textBox1.Text = "";
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            calculadora = new Calculadora();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            calculadora.AdicionarNumero(double.Parse(textBox1.Text));
            string resultado = calculadora.CalcularResultado();
            textBox2.Text = resultado.ToString() + " | ";
            textBox1.Text = "";
            calculadora = new Calculadora();
        }
    }
}