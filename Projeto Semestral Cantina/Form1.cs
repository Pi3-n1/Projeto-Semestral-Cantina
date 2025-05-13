using System.Windows.Forms;

namespace Projeto_Semestral_Cantina
{
    public partial class FormCaixa : Form
    {
        public FormCaixa()
        {
            InitializeComponent();

            List<string> ItensCantina = new List<string>();
            ItensCantina.Add("coxinha");
            ItensCantina.Add("frango");
            ItensCantina.Add("empanado");
            lbItens.DataSource = ItensCantina;
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

        private void btnStatusPedidos_Click(object sender, EventArgs e)
        {
            FormVisualizarStatus formVisualizarStatus = new FormVisualizarStatus();
            formVisualizarStatus.ShowDialog();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lbItens.SelectedItem != null)
            {
                lbCarrinhoCliente.Items.Add(lbItens.SelectedItem);
            }
        }
    }
}
