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
            MessageBox.Show("New Employee created", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxEmployeeID.Clear();
            txtbxName.Clear();
            txtbxEmail.Clear();
            txtbxPosition.Clear();
            txtbxAge.Clear();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmEmployeeCenter EmployeeCentre = new frmEmployeeCenter();
            this.Hide();
            EmployeeCentre.Show();
           
        }
    }
}
