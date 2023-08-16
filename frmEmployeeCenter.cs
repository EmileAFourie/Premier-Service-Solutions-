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
            this.Close();
            newEmployeeForm.ShowDialog();
           // DialogResult = DialogResult.OK;
        }

        private void btnExistingEmployee_Click(object sender, EventArgs e)
        {
            frmExistingEmployee frmExisting = new frmExistingEmployee();

            this.Close();
            frmExisting.ShowDialog();
          //  DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmNavigation back = new frmNavigation();
            this.Hide();
            back.Show();
            
        }
    }
}
