namespace Projeto_Semestral_Cantina
{
    partial class FormCozinha
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
            pictureBox2 = new PictureBox();
            btnRetornar = new Button();
            btnRetornarLogin = new Button();
            panel2 = new Panel();
            lbOrdemPedidos = new ListBox();
            btnPedidoPronto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.Bolt_2024_pdf__5_;
            pictureBox2.Location = new Point(-15, 41);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 41);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
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
            // 
            // btnRetornarLogin
            // 
            btnRetornarLogin.BackColor = Color.Red;
            btnRetornarLogin.FlatStyle = FlatStyle.Flat;
            btnRetornarLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetornarLogin.Location = new Point(140, 10);
            btnRetornarLogin.Margin = new Padding(0);
            btnRetornarLogin.Name = "btnRetornarLogin";
            btnRetornarLogin.Size = new Size(106, 30);
            btnRetornarLogin.TabIndex = 24;
            btnRetornarLogin.Text = "Voltar ao login";
            btnRetornarLogin.UseVisualStyleBackColor = false;
            btnRetornarLogin.Click += btnRetornarLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(btnRetornarLogin);
            panel2.Controls.Add(btnRetornar);
            panel2.Location = new Point(-136, -6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 44);
            panel2.TabIndex = 22;
            // 
            // lbOrdemPedidos
            // 
            lbOrdemPedidos.BorderStyle = BorderStyle.FixedSingle;
            lbOrdemPedidos.FormattingEnabled = true;
            lbOrdemPedidos.ItemHeight = 15;
            lbOrdemPedidos.Location = new Point(126, 116);
            lbOrdemPedidos.Name = "lbOrdemPedidos";
            lbOrdemPedidos.Size = new Size(214, 482);
            lbOrdemPedidos.TabIndex = 24;
            this.btnPedidoPronto.Click += new System.EventHandler(this.btnPedidoPronto_Click);

            // 
            // btnPedidoPronto
            // 
            btnPedidoPronto.BackColor = Color.Yellow;
            btnPedidoPronto.FlatStyle = FlatStyle.Flat;
            btnPedidoPronto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPedidoPronto.Location = new Point(382, 320);
            btnPedidoPronto.Name = "btnPedidoPronto";
            btnPedidoPronto.Size = new Size(94, 23);
            btnPedidoPronto.TabIndex = 25;
            btnPedidoPronto.Text = "Enviar pedido";
            btnPedidoPronto.UseVisualStyleBackColor = false;
            // 
            // FormCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(567, 652);
            Controls.Add(btnPedidoPronto);
            Controls.Add(lbOrdemPedidos);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Name = "FormCozinha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Button btnRetornar;
        private Button btnRetornarLogin;
        private Panel panel2;
        private ListBox lbOrdemPedidos;
        private Button btnPedidoPronto;
    }
}