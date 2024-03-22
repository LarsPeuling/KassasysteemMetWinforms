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

namespace KassasysteemMetWinforms.Forms
{
    public partial class AddEmployee : Form
    {
        Dal dal = new Dal();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var name = tBName.Text;
            dal.AddEmployee(name);
            MessageBox.Show("Employee Added");
            var employeeForm = new EmployeeForm();  
            employeeForm.Show();
            this.Hide();
        }
    }
}
