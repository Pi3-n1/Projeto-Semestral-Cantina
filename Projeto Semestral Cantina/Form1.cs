using System.Windows.Forms;

namespace Projeto_Semestral_Cantina
{
    public partial class FormCaixa : Form
    {

        List<Produto> produtosDisponiveis = new List<Produto>();
        List<Produto> carrinho = new List<Produto>();
        decimal totalPedido = 0;

        public FormCaixa()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InicializarProdutos()
        {
            produtosDisponiveis.Add(new Produto("Pão de Queijo", 3.50m));
            produtosDisponiveis.Add(new Produto("Coxinha", 5.00m));
            produtosDisponiveis.Add(new Produto("Pastel de Carne", 6.00m));
            produtosDisponiveis.Add(new Produto("Pastel de Queijo", 5.50m));
            produtosDisponiveis.Add(new Produto("Suco Natural (300ml)", 4.00m));
            produtosDisponiveis.Add(new Produto("Refrigerante Lata", 4.50m));
            produtosDisponiveis.Add(new Produto("Hambúrguer Simples", 8.00m));
            produtosDisponiveis.Add(new Produto("Hambúrguer com Queijo", 9.00m));
            produtosDisponiveis.Add(new Produto("X-Tudo", 12.00m));
            produtosDisponiveis.Add(new Produto("Água Mineral (500ml)", 2.50m));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarProdutos();
            AtualizarListaProdutos();
            AtualizarTotal();
        }

        private void AtualizarListaProdutos()
        {
            lbItens.Items.Clear();
            foreach (var produto in produtosDisponiveis)
            {
                lbItens.Items.Add(produto);
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {

        }

        private void btnPagamentoPedido_Click(object sender, EventArgs e)
        {
            FormPagamento formPagamento = new FormPagamento();
            formPagamento.Show();
        }

        private void btnStatusPedidos_Click(object sender, EventArgs e)
        {
            FormVisualizarStatus formVisualizarStatus = new FormVisualizarStatus();
            formVisualizarStatus.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lbItens.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)lbItens.SelectedItem;
                lbCarrinhoCliente.Items.Add(lbItens.SelectedItem);
                totalPedido += produtoSelecionado.Preco;
                AtualizarTotal();
            }
            else
            {
                MessageBox.Show("Para adicionar, primeiro selecione um item disponível!");
            }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lbCarrinhoCliente.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)lbCarrinhoCliente.SelectedItem;
                lbCarrinhoCliente.Items.Remove(lbCarrinhoCliente.SelectedItem);
                totalPedido -= produtoSelecionado.Preco;
                AtualizarTotal();
            }
            else
            {
                MessageBox.Show("Para remover, primeiro selecione um item no carrinho!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarTotal()
        {
            lblTotal.Text = $"Total: R${totalPedido:F2}";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
