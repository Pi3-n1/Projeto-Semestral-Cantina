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

        private string nomeCliente = "";
        private void AtualizarCarrinho()
        {
            lbCarrinhoCliente.Items.Clear();
            if (!string.IsNullOrEmpty(nomeCliente))
            {
                lbCarrinhoCliente.Items.Add($"CLIENTE: {nomeCliente}");
                lbCarrinhoCliente.Items.Add("--------------------------");
            }
            var produtosAgrupados = carrinho
                .GroupBy(p => p.Nome)
                .Select(g => new
                {
                    Nome = g.Key,
                    Quantidade = g.Sum(p => p.Quantidade),
                    Preco = g.First().Preco
                });

            foreach (var produto in produtosAgrupados)
            {
                lbCarrinhoCliente.Items.Add($"{produto.Nome} x{produto.Quantidade} - R${produto.Preco * produto.Quantidade:F2}");
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
        }

        private void btnPagamentoPedido_Click(object sender, EventArgs e)
        {
            if (carrinho.Count == 0)
            {
                MessageBox.Show("Adicione itens ao carrinho antes de prosseguir para o pagamento!");
                return;
            }
            List<string> itensFormatados = new List<string>();
            itensFormatados.Add($"CLIENTE: {nomeCliente}");
            itensFormatados.Add("<------------------------>");
            var produtosAgrupados = carrinho
                .GroupBy(p => p.Nome)
                .Select(g => new
                {
                    Nome = g.Key,
                    Quantidade = g.Sum(p => p.Quantidade),
                    Preco = g.First().Preco
                });

            foreach (var produto in produtosAgrupados)
            {
                itensFormatados.Add($"{produto.Nome} x{produto.Quantidade} - R${produto.Preco * produto.Quantidade:F2}");
            }

            itensFormatados.Add("--------------------------");
            itensFormatados.Add($"TOTAL: R${totalPedido:F2}");
            FormPagamento formPagamento = new FormPagamento(itensFormatados, totalPedido);
            formPagamento.Show();
        }

        private void btnStatusPedidos_Click(object sender, EventArgs e)
        {
            FormVisualizarStatus formVisualizarStatus = new FormVisualizarStatus();
            formVisualizarStatus.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomeCliente))
            {
                MessageBox.Show("Adicione o nome do cliente primeiro!");
                return;
            }

            int quantidade = (int)nupQuantidade.Value;
            if (quantidade <= 0)
            {
                MessageBox.Show("A quantidade deve ser maior que zero!");
                return;
            }

            if (lbItens.SelectedItem != null)
            {
                Produto produtoSelecionado = (Produto)lbItens.SelectedItem;
                carrinho.Add(new Produto(produtoSelecionado.Nome, produtoSelecionado.Preco, quantidade));
                totalPedido += produtoSelecionado.Preco * quantidade;
                AtualizarTotal();
                AtualizarCarrinho();
            }
            else
            {
                MessageBox.Show("Selecione um item para adicionar!");
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lbCarrinhoCliente.SelectedItem != null)
            {
                string itemSelecionado = lbCarrinhoCliente.SelectedItem.ToString();
                string nomeProduto = itemSelecionado.Split('x')[0].Trim();

                var produtosParaRemover = carrinho.Where(p => p.Nome == nomeProduto).ToList();
                foreach (var produto in produtosParaRemover)
                {
                    totalPedido -= produto.Preco * produto.Quantidade;
                    carrinho.Remove(produto);
                }

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

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionarNome_Click(object sender, EventArgs e)
        {
            string novoNome = txtNomeCliente.Text.Trim();

            if (!string.IsNullOrWhiteSpace(novoNome))
            {
                nomeCliente = novoNome;

                carrinho.Clear();
                totalPedido = 0;
                AtualizarTotal();
                AtualizarCarrinho();

                txtNomeCliente.Enabled = false;
                btnAdicionarNome.Enabled = false;
                lbItens.Enabled = true;
                nupQuantidade.Enabled = true;
                btnAdicionar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Digite um nome válido!");
            }
        }

        private void btnResetarCarrinho_Click(object sender, EventArgs e)
        {
            if (lbCarrinhoCliente.Items.Count > 0)
            {
                var resultado = MessageBox.Show("Você realmente quer RESETAR o carrinho?", "Resetar Carrinho", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    lbCarrinhoCliente.Items.Clear();
                    txtNomeCliente.Clear();
                    txtNomeCliente.Enabled = true;
                    btnAdicionarNome.Enabled = true;
                    MessageBox.Show("Carrinho resetado!");
                    totalPedido = 0;
                    AtualizarTotal();
                }
            }
            else
            {
                MessageBox.Show("O carrinho precisa ter algo para ser resetado!");
            }

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}