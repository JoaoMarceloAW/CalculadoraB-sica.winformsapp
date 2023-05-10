namespace CalculadoraBásica.winformsapp
{
    public partial class Form1 : Form
    {
        Calculadora calculadora;

        public Form1()
        {
            InitializeComponent();

            ConfigurarBotoes();

        }

        private void ConfigurarBotoes()
        {
            botao1.Click += AtribuirNumero;
            botao2.Click += AtribuirNumero;
            botao3.Click += AtribuirNumero;
            botao4.Click += AtribuirNumero;
            botao5.Click += AtribuirNumero;
            botao6.Click += AtribuirNumero;
            botao7.Click += AtribuirNumero;
            botao8.Click += AtribuirNumero;
            botao9.Click += AtribuirNumero;

            btnSomar.Click += RegistrarOperacao;
            btnSubtrair.Click += RegistrarOperacao;
            btnMultiplicar.Click += RegistrarOperacao;
            btnDividir.Click += RegistrarOperacao;

            btnIgual.Click += ExecutarCalculo;
        }
        private void AtribuirNumero(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            txtNumeros.Text += botaoClicado.Text;
        }


        private void RegistrarOperacao(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeros.Text))
                return;

            calculadora.primeiroNumero = Convert.ToDecimal(txtNumeros.Text);

            Button botaoClicado = (Button)sender;

            calculadora.operacao = Convert.ToChar(botaoClicado.Tag);

            txtCalculo.Text = txtNumeros.Text + " " + botaoClicado.Text;

            txtNumeros.Text = "";

        }
       

        private void ExecutarCalculo(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeros.Text))
                return;

            calculadora.segundoNumero = Convert.ToDecimal(txtNumeros.Text);

            try
            {
                txtCalculo.Text = calculadora.Calcular();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Segundo número inválido");
            }

            txtNumeros.Text = "";
        }

        private void Limpar(object? sender, EventArgs e)
        {
            txtCalculo.ResetText();
            txtNumeros.ResetText();

            calculadora.Limpar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}