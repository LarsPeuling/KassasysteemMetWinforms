namespace KassasysteemMetWinforms.Forms
{
    partial class AddEmployee
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
            tBName = new TextBox();
            lblName = new Label();
            btnAddCustomer = new Button();
            SuspendLayout();
            // 
            // tBName
            // 
            tBName.BorderStyle = BorderStyle.None;
            tBName.Location = new Point(325, 186);
            tBName.Name = "tBName";
            tBName.PlaceholderText = "Name Here!";
            tBName.Size = new Size(150, 16);
            tBName.TabIndex = 18;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Location = new Point(379, 168);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 17;
            lblName.Text = "Name:";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnAddCustomer.Location = new Point(350, 353);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(100, 40);
            btnAddCustomer.TabIndex = 16;
            btnAddCustomer.Text = "Add Employee";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tBName);
            Controls.Add(lblName);
            Controls.Add(btnAddCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEmployee";
            Text = "AddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBName;
        private Label lblName;
        private Button btnAddCustomer;
    }
}