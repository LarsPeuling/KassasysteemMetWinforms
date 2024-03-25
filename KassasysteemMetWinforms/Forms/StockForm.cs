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

namespace KassasysteemMetWinforms.Forms
{
    public partial class StockForm : Form
    {
        Dal dal = new Dal();
        public StockForm()
        {
            InitializeComponent();
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvStock.DataSource = dal.GetAllProduct();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var stockform = new StockForm();
            stockform.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var customerform = new CustomerForm();
            customerform.Show();
            this.Hide();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            var stockform = new AddStockForm();
            stockform.Show();
            this.Hide();
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbStockIdDelete.Text);
            dal.DeleteProduct(id);
            MessageBox.Show("Product verwijderd");
            dgvStock.DataSource = dal.GetAllProduct();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            var updateStockForm = new UpdateStockForm();
            updateStockForm.Show();
            this.Hide();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
