using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Semestral_Cantina
{
    public partial class FormBalcao : Form
    {
        private List<string> todosPedidos = new List<string>();

            public FormBalcao()
            {
                InitializeComponent();
                CarregarPedidosProntos();

                PedidoManager.NovoPedidoPronto += () => Invoke(new Action(CarregarPedidosProntos));
            }

            private void CarregarPedidosProntos()
            {
                lbStatusPronto.Items.Clear();
                foreach (var item in PedidoManager.ObterPedidosProntos())
                {
                    lbStatusPronto.Items.Add(item);
                }
                lbStatusPronto.TopIndex = lbStatusPronto.Items.Count - 1;
            }

        public void AdicionarPedidoPronto(string pedidoPronto)
        {
            if (lbStatusPronto.InvokeRequired)
            {
                lbStatusPronto.Invoke(new Action<string>(AdicionarPedidoPronto), pedidoPronto);
            }
            else
            {
                lbStatusPronto.Items.Add(pedidoPronto);
                lbStatusPronto.TopIndex = lbStatusPronto.Items.Count - 1;
            }
        }

        private void AtualizarListaPedidos()
        {
            lbStatusPreparando.Items.Clear();
            foreach (var item in todosPedidos)
            {
                lbStatusPreparando.Items.Add(item);
            }
            lbStatusPreparando.TopIndex = lbStatusPreparando.Items.Count - 1;
        }

        private void btnRetornar4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntregarPedido_Click(object sender, EventArgs e)
        {

        }

        private void FormBalcao_Load(object sender, EventArgs e)
        {

        }
    }
}