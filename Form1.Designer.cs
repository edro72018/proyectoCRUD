﻿namespace crudApi;

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
        dataGridView.CellContentClick += dataGridView_CellContentClick;
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
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnNewProduct);
        Controls.Add(dataGridView);
        Name = "Form1";
        Text = "CRUD";
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView;
    private Button btnNewProduct;
}
