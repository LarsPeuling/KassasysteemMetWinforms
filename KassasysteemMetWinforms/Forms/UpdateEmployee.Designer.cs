namespace KassasysteemMetWinforms.Forms
{
    partial class UpdateEmployee
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
            btnUpdateEmployee = new Button();
            tbName = new TextBox();
            label2 = new Label();
            dgvEmployee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.BorderStyle = BorderStyle.None;
            tbId.Location = new Point(580, 199);
            tbId.Name = "tbId";
            tbId.PlaceholderText = "ID Here!";
            tbId.Size = new Size(187, 16);
            tbId.TabIndex = 49;
            // 
            // lId
            // 
            lId.AutoSize = true;
            lId.FlatStyle = FlatStyle.Flat;
            lId.Location = new Point(527, 199);
            lId.Name = "lId";
            lId.Size = new Size(20, 15);
            lId.TabIndex = 48;
            lId.Text = "Id:";
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.FlatAppearance.BorderColor = Color.Black;
            btnUpdateEmployee.FlatAppearance.BorderSize = 0;
            btnUpdateEmployee.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateEmployee.Location = new Point(557, 239);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(148, 40);
            btnUpdateEmployee.TabIndex = 47;
            btnUpdateEmployee.Text = "Update Employee";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // tbName
            // 
            tbName.BorderStyle = BorderStyle.None;
            tbName.Location = new Point(602, 217);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "New Name Here!";
            tbName.Size = new Size(165, 16);
            tbName.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(527, 218);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 45;
            label2.Text = "New Name:";
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(33, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.Size = new Size(416, 426);
            dgvEmployee.TabIndex = 44;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // UpdateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbId);
            Controls.Add(lId);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(dgvEmployee);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateEmployee";
            Text = "UpdateEmployee";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbId;
        private Label lId;
        private Button btnUpdateEmployee;
        private TextBox tbName;
        private Label label2;
        private DataGridView dgvEmployee;
    }
}