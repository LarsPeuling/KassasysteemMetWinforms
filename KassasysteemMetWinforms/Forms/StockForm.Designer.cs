namespace KassasysteemMetWinforms.Forms
{
    partial class StockForm
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
            btnStock = new Button();
            btnEmployee = new Button();
            btnCustomer = new Button();
            btnExit = new Button();
            dgvStock = new DataGridView();
            btnAddStock = new Button();
            tbStockIdDelete = new TextBox();
            lId = new Label();
            btnDeleteStock = new Button();
            btnUpdateStock = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnStock.Location = new Point(12, 242);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(100, 40);
            btnStock.TabIndex = 7;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.FlatAppearance.BorderColor = Color.Black;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.Location = new Point(12, 42);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(100, 40);
            btnEmployee.TabIndex = 6;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(12, 142);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(100, 40);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnExit.Location = new Point(12, 342);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(151, 42);
            dgvStock.Name = "dgvStock";
            dgvStock.Size = new Size(468, 340);
            dgvStock.TabIndex = 8;
            dgvStock.CellContentClick += dgvStock_CellContentClick;
            // 
            // btnAddStock
            // 
            btnAddStock.FlatAppearance.BorderColor = Color.Black;
            btnAddStock.FlatAppearance.BorderSize = 0;
            btnAddStock.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStock.Location = new Point(640, 342);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(148, 40);
            btnAddStock.TabIndex = 9;
            btnAddStock.Text = "Add Stock";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // tbStockIdDelete
            // 
            tbStockIdDelete.BorderStyle = BorderStyle.None;
            tbStockIdDelete.Location = new Point(666, 42);
            tbStockIdDelete.Name = "tbStockIdDelete";
            tbStockIdDelete.PlaceholderText = "Delete Stock id Here!";
            tbStockIdDelete.Size = new Size(122, 16);
            tbStockIdDelete.TabIndex = 22;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.FlatStyle = FlatStyle.Flat;
            lId.Location = new Point(640, 42);
            lId.Name = "lId";
            lId.Size = new Size(20, 15);
            lId.TabIndex = 21;
            lId.Text = "Id:";
            // 
            // btnDeleteStock
            // 
            btnDeleteStock.FlatAppearance.BorderColor = Color.Black;
            btnDeleteStock.FlatAppearance.BorderSize = 0;
            btnDeleteStock.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteStock.Location = new Point(640, 64);
            btnDeleteStock.Name = "btnDeleteStock";
            btnDeleteStock.Size = new Size(148, 40);
            btnDeleteStock.TabIndex = 23;
            btnDeleteStock.Text = "Delete Stock";
            btnDeleteStock.UseVisualStyleBackColor = true;
            btnDeleteStock.Click += btnDeleteStock_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.FlatAppearance.BorderColor = Color.Black;
            btnUpdateStock.FlatAppearance.BorderSize = 0;
            btnUpdateStock.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStock.Location = new Point(640, 142);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(148, 40);
            btnUpdateStock.TabIndex = 24;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateStock);
            Controls.Add(btnDeleteStock);
            Controls.Add(tbStockIdDelete);
            Controls.Add(lId);
            Controls.Add(btnAddStock);
            Controls.Add(dgvStock);
            Controls.Add(btnStock);
            Controls.Add(btnEmployee);
            Controls.Add(btnCustomer);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockForm";
            Text = "StockForm";
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStock;
        private Button btnEmployee;
        private Button btnCustomer;
        private Button btnExit;
        private DataGridView dgvStock;
        private Button btnAddStock;
        private TextBox tbStockIdDelete;
        private Label lId;
        private Button btnDeleteStock;
        private Button btnUpdateStock;
    }
}