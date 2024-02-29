namespace KassasysteemMetWinforms.Forms
{
    partial class ProductForm
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
            btnStock = new Button();
            btnProduct = new Button();
            btnCustomer = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 371);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(12, 274);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(75, 23);
            btnStock.TabIndex = 10;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(12, 77);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(75, 23);
            btnProduct.TabIndex = 9;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(12, 170);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(75, 23);
            btnCustomer.TabIndex = 8;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStock);
            Controls.Add(btnProduct);
            Controls.Add(btnCustomer);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            Text = "Product";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnStock;
        private Button btnProduct;
        private Button btnCustomer;
    }
}