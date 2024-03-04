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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
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

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
