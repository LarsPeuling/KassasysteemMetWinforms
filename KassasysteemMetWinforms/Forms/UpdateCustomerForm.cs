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
    public partial class UpdateCustomerForm : Form
    {
        Dal dal = new Dal();
        public UpdateCustomerForm()
        {
            InitializeComponent();
            dgvCustomer.DataSource = dal.GetAllCustomers();

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(tbId.Text);
            var name = tbName.Text;
            dal.UpdateCustomer(id, name);
            dgvCustomer.DataSource = dal.GetAllCustomers();
            MessageBox.Show("Customer updated");
            var customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
