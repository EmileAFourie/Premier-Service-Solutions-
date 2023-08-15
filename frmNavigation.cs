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
    public partial class frmNavigation : Form
    {
        public frmNavigation()
        {
            InitializeComponent();
        }

        private void btnCallCentre_Click_1(object sender, EventArgs e)
        {
            frmCallCentre callCenterForm = new frmCallCentre();
            this.Close();
            callCenterForm.Show();
        }

        private void btnServiceDepartment_Click_1(object sender, EventArgs e)
        {
            frmServiceDepartment serviceDepartmentForm = new frmServiceDepartment();
            this.Close();
            serviceDepartmentForm.Show();
        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            frmEmployeeCenter employeesForm = new frmEmployeeCenter();
            this.Hide();
            employeesForm.ShowDialog();
            this.Show();
        }

        private void btnContracts_Click_1(object sender, EventArgs e)
        {
            frmContracts contractsForm = new frmContracts();
            this.Close();
            contractsForm.Show();
        }
    }
}
