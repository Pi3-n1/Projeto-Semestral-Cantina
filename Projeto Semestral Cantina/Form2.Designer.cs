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
            btnEscolherPagamento = new Button();
            lbMostrarPedido = new ListBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnRetornar2 = new Button();
            panel2 = new Panel();
            btnRetornar = new Button();
            btnStatusPedidos = new Button();
            pictureBox2 = new PictureBox();
            txtValorRecebido = new TextBox();
            cbFormaPagamento = new ComboBox();
            lblCaixaDinheiro = new Label();
            checkBox1 = new CheckBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnEscolherPagamento
            // 
            btnEscolherPagamento.BackColor = Color.Yellow;
            btnEscolherPagamento.FlatStyle = FlatStyle.Flat;
            btnEscolherPagamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEscolherPagamento.ForeColor = Color.Black;
            btnEscolherPagamento.Location = new Point(356, 221);
            btnEscolherPagamento.Name = "btnEscolherPagamento";
            btnEscolherPagamento.Size = new Size(140, 26);
            btnEscolherPagamento.TabIndex = 17;
            btnEscolherPagamento.Text = "Escolher Pagamento";
            btnEscolherPagamento.UseVisualStyleBackColor = false;
            btnEscolherPagamento.Click += btnEscolherPagamento_Click;
            // 
            // lbMostrarPedido
            // 
            lbMostrarPedido.FormattingEnabled = true;
            lbMostrarPedido.ItemHeight = 15;
            lbMostrarPedido.Location = new Point(32, 148);
            lbMostrarPedido.Name = "lbMostrarPedido";
            lbMostrarPedido.Size = new Size(265, 304);
            lbMostrarPedido.TabIndex = 18;
            lbMostrarPedido.SelectedIndexChanged += lbMostrarPedido_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(32, 120);
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
            textBox3.Location = new Point(340, 164);
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
            btnRetornar2.Location = new Point(280, 8);
            btnRetornar2.Name = "btnRetornar2";
            btnRetornar2.Size = new Size(75, 23);
            btnRetornar2.TabIndex = 21;
            btnRetornar2.Text = "Retornar";
            btnRetornar2.UseVisualStyleBackColor = false;
            btnRetornar2.Click += btnRetornar2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(btnRetornar2);
            panel2.Controls.Add(btnRetornar);
            panel2.Controls.Add(btnStatusPedidos);
            panel2.Location = new Point(-268, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1062, 35);
            panel2.TabIndex = 22;
            // 
            // btnRetornar
            // 
            btnRetornar.BackColor = Color.Red;
            btnRetornar.FlatStyle = FlatStyle.Flat;
            btnRetornar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetornar.Location = new Point(13, 8);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(96, 30);
            btnRetornar.TabIndex = 7;
            btnRetornar.Text = "Voltar ao login";
            btnRetornar.UseVisualStyleBackColor = false;
            // 
            // btnStatusPedidos
            // 
            btnStatusPedidos.BackColor = Color.Yellow;
            btnStatusPedidos.FlatStyle = FlatStyle.Flat;
            btnStatusPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatusPedidos.ForeColor = Color.Black;
            btnStatusPedidos.Location = new Point(1164, 8);
            btnStatusPedidos.Name = "btnStatusPedidos";
            btnStatusPedidos.Size = new Size(143, 30);
            btnStatusPedidos.TabIndex = 16;
            btnStatusPedidos.Text = "Ver status dos pedidos";
            btnStatusPedidos.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.Bolt_2024_pdf__5_;
            pictureBox2.Location = new Point(-13, 35);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 41);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.BackColor = Color.White;
            txtValorRecebido.BorderStyle = BorderStyle.None;
            txtValorRecebido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtValorRecebido.ForeColor = Color.Black;
            txtValorRecebido.Location = new Point(411, 305);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.ReadOnly = true;
            txtValorRecebido.Size = new Size(196, 16);
            txtValorRecebido.TabIndex = 24;
            txtValorRecebido.TextChanged += txtValorRecebido_TextChanged;
            // 
            // cbFormaPagamento
            // 
            cbFormaPagamento.FormattingEnabled = true;
            cbFormaPagamento.Items.AddRange(new object[] { "Dinheiro", "Débito", "Crédito", "Pix" });
            cbFormaPagamento.Location = new Point(365, 192);
            cbFormaPagamento.Name = "cbFormaPagamento";
            cbFormaPagamento.Size = new Size(121, 23);
            cbFormaPagamento.TabIndex = 25;
            cbFormaPagamento.SelectedIndexChanged += cbFormaPagamento_SelectedIndexChanged;
            // 
            // lblCaixaDinheiro
            // 
            lblCaixaDinheiro.AutoSize = true;
            lblCaixaDinheiro.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaixaDinheiro.Location = new Point(303, 422);
            lblCaixaDinheiro.Name = "lblCaixaDinheiro";
            lblCaixaDinheiro.Size = new Size(72, 30);
            lblCaixaDinheiro.TabIndex = 26;
            lblCaixaDinheiro.Text = "label1";
            lblCaixaDinheiro.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(203, 124);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 19);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Para viagem";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FormPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(649, 483);
            Controls.Add(checkBox1);
            Controls.Add(lblCaixaDinheiro);
            Controls.Add(cbFormaPagamento);
            Controls.Add(txtValorRecebido);
            Controls.Add(pictureBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lbMostrarPedido);
            Controls.Add(btnEscolherPagamento);
            Controls.Add(panel2);
            Name = "FormPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += FormPagamento_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEscolherPagamento;
        private ListBox lbMostrarPedido;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnRetornar2;
        private Panel panel2;
        private Button btnRetornar;
        private Button btnStatusPedidos;
        private PictureBox pictureBox2;
        private TextBox txtValorRecebido;
        private ComboBox cbFormaPagamento;
        private Label lblCaixaDinheiro;
        private CheckBox checkBox1;
    }
}