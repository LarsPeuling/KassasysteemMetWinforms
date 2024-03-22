namespace KassasysteemMetWinforms.Forms
{
    partial class AddStockForm
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
            tBNameStock = new TextBox();
            lblName = new Label();
            btnAddStock = new Button();
            tbPrice = new TextBox();
            lPrice = new Label();
            tbDescription = new TextBox();
            label1 = new Label();
            tbStock = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // tBNameStock
            // 
            tBNameStock.BorderStyle = BorderStyle.None;
            tBNameStock.Location = new Point(170, 57);
            tBNameStock.Name = "tBNameStock";
            tBNameStock.PlaceholderText = "Name Here!";
            tBNameStock.Size = new Size(187, 16);
            tBNameStock.TabIndex = 18;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Location = new Point(122, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 17;
            lblName.Text = "Name:";
            // 
            // btnAddStock
            // 
            btnAddStock.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnAddStock.Location = new Point(341, 398);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(100, 40);
            btnAddStock.TabIndex = 16;
            btnAddStock.Text = "Add Stock";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // tbPrice
            // 
            tbPrice.BorderStyle = BorderStyle.None;
            tbPrice.Location = new Point(170, 83);
            tbPrice.Name = "tbPrice";
            tbPrice.PlaceholderText = "Price Here!";
            tbPrice.Size = new Size(187, 16);
            tbPrice.TabIndex = 20;
            // 
            // lPrice
            // 
            lPrice.AutoSize = true;
            lPrice.FlatStyle = FlatStyle.Flat;
            lPrice.Location = new Point(122, 83);
            lPrice.Name = "lPrice";
            lPrice.Size = new Size(36, 15);
            lPrice.TabIndex = 19;
            lPrice.Text = "Price:";
            // 
            // tbDescription
            // 
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.Location = new Point(195, 134);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.PlaceholderText = "Description Here!";
            tbDescription.Size = new Size(162, 23);
            tbDescription.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(122, 135);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 23;
            label1.Text = "Description";
            // 
            // tbStock
            // 
            tbStock.BorderStyle = BorderStyle.None;
            tbStock.Location = new Point(214, 108);
            tbStock.Name = "tbStock";
            tbStock.PlaceholderText = "Stock Here!";
            tbStock.Size = new Size(143, 16);
            tbStock.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(122, 109);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 21;
            label2.Text = "Stock Amount:";
            // 
            // AddStockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbDescription);
            Controls.Add(label1);
            Controls.Add(tbStock);
            Controls.Add(label2);
            Controls.Add(tbPrice);
            Controls.Add(lPrice);
            Controls.Add(tBNameStock);
            Controls.Add(lblName);
            Controls.Add(btnAddStock);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStockForm";
            Text = "AddStockForm";
            Load += AddStockForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBNameStock;
        private Label lblName;
        private Button btnAddStock;
        private TextBox tbPrice;
        private Label lPrice;
        private TextBox tbDescription;
        private Label label1;
        private TextBox tbStock;
        private Label label2;
    }
}