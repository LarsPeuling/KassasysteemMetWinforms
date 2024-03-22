namespace KassasysteemMetWinforms.Forms
{
    partial class EmployeeForm
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
            btnEmployee = new Button();
            btnCustomer = new Button();
            dgvEmployee = new DataGridView();
            btnUpdateEmployee = new Button();
            btnDeleteEmployee = new Button();
            tbEmployeeIdDelete = new TextBox();
            lId = new Label();
            btnAddEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnExit.Location = new Point(12, 342);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnStock.Location = new Point(12, 242);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(100, 40);
            btnStock.TabIndex = 10;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnEmployee.Location = new Point(12, 42);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(100, 40);
            btnEmployee.TabIndex = 9;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnProduct_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnCustomer.Location = new Point(12, 142);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(100, 40);
            btnCustomer.TabIndex = 8;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(153, 42);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.Size = new Size(468, 340);
            dgvEmployee.TabIndex = 11;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.FlatAppearance.BorderColor = Color.Black;
            btnUpdateEmployee.FlatAppearance.BorderSize = 0;
            btnUpdateEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateEmployee.Location = new Point(640, 142);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(148, 40);
            btnUpdateEmployee.TabIndex = 29;
            btnUpdateEmployee.Text = "Update Employee";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.FlatAppearance.BorderColor = Color.Black;
            btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            btnDeleteEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteEmployee.Location = new Point(640, 64);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(148, 40);
            btnDeleteEmployee.TabIndex = 28;
            btnDeleteEmployee.Text = "Delete Employee";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // tbEmployeeIdDelete
            // 
            tbEmployeeIdDelete.BorderStyle = BorderStyle.None;
            tbEmployeeIdDelete.Location = new Point(666, 42);
            tbEmployeeIdDelete.Name = "tbEmployeeIdDelete";
            tbEmployeeIdDelete.PlaceholderText = "Delete Employee id Here!";
            tbEmployeeIdDelete.Size = new Size(122, 16);
            tbEmployeeIdDelete.TabIndex = 27;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.FlatStyle = FlatStyle.Flat;
            lId.Location = new Point(640, 42);
            lId.Name = "lId";
            lId.Size = new Size(20, 15);
            lId.TabIndex = 26;
            lId.Text = "Id:";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.FlatAppearance.BorderColor = Color.Black;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmployee.Location = new Point(640, 342);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(148, 40);
            btnAddEmployee.TabIndex = 25;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(tbEmployeeIdDelete);
            Controls.Add(lId);
            Controls.Add(btnAddEmployee);
            Controls.Add(dgvEmployee);
            Controls.Add(btnStock);
            Controls.Add(btnEmployee);
            Controls.Add(btnCustomer);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeForm";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnStock;
        private Button btnEmployee;
        private Button btnCustomer;
        private DataGridView dgvEmployee;
        private Button btnUpdateEmployee;
        private Button btnDeleteEmployee;
        private TextBox tbEmployeeIdDelete;
        private Label lId;
        private Button btnAddEmployee;
    }
}