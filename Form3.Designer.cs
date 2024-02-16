namespace crudApi
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            txtProductStock = new TextBox();
            label6 = new Label();
            txtProductPrice = new TextBox();
            label5 = new Label();
            txtProductDescription = new TextBox();
            label4 = new Label();
            txtProductName = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtProductStock);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtProductPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtProductDescription);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 258);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Producto";
            // 
            // txtProductStock
            // 
            txtProductStock.Location = new Point(169, 206);
            txtProductStock.Name = "txtProductStock";
            txtProductStock.Size = new Size(259, 23);
            txtProductStock.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 209);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 8;
            label6.Text = "Stock";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(169, 166);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(259, 23);
            txtProductPrice.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 169);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 6;
            label5.Text = "Precio";
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new Point(169, 126);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(259, 23);
            txtProductDescription.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 129);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 4;
            label4.Text = "Descripción del Producto";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(169, 83);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(259, 23);
            txtProductName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 86);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre del Producto";
            // 
            // txtID
            // 
            txtID.Location = new Point(169, 46);
            txtID.Name = "txtID";
            txtID.Size = new Size(259, 23);
            txtID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 49);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 8;
            label1.Text = "Modificar Producto";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(402, 299);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 299);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Modificar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 332);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "Form3";
            Text = "Modificar Producto";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtProductStock;
        private Label label6;
        private TextBox txtProductPrice;
        private Label label5;
        private TextBox txtProductDescription;
        private Label label4;
        private TextBox txtProductName;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}