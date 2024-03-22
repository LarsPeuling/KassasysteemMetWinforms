namespace KassasysteemMetWinforms.Forms
{
    partial class UpdateStockForm
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
            dgvStock = new DataGridView();
            tbStock = new TextBox();
            label2 = new Label();
            btnUpdateStock = new Button();
            tbId = new TextBox();
            lId = new Label();
            lTotalPrice = new Label();
            label1 = new Label();
            btnAddToBasket = new Button();
            label3 = new Label();
            dgvBasket = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBasket).BeginInit();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(12, 12);
            dgvStock.Name = "dgvStock";
            dgvStock.Size = new Size(416, 426);
            dgvStock.TabIndex = 0;
            // 
            // tbStock
            // 
            tbStock.BorderStyle = BorderStyle.None;
            tbStock.Location = new Point(630, 47);
            tbStock.Name = "tbStock";
            tbStock.PlaceholderText = "Stock Here!";
            tbStock.Size = new Size(143, 16);
            tbStock.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(533, 48);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 27;
            label2.Text = "Stock Amount:";
            label2.Click += label2_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.FlatAppearance.BorderColor = Color.Black;
            btnUpdateStock.FlatAppearance.BorderSize = 0;
            btnUpdateStock.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStock.Location = new Point(640, 398);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(148, 40);
            btnUpdateStock.TabIndex = 29;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // tbId
            // 
            tbId.BorderStyle = BorderStyle.None;
            tbId.Location = new Point(586, 29);
            tbId.Name = "tbId";
            tbId.PlaceholderText = "ID Here!";
            tbId.Size = new Size(187, 16);
            tbId.TabIndex = 31;
            tbId.TextChanged += tbId_TextChanged;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.FlatStyle = FlatStyle.Flat;
            lId.Location = new Point(533, 29);
            lId.Name = "lId";
            lId.Size = new Size(20, 15);
            lId.TabIndex = 30;
            lId.Text = "Id:";
            // 
            // lTotalPrice
            // 
            lTotalPrice.AutoSize = true;
            lTotalPrice.FlatStyle = FlatStyle.Flat;
            lTotalPrice.Location = new Point(682, 362);
            lTotalPrice.Name = "lTotalPrice";
            lTotalPrice.Size = new Size(22, 15);
            lTotalPrice.TabIndex = 32;
            lTotalPrice.Text = "€ 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(533, 362);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 33;
            label1.Text = "Total Price:";
            label1.Click += label1_Click;
            // 
            // btnAddToBasket
            // 
            btnAddToBasket.FlatAppearance.BorderColor = Color.Black;
            btnAddToBasket.FlatAppearance.BorderSize = 0;
            btnAddToBasket.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToBasket.Location = new Point(625, 94);
            btnAddToBasket.Name = "btnAddToBasket";
            btnAddToBasket.Size = new Size(148, 40);
            btnAddToBasket.TabIndex = 34;
            btnAddToBasket.Text = "Add to Basket";
            btnAddToBasket.UseVisualStyleBackColor = true;
            btnAddToBasket.Click += btnAddToBasket_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(442, 76);
            label3.Name = "label3";
            label3.Size = new Size(331, 15);
            label3.TabIndex = 35;
            label3.Text = "After selecting the Id of each item, please press add to basket.";
            // 
            // dgvBasket
            // 
            dgvBasket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBasket.Location = new Point(455, 140);
            dgvBasket.Name = "dgvBasket";
            dgvBasket.Size = new Size(318, 219);
            dgvBasket.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(450, 380);
            label4.Name = "label4";
            label4.Size = new Size(323, 15);
            label4.TabIndex = 37;
            label4.Text = "After adding all the items in your basket, press Update Stock";
            // 
            // UpdateStockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dgvBasket);
            Controls.Add(label3);
            Controls.Add(btnAddToBasket);
            Controls.Add(label1);
            Controls.Add(lTotalPrice);
            Controls.Add(tbId);
            Controls.Add(lId);
            Controls.Add(btnUpdateStock);
            Controls.Add(tbStock);
            Controls.Add(label2);
            Controls.Add(dgvStock);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateStockForm";
            Text = "UpdateStockForm";
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBasket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStock;
        private TextBox tbStock;
        private Label label2;
        private Button btnUpdateStock;
        private TextBox tbId;
        private Label lId;
        private Label lTotalPrice;
        private Label label1;
        private Button btnAddToBasket;
        private Label label3;
        private DataGridView dgvBasket;
        private Label label4;
    }
}