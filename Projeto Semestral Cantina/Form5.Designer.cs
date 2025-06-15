namespace Projeto_Semestral_Cantina
{
    partial class FormLogin
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
            btnRetornar = new Button();
            pictureBox2 = new PictureBox();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnConectar = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(btnRetornar);
            panel2.Location = new Point(-259, -19);
            panel2.Name = "panel2";
            panel2.Size = new Size(1073, 46);
            panel2.TabIndex = 21;
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
            pictureBox2.Location = new Point(-11, 30);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 41);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Location = new Point(184, 171);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(247, 23);
            txtLogin.TabIndex = 23;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(184, 231);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(247, 23);
            txtSenha.TabIndex = 24;
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.Yellow;
            btnConectar.FlatStyle = FlatStyle.Flat;
            btnConectar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConectar.Location = new Point(267, 276);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 25;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += btnConectar_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(199, 62);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(214, 28);
            textBox3.TabIndex = 27;
            textBox3.Text = "Bem vindo a Cantina!";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(283, 143);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(45, 22);
            textBox4.TabIndex = 28;
            textBox4.Text = "Login";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(283, 203);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(59, 22);
            textBox5.TabIndex = 29;
            textBox5.Text = "Senha";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(598, 335);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(btnConectar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += FormLogin_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button btnRetornar;
        private PictureBox pictureBox2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnConectar;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}