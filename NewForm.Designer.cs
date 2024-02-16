namespace crudApi
{
    partial class NewForm : Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtStock = new TextBox();
            label7 = new Label();
            txtPrice = new TextBox();
            label1 = new Label();
            textDescriptionProduct = new TextBox();
            txtProductName = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(21, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(383, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRAR DE PRODUCTO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textDescriptionProduct);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 43);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(506, 207);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 153);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 10;
            label8.Text = "Stock";
            label8.Click += label8_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(171, 150);
            txtStock.Margin = new Padding(4, 3, 4, 3);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(210, 23);
            txtStock.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(123, 123);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 8;
            label7.Text = "Precio";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(171, 120);
            txtPrice.Margin = new Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(210, 23);
            txtPrice.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 94);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 6;
            label1.Text = "Descripción Del Producto";
            // 
            // textDescriptionProduct
            // 
            textDescriptionProduct.Location = new Point(171, 91);
            textDescriptionProduct.Margin = new Padding(4, 3, 4, 3);
            textDescriptionProduct.Name = "textDescriptionProduct";
            textDescriptionProduct.Size = new Size(210, 23);
            textDescriptionProduct.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(171, 62);
            txtProductName.Margin = new Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(210, 23);
            txtProductName.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(171, 33);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(210, 23);
            txtID.TabIndex = 2;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 4;
            label6.Text = "Agregar Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 99);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 65);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 0;
            label4.Text = "Nombre De Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 41);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 0;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(13, 256);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 27);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(374, 256);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 27);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // NewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 295);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NewForm";
            Text = "Nuevo Registro";
            Load += NewForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        //endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private Label label1;
        private TextBox textDescriptionProduct;
        private Label label7;
        private TextBox txtPrice;
        private Label label8;
        private TextBox txtStock;
    }
}

