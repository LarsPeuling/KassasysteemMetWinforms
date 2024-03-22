using KassasysteemMetWinforms.DataAccesLayer;
using KassasysteemMetWinforms.Forms.Customer;
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
        public Dal dal = new Dal();
        public CustomerForm()
        {
            InitializeComponent();
            dgvCustomer.DataSource = dal.GetAllCustomers();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var stockForm = new StockForm();
            stockForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
            this.Hide();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            var updateCustomerForm = new UpdateCustomerForm();
            updateCustomerForm.Show();
            this.Hide();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(tbId.Text);
            dal.DeleteCustomer(id);
            dgvCustomer.DataSource = dal.GetAllCustomers();
        }
    }
}
