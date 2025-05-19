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
            produtosDisponiveis.Add(new Produto("Pão de Queijo", 3.50m, 1));
            produtosDisponiveis.Add(new Produto("Coxinha", 5.00m, 1));
            produtosDisponiveis.Add(new Produto("Pastel de Carne", 6.00m, 1));
            produtosDisponiveis.Add(new Produto("Pastel de Queijo", 5.50m, 1));
            produtosDisponiveis.Add(new Produto("Suco Natural (300ml)", 4.00m, 1));
            produtosDisponiveis.Add(new Produto("Refrigerante Lata", 4.50m, 1));
            produtosDisponiveis.Add(new Produto("Hambúrguer Simples", 8.00m, 1));
            produtosDisponiveis.Add(new Produto("Hambúrguer com Queijo", 9.00m, 1));
            produtosDisponiveis.Add(new Produto("X-Tudo", 12.00m, 1));
            produtosDisponiveis.Add(new Produto("Água Mineral (500ml)", 2.50m, 1));
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
        private void AtualizarCarrinho()
        {
            lbCarrinhoCliente.Items.Clear();
            foreach (var produto in carrinho)
            {
                lbCarrinhoCliente.Items.Add(produto);
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
            string quantidade = $"{nupQuantidade.Value}";
            if (lbItens.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)lbItens.SelectedItem;
                //lbCarrinhoCliente.Items.Add($"{lbItens.SelectedItem} / quantidade = {quantidade}");
                carrinho.Add(new Produto(produtoSelecionado.Nome, produtoSelecionado.Preco, produtoSelecionado.Quantidade));
                totalPedido += produtoSelecionado.Preco * int.Parse(quantidade);
                AtualizarTotal();
                AtualizarCarrinho();
            }
            else
            {
                MessageBox.Show("Para adicionar, primeiro selecione um item disponível!");
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string quantidade = $"{nupQuantidade.Value}";
            if (lbCarrinhoCliente.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)lbCarrinhoCliente.SelectedItem;
                carrinho.Remove(produtoSelecionado);
                totalPedido -= produtoSelecionado.Preco * int.Parse(quantidade);
                AtualizarCarrinho();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nupQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
