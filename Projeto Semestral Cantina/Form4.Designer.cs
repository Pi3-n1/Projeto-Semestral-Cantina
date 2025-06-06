namespace Projeto_Semestral_Cantina
{
    partial class FormFinalizandoPagamento
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
            btnEnviar = new Button();
            textBox1 = new TextBox();
            btnRetornar3 = new Button();
            panel2 = new Panel();
            btnRetornar = new Button();
            btnStatusPedidos = new Button();
            pictureBox2 = new PictureBox();
            lbExtrato = new ListBox();
            textBox2 = new TextBox();
            btnImprimir = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Yellow;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(145, 206);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(167, 23);
            btnEnviar.TabIndex = 16;
            btnEnviar.Text = "Enviar pedido para Cozinha";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(85, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 36);
            textBox1.TabIndex = 17;
            textBox1.Text = "Pagamento Concluído!";
            // 
            // btnRetornar3
            // 
            btnRetornar3.BackColor = Color.Red;
            btnRetornar3.FlatStyle = FlatStyle.Flat;
            btnRetornar3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetornar3.Location = new Point(215, 9);
            btnRetornar3.Name = "btnRetornar3";
            btnRetornar3.Size = new Size(75, 23);
            btnRetornar3.TabIndex = 18;
            btnRetornar3.Text = "Retornar";
            btnRetornar3.UseVisualStyleBackColor = false;
            btnRetornar3.Click += btnRetornar3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(btnRetornar3);
            panel2.Controls.Add(btnRetornar);
            panel2.Controls.Add(btnStatusPedidos);
            panel2.Location = new Point(-208, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1062, 38);
            panel2.TabIndex = 23;
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
            pictureBox2.Location = new Point(-13, 38);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 41);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // lbExtrato
            // 
            lbExtrato.FormattingEnabled = true;
            lbExtrato.ItemHeight = 15;
            lbExtrato.Location = new Point(409, 81);
            lbExtrato.Name = "lbExtrato";
            lbExtrato.Size = new Size(226, 214);
            lbExtrato.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(483, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 28);
            textBox2.TabIndex = 26;
            textBox2.Text = "Extrato";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.Yellow;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Location = new Point(465, 301);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(110, 23);
            btnImprimir.TabIndex = 27;
            btnImprimir.Text = "Imprimir Extrato";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // FormFinalizandoPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(647, 336);
            Controls.Add(btnImprimir);
            Controls.Add(textBox2);
            Controls.Add(lbExtrato);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(btnEnviar);
            Controls.Add(panel2);
            Name = "FormFinalizandoPagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += FormFinalizandoPagamento_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox textBox1;
        private Button btnRetornar3;
        private Panel panel2;
        private Button btnRetornar;
        private Button btnStatusPedidos;
        private PictureBox pictureBox2;
        private ListBox lbExtrato;
        private TextBox textBox2;
        private Button btnImprimir;
    }
}