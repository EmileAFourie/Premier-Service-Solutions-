using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmExistingEmployeeDetails : Form
    {
        public frmExistingEmployeeDetails()
        {
            InitializeComponent();
        }

        public int EmployeeID;
        //Employee employee;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string firstName = txtbxName.Text;
            string surname = txtSurname.Text;
            string email = txtbxEmail.Text;
            string cellNo = txtCell.Text;
            string postition = txtbxPosition.Text;
            string department = txtbxDepartment.Text;
            string field = txtField.Text;

            Employee employee = new Employee(EmployeeID, firstName, surname, email, cellNo, postition, department, field);

            try
            {
                employee.UpdateEmployee();
                MessageBox.Show("Employee Details updated.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Employee Details could not be updated.");
            }
        }

        private void frmExistingEmployeeDetails_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.FindEmployee(EmployeeID);


            txtbxEmployeeID.Text = EmployeeID.ToString();
            txtbxName.Text = employee.FirstName;
            txtSurname.Text = employee.Surname;
            txtbxEmail.Text = employee.Email;
            txtCell.Text = employee.CellNo;
            txtbxPosition.Text = employee.Postion;
            txtbxDepartment.Text = employee.Department;
            txtField.Text = employee.Field;

            DataTable dt = employee.GetEmployeeTickets();

            dataGridView1.DataSource = dt;

            Ticket ticket = new Ticket();

            dataGridView1.DataSource = ticket.GetAssignedTicketsForEmployee(EmployeeID);

        }

        private void lblPerformance_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            try
            {
                employee.RemoveEmployee(EmployeeID);
                MessageBox.Show("Employee has be deleted.");

                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Employee could not be deleted.");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
