namespace KassasysteemMetWinforms.Forms.Customer
{
    partial class AddCustomerForm
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
            btnAddCustomer = new Button();
            lblName = new Label();
            tBName = new TextBox();
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnAddCustomer.Location = new Point(322, 353);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(100, 40);
            btnAddCustomer.TabIndex = 13;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Location = new Point(107, 92);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 14;
            lblName.Text = "Name:";
            lblName.Click += label1_Click;
            // 
            // tBName
            // 
            tBName.BorderStyle = BorderStyle.None;
            tBName.Location = new Point(155, 92);
            tBName.Name = "tBName";
            tBName.PlaceholderText = "Name Here!";
            tBName.Size = new Size(143, 16);
            tBName.TabIndex = 15;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tBName);
            Controls.Add(lblName);
            Controls.Add(btnAddCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomerForm";
            Text = "AddCustomerForm";
            Load += AddCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCustomer;
        private Label lblName;
        private TextBox tBName;
    }
}