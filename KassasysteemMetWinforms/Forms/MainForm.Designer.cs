﻿namespace KassasysteemMetWinforms.Forms
{
    partial class MainForm
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
            btnExit = new Button();
            btnCustomer = new Button();
            btnProduct = new Button();
            btnStock = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(12, 159);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(75, 23);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(12, 42);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(75, 23);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(12, 260);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(75, 23);
            btnStock.TabIndex = 3;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStock);
            Controls.Add(btnProduct);
            Controls.Add(btnCustomer);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnCustomer;
        private Button btnProduct;
        private Button btnStock;
    }
}