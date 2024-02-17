namespace crudApi;

partial class Form1
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
        dataGridView = new DataGridView();
        btnNewProduct = new Button();
        button1 = new Button();
        lblEstadoConexion = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        SuspendLayout();
        // 
        // dataGridView
        // 
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView.Location = new Point(12, 50);
        dataGridView.Name = "dataGridView";
        dataGridView.Size = new Size(776, 388);
        dataGridView.TabIndex = 0;
        // 
        // btnNewProduct
        // 
        btnNewProduct.Location = new Point(12, 12);
        btnNewProduct.Name = "btnNewProduct";
        btnNewProduct.Size = new Size(145, 32);
        btnNewProduct.TabIndex = 0;
        btnNewProduct.Text = "Nuevo";
        btnNewProduct.UseVisualStyleBackColor = true;
        btnNewProduct.Click += btnNewProduct_Click;
        // 
        // button1
        // 
        button1.Location = new Point(748, 17);
        button1.Name = "button1";
        button1.Size = new Size(40, 23);
        button1.TabIndex = 1;
        button1.Text = "DB";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // lblEstadoConexion
        // 
        lblEstadoConexion.AutoSize = true;
        lblEstadoConexion.Location = new Point(596, 19);
        lblEstadoConexion.Name = "lblEstadoConexion";
        lblEstadoConexion.Size = new Size(0, 15);
        lblEstadoConexion.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblEstadoConexion);
        Controls.Add(button1);
        Controls.Add(btnNewProduct);
        Controls.Add(dataGridView);
        Name = "Form1";
        Text = "CRUD";
        Load += Form1_Load_1;
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView;
    private Button btnNewProduct;
    private Button button1;
    private Label lblEstadoConexion;
}
