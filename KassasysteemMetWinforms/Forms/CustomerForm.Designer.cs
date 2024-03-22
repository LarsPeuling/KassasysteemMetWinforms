namespace KassasysteemMetWinforms.Forms
{
    partial class CustomerForm
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
            btnAddCustomer = new Button();
            dgvCustomer = new DataGridView();
            btnUpdateCustomer = new Button();
            btnRemoveCustomer = new Button();
            tbId = new TextBox();
            lId = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnStock.Location = new Point(688, 243);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(100, 40);
            btnStock.TabIndex = 11;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnEmployee.Location = new Point(688, 43);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(100, 40);
            btnEmployee.TabIndex = 10;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnProduct_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnCustomer.Location = new Point(688, 143);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(100, 40);
            btnCustomer.TabIndex = 9;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnExit.Location = new Point(688, 343);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnAddCustomer.Location = new Point(525, 343);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(100, 40);
            btnAddCustomer.TabIndex = 12;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(34, 43);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.Size = new Size(591, 240);
            dgvCustomer.TabIndex = 13;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnUpdateCustomer.Location = new Point(365, 343);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(100, 40);
            btnUpdateCustomer.TabIndex = 14;
            btnUpdateCustomer.Text = "Update Customer";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnRemoveCustomer
            // 
            btnRemoveCustomer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnRemoveCustomer.Location = new Point(200, 343);
            btnRemoveCustomer.Name = "btnRemoveCustomer";
            btnRemoveCustomer.Size = new Size(100, 40);
            btnRemoveCustomer.TabIndex = 15;
            btnRemoveCustomer.Text = "Remove Customer";
            btnRemoveCustomer.UseVisualStyleBackColor = true;
            btnRemoveCustomer.Click += btnRemoveCustomer_Click;
            // 
            // tbId
            // 
            tbId.BorderStyle = BorderStyle.None;
            tbId.Location = new Point(111, 367);
            tbId.Name = "tbId";
            tbId.PlaceholderText = "ID Here!";
            tbId.Size = new Size(81, 16);
            tbId.TabIndex = 45;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.FlatStyle = FlatStyle.Flat;
            lId.Location = new Point(85, 367);
            lId.Name = "lId";
            lId.Size = new Size(20, 15);
            lId.TabIndex = 44;
            lId.Text = "Id:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(85, 325);
            label1.Name = "label1";
            label1.Size = new Size(215, 15);
            label1.TabIndex = 46;
            label1.Text = "Enter Customer Id to be removed";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tbId);
            Controls.Add(lId);
            Controls.Add(btnRemoveCustomer);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(dgvCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnStock);
            Controls.Add(btnEmployee);
            Controls.Add(btnCustomer);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerForm";
            Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStock;
        private Button btnEmployee;
        private Button btnCustomer;
        private Button btnExit;
        private Button btnAddCustomer;
        private DataGridView dgvCustomer;
        private Button btnUpdateCustomer;
        private Button btnRemoveCustomer;
        private TextBox tbId;
        private Label lId;
        private Label label1;
    }
}