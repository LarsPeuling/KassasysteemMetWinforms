namespace KassasysteemMetWinforms.Forms
{
    partial class UpdateCustomerForm
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
            tbId = new TextBox();
            lId = new Label();
            btnUpdateCustomer = new Button();
            tbName = new TextBox();
            label2 = new Label();
            dgvCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.BorderStyle = BorderStyle.None;
            tbId.Location = new Point(559, 199);
            tbId.Name = "tbId";
            tbId.PlaceholderText = "ID Here!";
            tbId.Size = new Size(187, 16);
            tbId.TabIndex = 43;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.FlatStyle = FlatStyle.Flat;
            lId.Location = new Point(506, 199);
            lId.Name = "lId";
            lId.Size = new Size(20, 15);
            lId.TabIndex = 42;
            lId.Text = "Id:";
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.FlatAppearance.BorderColor = Color.Black;
            btnUpdateCustomer.FlatAppearance.BorderSize = 0;
            btnUpdateCustomer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateCustomer.Location = new Point(536, 239);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(148, 40);
            btnUpdateCustomer.TabIndex = 41;
            btnUpdateCustomer.Text = "Update Customer";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // tbName
            // 
            tbName.BorderStyle = BorderStyle.None;
            tbName.Location = new Point(581, 217);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "New Name Here!";
            tbName.Size = new Size(165, 16);
            tbName.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(506, 218);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 39;
            label2.Text = "New Name:";
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(12, 12);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.Size = new Size(416, 426);
            dgvCustomer.TabIndex = 38;
            dgvCustomer.CellContentClick += dgvStock_CellContentClick;
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbId);
            Controls.Add(lId);
            Controls.Add(btnUpdateCustomer);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(dgvCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCustomerForm";
            Text = "UpdateCustomerForm";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbId;
        private Label lId;
        private Button btnUpdateCustomer;
        private TextBox tbName;
        private Label label2;
        private DataGridView dgvCustomer;
    }
}