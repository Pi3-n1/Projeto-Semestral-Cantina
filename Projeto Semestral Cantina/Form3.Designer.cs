namespace Projeto_Semestral_Cantina
{
    partial class FormVisualizarStatus
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
            lbStatusPreparando = new ListBox();
            btnEntregarPedido = new Button();
            lbPedidosEntregues = new ListBox();
            lbStatusPronto = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnRetornar4 = new Button();
            panel2 = new Panel();
            btnStatusPedidos = new Button();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(708, 126);
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
            textBox4.Location = new Point(127, 94);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(145, 22);
            textBox4.TabIndex = 17;
            textBox4.Text = "Status dos Pedidos";
            // 
            // lbStatusPreparando
            // 
            lbStatusPreparando.BackColor = Color.White;
            lbStatusPreparando.BorderStyle = BorderStyle.FixedSingle;
            lbStatusPreparando.FormattingEnabled = true;
            lbStatusPreparando.ItemHeight = 15;
            lbStatusPreparando.Location = new Point(12, 154);
            lbStatusPreparando.Name = "lbStatusPreparando";
            lbStatusPreparando.Size = new Size(182, 392);
            lbStatusPreparando.TabIndex = 16;
            // 
            // btnEntregarPedido
            // 
            btnEntregarPedido.BackColor = Color.Yellow;
            btnEntregarPedido.FlatStyle = FlatStyle.Flat;
            btnEntregarPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntregarPedido.ForeColor = Color.Black;
            btnEntregarPedido.Location = new Point(456, 343);
            btnEntregarPedido.Name = "btnEntregarPedido";
            btnEntregarPedido.Size = new Size(132, 25);
            btnEntregarPedido.TabIndex = 15;
            btnEntregarPedido.Text = "Entregar Pedido ->";
            btnEntregarPedido.UseVisualStyleBackColor = false;
            // 
            // lbPedidosEntregues
            // 
            lbPedidosEntregues.BackColor = Color.White;
            lbPedidosEntregues.BorderStyle = BorderStyle.FixedSingle;
            lbPedidosEntregues.FormattingEnabled = true;
            lbPedidosEntregues.ItemHeight = 15;
            lbPedidosEntregues.Location = new Point(669, 154);
            lbPedidosEntregues.Name = "lbPedidosEntregues";
            lbPedidosEntregues.Size = new Size(210, 392);
            lbPedidosEntregues.TabIndex = 14;
            // 
            // lbStatusPronto
            // 
            lbStatusPronto.BorderStyle = BorderStyle.FixedSingle;
            lbStatusPronto.FormattingEnabled = true;
            lbStatusPronto.ItemHeight = 15;
            lbStatusPronto.Location = new Point(200, 154);
            lbStatusPronto.Name = "lbStatusPronto";
            lbStatusPronto.Size = new Size(182, 392);
            lbStatusPronto.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(32, 126);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(140, 22);
            textBox1.TabIndex = 20;
            textBox1.Text = "Sendo preparados";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(213, 126);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(155, 22);
            textBox2.TabIndex = 21;
            textBox2.Text = "Pronto para entrega";
            // 
            // btnRetornar4
            // 
            btnRetornar4.BackColor = Color.Red;
            btnRetornar4.FlatStyle = FlatStyle.Flat;
            btnRetornar4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetornar4.ForeColor = Color.Black;
            btnRetornar4.Location = new Point(98, 29);
            btnRetornar4.Name = "btnRetornar4";
            btnRetornar4.Size = new Size(75, 23);
            btnRetornar4.TabIndex = 22;
            btnRetornar4.Text = "Retornar";
            btnRetornar4.UseVisualStyleBackColor = false;
            btnRetornar4.Click += btnRetornar4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(btnRetornar4);
            panel2.Controls.Add(btnStatusPedidos);
            panel2.Location = new Point(-86, -17);
            panel2.Name = "panel2";
            panel2.Size = new Size(1062, 62);
            panel2.TabIndex = 24;
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
            pictureBox2.Location = new Point(-13, 48);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 41);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // FormVisualizarStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 692);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbStatusPronto);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(lbStatusPreparando);
            Controls.Add(btnEntregarPedido);
            Controls.Add(lbPedidosEntregues);
            Controls.Add(panel2);
            Name = "FormVisualizarStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox4;
        private ListBox lbStatusPreparando;
        private Button btnEntregarPedido;
        private ListBox lbPedidosEntregues;
        private ListBox lbStatusPronto;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnRetornar4;
        private Panel panel2;
        private Button btnStatusPedidos;
        private PictureBox pictureBox2;
    }
}