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
    public partial class EmployeeForm : Form
    {
        Dal dal = new Dal();
        public EmployeeForm()
        {
            InitializeComponent();
            dgvEmployee.DataSource = dal.GetAllEmployee();
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
            this.Show();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(tbEmployeeIdDelete.Text);
            dal.DeleteEmployee(id);
            MessageBox.Show("Employee Deleted");
            dgvEmployee.DataSource = dal.GetAllEmployee();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            var updateEmployeeForm = new UpdateEmployee();
            updateEmployeeForm.Show();
            this.Hide();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var addEmployeeForm = new AddEmployee();
            addEmployeeForm.Show();
            this.Hide();
        }
    }
}
