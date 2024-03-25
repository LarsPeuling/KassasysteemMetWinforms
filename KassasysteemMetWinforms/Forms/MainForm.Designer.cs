namespace KassasysteemMetWinforms.Forms
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
            btnEmployee = new Button();
            btnStock = new Button();
            dgvCriticalStock = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCriticalStock).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnExit.Location = new Point(12, 342);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnCustomer.Location = new Point(12, 142);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(100, 40);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnEmployee.Location = new Point(12, 42);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(100, 40);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnProduct_Click;
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnStock.Location = new Point(12, 242);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(100, 40);
            btnStock.TabIndex = 3;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // dgvCriticalStock
            // 
            dgvCriticalStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCriticalStock.Location = new Point(135, 42);
            dgvCriticalStock.Name = "dgvCriticalStock";
            dgvCriticalStock.Size = new Size(317, 340);
            dgvCriticalStock.TabIndex = 4;
            dgvCriticalStock.CellContentClick += dgvCriticalStock_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCriticalStock);
            Controls.Add(btnStock);
            Controls.Add(btnEmployee);
            Controls.Add(btnCustomer);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dgvCriticalStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnCustomer;
        private Button btnEmployee;
        private Button btnStock;
        private DataGridView dgvCriticalStock;
    }
}