using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premier_Service_Solutions
{
    public partial class frmNewEmployee : Form
    {
        public frmNewEmployee()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string firstName = txtbxName.Text;
            string surname = txtSurname.Text;
            string email = txtbxEmail.Text;
            string cellNo = txtCell.Text;
            string postition = txtbxPosition.Text;
            string department = txtbxDepartment.Text;
            string field = txtField.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;

            Employee employee = new Employee(firstName,surname, email, cellNo,postition, department, field, user, password);

            try
            {
                employee.InsertEmployee();

                MessageBox.Show("Employee has been created.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured.");

            }
        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}

