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
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(255, 255, 128);
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(242, 193);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(167, 23);
            btnEnviar.TabIndex = 16;
            btnEnviar.Text = "Enviar pedido para Cozinha";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 128);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(177, 76);
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
            btnRetornar3.Location = new Point(12, 12);
            btnRetornar3.Name = "btnRetornar3";
            btnRetornar3.Size = new Size(75, 23);
            btnRetornar3.TabIndex = 18;
            btnRetornar3.Text = "Retornar";
            btnRetornar3.UseVisualStyleBackColor = false;
            // 
            // FormFinalizandoPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Inspirational_Gradient_Desktop_Background;
            ClientSize = new Size(648, 404);
            Controls.Add(btnRetornar3);
            Controls.Add(textBox1);
            Controls.Add(btnEnviar);
            Name = "FormFinalizandoPagamento";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox textBox1;
        private Button btnRetornar3;
    }
}