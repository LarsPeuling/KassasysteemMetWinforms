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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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
            this.Close();
        }
    }
}
