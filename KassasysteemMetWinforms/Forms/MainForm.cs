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

namespace KassasysteemMetWinforms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Dal dal = new Dal();
            dgvCriticalStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCriticalStock.DataSource = dal.GetCriticalProduct();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var productfrom = new EmployeeForm();
            productfrom.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var stockfrom = new StockForm();
            stockfrom.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var customerfrom = new CustomerForm();
            customerfrom.Show();
            this.Hide();
        }

        private void dgvCriticalStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
