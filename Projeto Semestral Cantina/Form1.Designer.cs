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
            lbValorPedido = new ListBox();
            btnStatusPedidos = new Button();
            SuspendLayout();
            // 
            // lbItens
            // 
            lbItens.BackColor = Color.White;
            lbItens.BorderStyle = BorderStyle.None;
            lbItens.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbItens.FormattingEnabled = true;
            lbItens.ItemHeight = 20;
            lbItens.Location = new Point(198, 149);
            lbItens.Name = "lbItens";
            lbItens.Size = new Size(277, 380);
            lbItens.TabIndex = 0;
            // 
            // lbCarrinhoCliente
            // 
            lbCarrinhoCliente.BackColor = Color.White;
            lbCarrinhoCliente.BorderStyle = BorderStyle.None;
            lbCarrinhoCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCarrinhoCliente.FormattingEnabled = true;
            lbCarrinhoCliente.ItemHeight = 20;
            lbCarrinhoCliente.Location = new Point(706, 149);
            lbCarrinhoCliente.Name = "lbCarrinhoCliente";
            lbCarrinhoCliente.Size = new Size(277, 400);
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
            btnRemover.BackColor = Color.Red;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.Black;
            btnRemover.Location = new Point(544, 495);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(90, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "<- Remover";
            btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnRetornar
            // 
            btnRetornar.BackColor = Color.Red;
            btnRetornar.FlatStyle = FlatStyle.Flat;
            btnRetornar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetornar.Location = new Point(12, 12);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(96, 30);
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
            // lbValorPedido
            // 
            lbValorPedido.BorderStyle = BorderStyle.None;
            lbValorPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbValorPedido.ForeColor = Color.Black;
            lbValorPedido.FormattingEnabled = true;
            lbValorPedido.ItemHeight = 21;
            lbValorPedido.Location = new Point(706, 584);
            lbValorPedido.Name = "lbValorPedido";
            lbValorPedido.Size = new Size(277, 63);
            lbValorPedido.TabIndex = 15;
            // 
            // btnStatusPedidos
            // 
            btnStatusPedidos.BackColor = Color.Yellow;
            btnStatusPedidos.FlatStyle = FlatStyle.Flat;
            btnStatusPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatusPedidos.ForeColor = Color.Black;
            btnStatusPedidos.Location = new Point(1141, 12);
            btnStatusPedidos.Name = "btnStatusPedidos";
            btnStatusPedidos.Size = new Size(143, 30);
            btnStatusPedidos.TabIndex = 16;
            btnStatusPedidos.Text = "Ver status dos pedidos";
            btnStatusPedidos.UseVisualStyleBackColor = false;
            btnStatusPedidos.Click += btnStatusPedidos_Click;
            // 
            // FormCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            BackgroundImage = Properties.Resources.Inspirational_Gradient_Desktop_Background;
            ClientSize = new Size(1296, 714);
            Controls.Add(btnStatusPedidos);
            Controls.Add(lbValorPedido);
            Controls.Add(btnPagamentoPedido);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btnRetornar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(lbCarrinhoCliente);
            Controls.Add(lbItens);
            Name = "FormCaixa";
            Text = "Form1";
            Load += Form1_Load;
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
        private ListBox lbValorPedido;
        private Button btnStatusPedidos;
    }
}
