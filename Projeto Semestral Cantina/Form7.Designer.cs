namespace Projeto_Semestral_Cantina
{
    partial class FormChamada
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
            panel2 = new Panel();
            btnRetornarLogin = new Button();
            btnRetornar = new Button();
            pictureBox2 = new PictureBox();
            lbChamadaCliente = new ListBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(btnRetornarLogin);
            panel2.Controls.Add(btnRetornar);
            panel2.Location = new Point(-162, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1124, 50);
            panel2.TabIndex = 23;
            // 
            // btnRetornarLogin
            // 
            btnRetornarLogin.BackColor = Color.Red;
            btnRetornarLogin.FlatStyle = FlatStyle.Flat;
            btnRetornarLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetornarLogin.Location = new Point(170, 12);
            btnRetornarLogin.Margin = new Padding(0);
            btnRetornarLogin.Name = "btnRetornarLogin";
            btnRetornarLogin.Size = new Size(106, 30);
            btnRetornarLogin.TabIndex = 24;
            btnRetornarLogin.Text = "Voltar ao login";
            btnRetornarLogin.UseVisualStyleBackColor = false;
            btnRetornarLogin.Click += btnRetornarLogin_Click;
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
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = Properties.Resources.Bolt_2024_pdf__5_;
            pictureBox2.Location = new Point(-10, 48);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 41);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // lbChamadaCliente
            // 
            lbChamadaCliente.BorderStyle = BorderStyle.FixedSingle;
            lbChamadaCliente.FormattingEnabled = true;
            lbChamadaCliente.ItemHeight = 15;
            lbChamadaCliente.Location = new Point(176, 61);
            lbChamadaCliente.Name = "lbChamadaCliente";
            lbChamadaCliente.Size = new Size(209, 377);
            lbChamadaCliente.TabIndex = 26;
            // 
            // FormChamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(551, 450);
            Controls.Add(lbChamadaCliente);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Name = "FormChamada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnRetornarLogin;
        private Button btnRetornar;
        private PictureBox pictureBox2;
        private Button button1;
        private ListBox lbChamadaCliente;
    }
}