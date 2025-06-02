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
            FormBalcao formStatus = Application.OpenForms["FormBalcão"] as FormBalcao;

            if (formStatus != null)
            {
                formStatus.AdicionarPedido(new List<string>(lbExtrato.Items.Cast<string>()));
                MessageBox.Show("Pedido enviado para a cozinha!");
                this.Close();
            }
            else
            {
                MessageBox.Show("A tela de status não está aberta!");
            }
        }

        private void btnRetornar3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimindo pedido!");
        }
    }
}