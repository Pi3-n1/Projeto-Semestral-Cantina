namespace Projeto_Semestral_Cantina
{
    partial class FormVisualizarPedidos
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
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            lbStatusPedidos = new ListBox();
            btnEntregarPedido = new Button();
            lbPedidosEntregues = new ListBox();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(842, 166);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(143, 22);
            textBox5.TabIndex = 18;
            textBox5.Text = "Pedidos Entregues";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(585, 166);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(145, 22);
            textBox4.TabIndex = 17;
            textBox4.Text = "Status dos Pedidos";
            // 
            // lbStatusPedidos
            // 
            lbStatusPedidos.BackColor = Color.White;
            lbStatusPedidos.BorderStyle = BorderStyle.None;
            lbStatusPedidos.FormattingEnabled = true;
            lbStatusPedidos.ItemHeight = 15;
            lbStatusPedidos.Location = new Point(565, 184);
            lbStatusPedidos.Name = "lbStatusPedidos";
            lbStatusPedidos.Size = new Size(182, 405);
            lbStatusPedidos.TabIndex = 16;
            // 
            // btnEntregarPedido
            // 
            btnEntregarPedido.BackColor = Color.Red;
            btnEntregarPedido.FlatStyle = FlatStyle.Flat;
            btnEntregarPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntregarPedido.ForeColor = Color.Black;
            btnEntregarPedido.Location = new Point(707, 104);
            btnEntregarPedido.Name = "btnEntregarPedido";
            btnEntregarPedido.Size = new Size(132, 25);
            btnEntregarPedido.TabIndex = 15;
            btnEntregarPedido.Text = "Entregar Pedido ->";
            btnEntregarPedido.UseVisualStyleBackColor = false;
            // 
            // lbPedidosEntregues
            // 
            lbPedidosEntregues.BackColor = Color.White;
            lbPedidosEntregues.BorderStyle = BorderStyle.None;
            lbPedidosEntregues.FormattingEnabled = true;
            lbPedidosEntregues.ItemHeight = 15;
            lbPedidosEntregues.Location = new Point(775, 184);
            lbPedidosEntregues.Name = "lbPedidosEntregues";
            lbPedidosEntregues.Size = new Size(277, 405);
            lbPedidosEntregues.TabIndex = 14;
            // 
            // FormVisualizarPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Inspirational_Gradient_Desktop_Background;
            ClientSize = new Size(1617, 692);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(lbStatusPedidos);
            Controls.Add(btnEntregarPedido);
            Controls.Add(lbPedidosEntregues);
            Name = "FormVisualizarPedidos";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox4;
        private ListBox lbStatusPedidos;
        private Button btnEntregarPedido;
        private ListBox lbPedidosEntregues;
    }
}