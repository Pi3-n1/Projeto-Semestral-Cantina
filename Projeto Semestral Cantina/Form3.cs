using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Semestral_Cantina
{
    public partial class FormVisualizarStatus : Form
    {
        private List<string> todosPedidos = new List<string>();

        public FormVisualizarStatus()
        {
            InitializeComponent();
        }

        public void AdicionarPedido(List<string> itensPedido)
        {
            todosPedidos.Add($"======= PEDIDO {DateTime.Now.ToString("HH:mm:ss")} =======");
            todosPedidos.AddRange(itensPedido);
            todosPedidos.Add("----------------------------");
            AtualizarListaPedidos();
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
    }
}