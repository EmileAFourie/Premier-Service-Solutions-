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
    public partial class frmEmployeeCenter : Form
    {
        public frmEmployeeCenter()
        {
            InitializeComponent();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            frmNewEmployee newEmployeeForm = new frmNewEmployee();
            this.Hide();
            newEmployeeForm.Show();
            // DialogResult = DialogResult.OK;
            //this.Show();
        }

        private void btnExistingEmployee_Click(object sender, EventArgs e)
        {
            frmExistingEmployee frmExisting = new frmExistingEmployee();
            this.Hide();
            frmExisting.Show();
            //  DialogResult = DialogResult.OK;
            //this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmNavigation Home = new frmNavigation();
            this.Hide();
            Home.Show();
            //DialogResult = DialogResult.OK;
        }

        private void frmEmployeeCenter_Load(object sender, EventArgs e)
        {

        }

      
    }
}
