namespace Calculadora
{
    public partial class frmcalculadora : Form
    {
        public frmcalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btsomar_Click(object sender, EventArgs e)
        {
            label4.Text = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text)).ToString();
        }

        private void btsubtracao_Click(object sender, EventArgs e)
        {
            label4.Text = (float.Parse(textBox1.Text) - float.Parse(textBox2.Text)).ToString();
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            label4.Text = (float.Parse(textBox1.Text) / float.Parse(textBox2.Text)).ToString();
        }

        private void btmult_Click(object sender, EventArgs e)
        {
            label4.Text = (float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }
    }
}
