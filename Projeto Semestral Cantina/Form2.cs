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
        
        //List<int> caixaDinheiro = new List<int>();
        private List<string> itensPedido;
        private decimal totalPedido;

        

        public FormPagamento(List<string> itensPedido, decimal totalPedido)
        {
            InitializeComponent();
            AtualizarCaixa();
            this.itensPedido = itensPedido;
            this.totalPedido = totalPedido;
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            foreach (var item in itensPedido)
            {
                lbMostrarPedido.Items.Add(item);
            }
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

            if (cbFormaPagamento.SelectedIndex > -1)
            {
                FormFinalizandoPagamento formFinalizandoPagamento = new FormFinalizandoPagamento();
                formFinalizandoPagamento.Show();
            }
            else
            {
                MessageBox.Show("Escolha uma forma de pagamento válida!");
            }
        }

        private void lbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void AtualizarCaixa()
        {
            lblCaixaDinheiro.Text = $"Dinheiro no Caixa: R${250:F2}"; ;
        }
    }
}