namespace Projeto_Semestral_Cantina
{
    partial class FormCaixa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbItens = new ListBox();
            lbCarrinhoCliente = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnRetornar = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnPagamentoPedido = new Button();
            btnStatusPedidos = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            lblTotal = new Label();
            textBox4 = new TextBox();
            nupQuantidade = new NumericUpDown();
            txtNomeCliente = new TextBox();
            textBox1 = new TextBox();
            btnAdicionarNome = new Button();
            btnResetarCarrinho = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuantidade).BeginInit();
            SuspendLayout();
            // 
            // lbItens
            // 
            lbItens.BackColor = Color.White;
            lbItens.BorderStyle = BorderStyle.FixedSingle;
            lbItens.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItens.FormattingEnabled = true;
            lbItens.ItemHeight = 20;
            lbItens.Location = new Point(198, 149);
            lbItens.Name = "lbItens";
            lbItens.Size = new Size(277, 382);
            lbItens.TabIndex = 0;
            lbItens.SelectedIndexChanged += lbItens_SelectedIndexChanged;
            // 
            // lbCarrinhoCliente
            // 
            lbCarrinhoCliente.BackColor = Color.White;
            lbCarrinhoCliente.BorderStyle = BorderStyle.FixedSingle;
            lbCarrinhoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCarrinhoCliente.FormattingEnabled = true;
            lbCarrinhoCliente.ItemHeight = 15;
            lbCarrinhoCliente.Location = new Point(706, 149);
            lbCarrinhoCliente.Name = "lbCarrinhoCliente";
            lbCarrinhoCliente.Size = new Size(277, 377);
            lbCarrinhoCliente.TabIndex = 1;
            lbCarrinhoCliente.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Yellow;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(544, 195);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(90, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar ->";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Anchor = AnchorStyles.None;
            btnRemover.BackColor = Color.Red;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.Black;
            btnRemover.Location = new Point(544, 466);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(90, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "<- Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnRetornar
            // 
            btnRetornar.BackColor = Color.Red;
            btnRetornar.FlatStyle = FlatStyle.Flat;
            btnRetornar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetornar.Location = new Point(24, 8);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(106, 30);
            btnRetornar.TabIndex = 7;
            btnRetornar.Text = "Voltar ao login";
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(273, 121);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 22);
            textBox2.TabIndex = 10;
            textBox2.Text = "Itens da Cantina";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(776, 121);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 22);
            textBox3.TabIndex = 11;
            textBox3.Text = "Carrinho do Cliente";
            // 
            // btnPagamentoPedido
            // 
            btnPagamentoPedido.BackColor = Color.Yellow;
            btnPagamentoPedido.FlatStyle = FlatStyle.Flat;
            btnPagamentoPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagamentoPedido.ForeColor = Color.Black;
            btnPagamentoPedido.Location = new Point(1046, 338);
            btnPagamentoPedido.Name = "btnPagamentoPedido";
            btnPagamentoPedido.Size = new Size(149, 29);
            btnPagamentoPedido.TabIndex = 14;
            btnPagamentoPedido.Text = "Ir para o pagamento ->";
            btnPagamentoPedido.UseVisualStyleBackColor = false;
            btnPagamentoPedido.Click += btnPagamentoPedido_Click;
            // 
            // btnStatusPedidos
            // 
            btnStatusPedidos.BackColor = Color.Yellow;
            btnStatusPedidos.FlatStyle = FlatStyle.Flat;
            btnStatusPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatusPedidos.ForeColor = Color.Black;
            btnStatusPedidos.Location = new Point(1153, 8);
            btnStatusPedidos.Name = "btnStatusPedidos";
            btnStatusPedidos.Size = new Size(143, 30);
            btnStatusPedidos.TabIndex = 16;
            btnStatusPedidos.Text = "Ver status dos pedidos";
            btnStatusPedidos.UseVisualStyleBackColor = false;
            btnStatusPedidos.Click += btnStatusPedidos_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.Bolt_2024_pdf__5_;
            pictureBox2.Location = new Point(-12, 47);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 41);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(btnRetornar);
            panel2.Controls.Add(btnStatusPedidos);
            panel2.Location = new Point(-12, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1319, 47);
            panel2.TabIndex = 20;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.White;
            lblTotal.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(719, 553);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 40);
            lblTotal.TabIndex = 21;
            lblTotal.Text = "label1";
            lblTotal.Click += lblTotal_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(544, 233);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(90, 22);
            textBox4.TabIndex = 23;
            textBox4.Text = "Quantidade";
            // 
            // nupQuantidade
            // 
            nupQuantidade.Location = new Point(531, 261);
            nupQuantidade.Name = "nupQuantidade";
            nupQuantidade.Size = new Size(120, 23);
            nupQuantidade.TabIndex = 24;
            nupQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nupQuantidade.ValueChanged += nupQuantidade_ValueChanged;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeCliente.Location = new Point(252, 92);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(173, 23);
            txtNomeCliente.TabIndex = 25;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(270, 64);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(131, 22);
            textBox1.TabIndex = 26;
            textBox1.Text = "Nome do Cliente";
            // 
            // btnAdicionarNome
            // 
            btnAdicionarNome.BackColor = Color.Yellow;
            btnAdicionarNome.FlatStyle = FlatStyle.Flat;
            btnAdicionarNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarNome.ForeColor = Color.Black;
            btnAdicionarNome.Location = new Point(431, 92);
            btnAdicionarNome.Name = "btnAdicionarNome";
            btnAdicionarNome.Size = new Size(107, 23);
            btnAdicionarNome.TabIndex = 27;
            btnAdicionarNome.Text = "Adicionar Nome";
            btnAdicionarNome.UseVisualStyleBackColor = false;
            btnAdicionarNome.Click += btnAdicionarNome_Click;
            // 
            // btnResetarCarrinho
            // 
            btnResetarCarrinho.BackColor = Color.Red;
            btnResetarCarrinho.FlatStyle = FlatStyle.Flat;
            btnResetarCarrinho.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetarCarrinho.Location = new Point(788, 92);
            btnResetarCarrinho.Name = "btnResetarCarrinho";
            btnResetarCarrinho.Size = new Size(116, 23);
            btnResetarCarrinho.TabIndex = 28;
            btnResetarCarrinho.Text = "Resetar Carrinho";
            btnResetarCarrinho.UseVisualStyleBackColor = false;
            btnResetarCarrinho.Click += btnResetarCarrinho_Click;
            // 
            // FormCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1296, 714);
            Controls.Add(btnResetarCarrinho);
            Controls.Add(btnAdicionarNome);
            Controls.Add(textBox1);
            Controls.Add(txtNomeCliente);
            Controls.Add(nupQuantidade);
            Controls.Add(textBox4);
            Controls.Add(lblTotal);
            Controls.Add(pictureBox2);
            Controls.Add(btnPagamentoPedido);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(lbCarrinhoCliente);
            Controls.Add(lbItens);
            Controls.Add(panel2);
            Name = "FormCaixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nupQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbItens;
        private ListBox lbCarrinhoCliente;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnRetornar;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnPagamentoPedido;
        private Button btnStatusPedidos;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label lblTotal;
        private TextBox textBox4;
        private NumericUpDown nupQuantidade;
        private TextBox txtNomeCliente;
        private TextBox textBox1;
        private Button btnAdicionarNome;
        private Button btnResetarCarrinho;
    }
}
