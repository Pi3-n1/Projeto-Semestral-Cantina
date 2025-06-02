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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCaixa formCaixa = new FormCaixa();
            formCaixa.Show();
        }

        private void btnBalcao_Click(object sender, EventArgs e)
        {
            FormBalcao formBalcao = new FormBalcao();
            formBalcao.Show();
        }
    }
}
