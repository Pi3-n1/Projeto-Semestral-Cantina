using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Semestral_Cantina
{
    public partial class FormFinalizandoPagamento : Form
    {
        private List<string> itensPedido;

        public FormFinalizandoPagamento(List<string> itensPedido)
        {
            InitializeComponent();
            this.itensPedido = itensPedido;
            CarregarItensPedido();
        }

        private void CarregarItensPedido()
        {
            lbExtrato.Items.Clear();
            foreach (var item in itensPedido)
            {
                lbExtrato.Items.Add(item);
            }
        }

        private void FormFinalizandoPagamento_Load(object sender, EventArgs e)
        {
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var pedidoCompleto = new List<string>(itensPedido);
            pedidoCompleto.Insert(0, $"HORA: {DateTime.Now:HH:mm:ss}");
            pedidoCompleto.Add("STATUS: AGUARDANDO PREPARO");

            PedidoManager.AdicionarPedidoCozinha(pedidoCompleto);
            MessageBox.Show("Pedido enviado para a cozinha!");
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string mensagem = "=== COMPROVANTE ===\n";
            foreach (var item in lbExtrato.Items)
            {
                mensagem += item.ToString() + "\n";
            }
            MessageBox.Show(mensagem, "Comprovante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRetornar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}