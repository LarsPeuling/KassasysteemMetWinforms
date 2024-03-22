using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KassasysteemMetWinforms.DataAccesLayer;
using KassasysteemMetWinforms.Models;

namespace KassasysteemMetWinforms.Forms
{
    public partial class AddStockForm : Form
    {
        Dal dal = new Dal();
        public AddStockForm()
        {

            InitializeComponent();
        }

        private void AddStockForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            string name = tBNameStock.Text;
            Double price = Double.Parse(tbPrice.Text);
            int stock = Int32.Parse(tbStock.Text);
            string description = tbDescription.Text;
            Product product = new Product(name, price, stock, description);
            dal.AddProduct(product);
            MessageBox.Show("Product toegevoegd");
            var stockform = new StockForm();
            stockform.Show();
            this.Close();
        }
    }
}
