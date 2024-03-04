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

namespace KassasysteemMetWinforms.Forms.Customer
{
    public partial class AddCustomerForm : Form
    {
        public Dal dal = new Dal();
        public AddCustomerForm()
        {
            
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        { 
           //var customer = new CustomerModel(tBName.Text);
            dal.AddCustomer(tBName.Text);
            var customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
