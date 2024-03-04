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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();
            customerForm.Show();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var stockForm = new StockForm();
            stockForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
