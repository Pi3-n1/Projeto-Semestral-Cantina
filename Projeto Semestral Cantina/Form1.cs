namespace Projeto_Semestral_Cantina
{
    public partial class FormCaixa : Form
    {
        public FormCaixa()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPagamentoPedido_Click(object sender, EventArgs e)
        {
            FormPagamento formPagamento = new FormPagamento();
            formPagamento.ShowDialog();
        }
    }
}
