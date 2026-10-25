namespace Tienda_de_hamburguesas
{
    partial class Tortas
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
            listTorta = new ListBox();
            listRefresco = new ListBox();
            listPostre = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnCalcular = new Button();
            label4 = new Label();
            textCodigo = new TextBox();
            btnBuscar = new Button();
            textObsequio = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textSubtotal = new TextBox();
            textIva = new TextBox();
            textTotal = new TextBox();
            SuspendLayout();
            // 
            // listTorta
            // 
            listTorta.FormattingEnabled = true;
            listTorta.Items.AddRange(new object[] { "Jalapeño", "Italiana", "Jamón", "Paquete kids", "Ninguno" });
            listTorta.Location = new Point(67, 77);
            listTorta.Name = "listTorta";
            listTorta.Size = new Size(132, 94);
            listTorta.TabIndex = 0;
            // 
            // listRefresco
            // 
            listRefresco.FormattingEnabled = true;
            listRefresco.Items.AddRange(new object[] { "Chico", "Mediano", "Grande", "Ninguno" });
            listRefresco.Location = new Point(425, 77);
            listRefresco.Name = "listRefresco";
            listRefresco.Size = new Size(132, 94);
            listRefresco.TabIndex = 1;
            // 
            // listPostre
            // 
            listPostre.FormattingEnabled = true;
            listPostre.Items.AddRange(new object[] { "Galletas", "Pay de queso", "Nieve", "Ninguno" });
            listPostre.Location = new Point(782, 77);
            listPostre.Name = "listPostre";
            listPostre.Size = new Size(132, 94);
            listPostre.TabIndex = 2;
            listPostre.TabStop = false;
            listPostre.SelectedIndexChanged += listPostre_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 3;
            label1.Text = "Torta";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(448, 35);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 4;
            label2.Text = "Refresco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(798, 35);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 5;
            label3.Text = "Postres";
            // 
            // BtnCalcular
            // 
            BtnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCalcular.Location = new Point(260, 236);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(176, 47);
            BtnCalcular.TabIndex = 6;
            BtnCalcular.Text = "Calcular Pago";
            BtnCalcular.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(136, 334);
            label4.Name = "label4";
            label4.Size = new Size(107, 30);
            label4.TabIndex = 7;
            label4.Text = "Obsequio";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(266, 341);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(100, 23);
            textCodigo.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(403, 341);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(133, 32);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textObsequio
            // 
            textObsequio.Location = new Point(266, 397);
            textObsequio.Name = "textObsequio";
            textObsequio.Size = new Size(291, 23);
            textObsequio.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(617, 304);
            label5.Name = "label5";
            label5.Size = new Size(97, 30);
            label5.TabIndex = 11;
            label5.Text = "Subtotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(617, 354);
            label6.Name = "label6";
            label6.Size = new Size(65, 30);
            label6.TabIndex = 12;
            label6.Text = "I.V.A.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(617, 397);
            label7.Name = "label7";
            label7.Size = new Size(61, 30);
            label7.TabIndex = 13;
            label7.Text = "Total";
            // 
            // textSubtotal
            // 
            textSubtotal.Enabled = false;
            textSubtotal.Location = new Point(749, 304);
            textSubtotal.Name = "textSubtotal";
            textSubtotal.Size = new Size(100, 23);
            textSubtotal.TabIndex = 14;
            // 
            // textIva
            // 
            textIva.Enabled = false;
            textIva.Location = new Point(749, 361);
            textIva.Name = "textIva";
            textIva.Size = new Size(100, 23);
            textIva.TabIndex = 15;
            // 
            // textTotal
            // 
            textTotal.Enabled = false;
            textTotal.Location = new Point(749, 406);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(100, 23);
            textTotal.TabIndex = 16;
            // 
            // Tortas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 565);
            Controls.Add(textTotal);
            Controls.Add(textIva);
            Controls.Add(textSubtotal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textObsequio);
            Controls.Add(btnBuscar);
            Controls.Add(textCodigo);
            Controls.Add(label4);
            Controls.Add(BtnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listPostre);
            Controls.Add(listRefresco);
            Controls.Add(listTorta);
            MinimizeBox = false;
            Name = "Tortas";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Tortas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listTorta;
        private ListBox listRefresco;
        private ListBox listPostre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnCalcular;
        private Label label4;
        private TextBox textCodigo;
        private Button btnBuscar;
        private TextBox textObsequio;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textSubtotal;
        private TextBox textIva;
        private TextBox textTotal;
    }
}
