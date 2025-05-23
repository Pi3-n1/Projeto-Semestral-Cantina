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
    public partial class FormFinalizandoPagamento : Form
    {

        public FormFinalizandoPagamento()
        {
            InitializeComponent();
        }

        private void FormFinalizandoPagamento_Load(object sender, EventArgs e)
        {
            //foreach (var item in itensPedido)
            //{
            //    lbExtrato.Items.Add(item);
            //}
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido enviado para a cozinha!");
        }

        private void btnRetornar3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
