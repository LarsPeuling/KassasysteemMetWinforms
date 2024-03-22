using KassasysteemMetWinforms.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KassasysteemMetWinforms.Models;

namespace KassasysteemMetWinforms.Forms
{
    public partial class UpdateStockForm : Form
    {
        Dal dal = new Dal();
        public List<Product> Basket = new List<Product>();
        public UpdateStockForm()
        {
            InitializeComponent();
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvBasket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvStock.DataSource = dal.GetAllProduct();
            lTotalPrice.Text = "0";
        }



        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            //foreach loop  to update product stock in database
            foreach (var product in Basket)
            {
                var newStock = dal.GetStock(Int32.Parse(tbId.Text)) - Int32.Parse(tbStock.Text);
                dal.UpdateProduct(Int32.Parse(tbId.Text), newStock);
            }
            MessageBox.Show("Stock updated");
            var stockform = new StockForm();
            stockform.Show();
            this.Hide();
        }


        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            // Get the id from the textbox
            var id = Int32.Parse(tbId.Text);
            // Get the price from DAL
            var price = dal.GetPrice(id);

            dal.GetProductById(id);

            // Create a new Product with the name, price, and stock, and add it to the Basket
            Basket.Add(dal.GetProductById(id));

            // Calculate the total price
            double totalPrice = Basket.Sum(product => product.Price * Int32.Parse(tbStock.Text));
            lTotalPrice.Text = totalPrice.ToString();

            // Show current items in the basket with product name, price, and stock
            var itemsInBasket = Basket.Select(product => new { Name = product.Name, Price = product.Price, Stock = product.Stock }).ToList();
            dgvBasket.DataSource = itemsInBasket;
        }



        //not used methods
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
