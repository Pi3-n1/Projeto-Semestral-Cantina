﻿using System;
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

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
            {
                if (login == "Balcao123" && senha == "1234")
                {
                    FormBalcao formBalcao = new FormBalcao();
                    formBalcao.Show();
                }
                else if (login == "Caixa123" && senha == "1234")
                {
                    FormCaixa formCaixa = new FormCaixa();
                    formCaixa.Show();
                }
                else if (login == "Cozinha123" && senha == "1234")
                {
                    FormCozinha formCozinha = new FormCozinha();
                    formCozinha.Show();
                }
                else if (login == "Chamada123" && senha == "1234")
                {
                    FormChamada formChamada = new FormChamada();
                    formChamada.Show();
                }
                else
                {
                    MessageBox.Show("Login Incorreto!");
                }

                txtLogin.Clear();
                txtSenha.Clear();
            }
            else
            {
                MessageBox.Show("Você precisa digitar o Login e Senha!");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
