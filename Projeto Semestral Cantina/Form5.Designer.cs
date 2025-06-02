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
            btnCaixa = new Button();
            btnBalcao = new Button();
            SuspendLayout();
            // 
            // btnCaixa
            // 
            btnCaixa.Location = new Point(355, 197);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(75, 23);
            btnCaixa.TabIndex = 0;
            btnCaixa.Text = "Caixa";
            btnCaixa.UseVisualStyleBackColor = true;
            btnCaixa.Click += button1_Click;
            // 
            // btnBalcao
            // 
            btnBalcao.Location = new Point(355, 141);
            btnBalcao.Name = "btnBalcao";
            btnBalcao.Size = new Size(75, 23);
            btnBalcao.TabIndex = 1;
            btnBalcao.Text = "Balcão";
            btnBalcao.UseVisualStyleBackColor = true;
            btnBalcao.Click += btnBalcao_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBalcao);
            Controls.Add(btnCaixa);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCaixa;
        private Button btnBalcao;
    }
}