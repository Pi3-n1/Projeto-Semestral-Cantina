namespace Projeto_Semestral_Cantina
{
    partial class FormPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            lbCaixaDinheiro = new ListBox();
            lbFormaPagamento = new ListBox();
            btnEscolherPagamento = new Button();
            lbMostrarPedido = new ListBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnRetornar2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(389, 487);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(139, 22);
            textBox1.TabIndex = 11;
            textBox1.Text = "Dinheiro do Caixa";
            // 
            // lbCaixaDinheiro
            // 
            lbCaixaDinheiro.BackColor = Color.White;
            lbCaixaDinheiro.BorderStyle = BorderStyle.None;
            lbCaixaDinheiro.FormattingEnabled = true;
            lbCaixaDinheiro.ItemHeight = 15;
            lbCaixaDinheiro.Location = new Point(257, 515);
            lbCaixaDinheiro.Name = "lbCaixaDinheiro";
            lbCaixaDinheiro.Size = new Size(409, 90);
            lbCaixaDinheiro.TabIndex = 10;
            lbCaixaDinheiro.SelectedIndexChanged += lbCaixa_SelectedIndexChanged;
            // 
            // lbFormaPagamento
            // 
            lbFormaPagamento.FormattingEnabled = true;
            lbFormaPagamento.ItemHeight = 15;
            lbFormaPagamento.Location = new Point(365, 82);
            lbFormaPagamento.Name = "lbFormaPagamento";
            lbFormaPagamento.Size = new Size(196, 364);
            lbFormaPagamento.TabIndex = 16;
            // 
            // btnEscolherPagamento
            // 
            btnEscolherPagamento.BackColor = Color.Yellow;
            btnEscolherPagamento.FlatStyle = FlatStyle.Flat;
            btnEscolherPagamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEscolherPagamento.ForeColor = Color.Black;
            btnEscolherPagamento.Location = new Point(582, 252);
            btnEscolherPagamento.Name = "btnEscolherPagamento";
            btnEscolherPagamento.Size = new Size(130, 26);
            btnEscolherPagamento.TabIndex = 17;
            btnEscolherPagamento.Text = "Escolher Pagamento";
            btnEscolherPagamento.UseVisualStyleBackColor = false;
            btnEscolherPagamento.Click += btnEscolherPagamento_Click;
            // 
            // lbMostrarPedido
            // 
            lbMostrarPedido.FormattingEnabled = true;
            lbMostrarPedido.ItemHeight = 15;
            lbMostrarPedido.Location = new Point(69, 192);
            lbMostrarPedido.Name = "lbMostrarPedido";
            lbMostrarPedido.Size = new Size(265, 139);
            lbMostrarPedido.TabIndex = 18;
            lbMostrarPedido.SelectedIndexChanged += lbMostrarPedido_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(131, 164);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(138, 22);
            textBox2.TabIndex = 19;
            textBox2.Text = "Pedido do Cliente";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(375, 54);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(175, 22);
            textBox3.TabIndex = 20;
            textBox3.Text = "Formas de Pagamento";
            // 
            // btnRetornar2
            // 
            btnRetornar2.BackColor = Color.Red;
            btnRetornar2.FlatStyle = FlatStyle.Flat;
            btnRetornar2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetornar2.Location = new Point(12, 12);
            btnRetornar2.Name = "btnRetornar2";
            btnRetornar2.Size = new Size(75, 23);
            btnRetornar2.TabIndex = 21;
            btnRetornar2.Text = "Retornar";
            btnRetornar2.UseVisualStyleBackColor = false;
            btnRetornar2.Click += btnRetornar2_Click;
            // 
            // FormPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Inspirational_Gradient_Desktop_Background;
            ClientSize = new Size(782, 641);
            Controls.Add(btnRetornar2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lbMostrarPedido);
            Controls.Add(btnEscolherPagamento);
            Controls.Add(lbFormaPagamento);
            Controls.Add(textBox1);
            Controls.Add(lbCaixaDinheiro);
            Name = "FormPagamento";
            Text = "Form2";
            Load += FormPagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox lbCaixaDinheiro;
        private ListBox lbFormaPagamento;
        private Button btnEscolherPagamento;
        private ListBox lbMostrarPedido;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnRetornar2;
    }
}