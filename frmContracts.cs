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
    public partial class frmContracts : Form
    {
        public frmContracts()
        {
            InitializeComponent();
        }

        private void btnEditContracts_Click(object sender, EventArgs e)
        {
            frmAvailableContracts AvailableContractsForm = new frmAvailableContracts();
            this.Close();
            AvailableContractsForm.Show();
        }

        private void btnViewContractPerformance_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmNavigation back = new frmNavigation();
            back.Show();
            this.Hide();
        }
    }
}
