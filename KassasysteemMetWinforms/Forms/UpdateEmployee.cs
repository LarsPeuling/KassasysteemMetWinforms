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
    public partial class UpdateEmployee : Form
    {
        Dal dal = new Dal();
        public UpdateEmployee()
        {
            InitializeComponent();
            dgvEmployee.DataSource = dal.GetAllEmployee();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(tbId.Text);
            var name = tbName.Text;
            dal.UpdateEmployee(id, name);
            dgvEmployee.DataSource = dal.GetAllEmployee();
            MessageBox.Show("Updated Employee");
            var employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }
    }
}
