namespace Calculadora
{
    public partial class frmcalculadora : Form

    {
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            somar,
            Subtracao,
            Multiplicacao,
            Divisao

        }

        public frmcalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btsomar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.somar;
        }

        private void btsubtracao_Click(object sender, EventArgs e)
        {

            OperacaoSelecionada = Operacao.Subtracao;
        }
        private void btdiv_Click(object sender, EventArgs e)
        {

            OperacaoSelecionada = Operacao.Divisao;
        }

        private void btmult_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resultado.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resultado.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resultado.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resultado.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Resultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Resultado.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resultado.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Resultado.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Resultado.Text += "0";
        }
    }
}
