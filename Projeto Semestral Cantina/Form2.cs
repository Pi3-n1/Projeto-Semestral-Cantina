using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Semestral_Cantina
{
    public partial class FormPagamento : Form
    {
        private List<string> itensPedido;
        private decimal totalPedido;

        // Construtor modificado para receber os dados
        public FormPagamento(List<string> itensPedido, decimal totalPedido)
        {
            InitializeComponent();
            this.itensPedido = itensPedido;
            this.totalPedido = totalPedido;
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            // Preenche a ListBox com os itens do pedido
            foreach (var item in itensPedido)
            {
                lbMostrarPedido.Items.Add(item);
            }
        }

        private void lbCaixa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbMostrarPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRetornar2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEscolherPagamento_Click(object sender, EventArgs e)
        {
            FormFinalizandoPagamento formFinalizandoPagamento = new FormFinalizandoPagamento();
            formFinalizandoPagamento.Show();
        }

        private void lbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}