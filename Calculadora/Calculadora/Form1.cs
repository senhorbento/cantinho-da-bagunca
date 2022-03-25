namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Somar_Click(object sender, EventArgs e)
        {
            LbResultado.Text = "Resultado: " + operacoes.Somar(int.Parse(BxFirstValue.Text), int.Parse(BxSecondValue.Text)).ToString();
        }

        private void BtSubtrair_Click(object sender, EventArgs e)
        {
            LbResultado.Text = "Resultado: " + operacoes.Subtrair(int.Parse(BxFirstValue.Text), int.Parse(BxSecondValue.Text)).ToString();
        }

        private void BtDividir_Click(object sender, EventArgs e)
        {
            LbResultado.Text = "Resultado: " + operacoes.Dividir(int.Parse(BxFirstValue.Text), int.Parse(BxSecondValue.Text)).ToString();
        }

        private void BtMultiplicar_Click(object sender, EventArgs e)
        {
            LbResultado.Text = "Resultado: " + operacoes.Multiplicar(int.Parse(BxFirstValue.Text), int.Parse(BxSecondValue.Text)).ToString();
        }
    }
}