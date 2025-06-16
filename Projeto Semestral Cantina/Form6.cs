using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Semestral_Cantina
{
    public partial class FormCozinha : Form
    {
        public FormCozinha()
        {
            InitializeComponent();
            CarregarPedidos();
            btnPedidoPronto.Enabled = false;

            PedidoManager.NovoPedidoCozinha += () => Invoke(new Action(CarregarPedidos));
        }

        private void CarregarPedidos()
        {
            lbOrdemPedidos.Items.Clear();
            foreach (var item in PedidoManager.ObterPedidosCozinha())
            {
                lbOrdemPedidos.Items.Add(item);
            }
        }

        private void btnPedidoPronto_Click(object sender, EventArgs e)
        {
            if (lbOrdemPedidos.SelectedIndex != -1)
            {
                var pedidoCompleto = ObterPedidoCompleto(lbOrdemPedidos.SelectedIndex);
                if (pedidoCompleto.Count > 0)
                {
                    var pedidoPronto = new List<string>(pedidoCompleto);
                    pedidoPronto[0] = pedidoPronto[0].Replace("PEDIDO", "PRONTO");

                    PedidoManager.AdicionarPedidoPronto(pedidoPronto);
                    CarregarPedidos();
                    MessageBox.Show("Pedido marcado como pronto!");
                }
            }
        }

        private List<string> ObterPedidoCompleto(int selectedIndex)
        {
            var pedidoCompleto = new List<string>();

            for (int i = selectedIndex; i >= 0; i--)
            {
                if (lbOrdemPedidos.Items[i].ToString().Contains("======="))
                {
                    for (int j = i; j < lbOrdemPedidos.Items.Count; j++)
                    {
                        pedidoCompleto.Add(lbOrdemPedidos.Items[j].ToString());
                        if (lbOrdemPedidos.Items[j].ToString().Contains("----------------"))
                            break;
                    }
                    break;
                }
            }
            return pedidoCompleto;
        }

        private void lbOrdemPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPedidoPronto.Enabled = lbOrdemPedidos.SelectedIndex != -1;
        }

        private void btnRetornarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCozinha_Load(object sender, EventArgs e)
        {

        }
    }
}