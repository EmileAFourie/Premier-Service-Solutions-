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
    public partial class frmAvailableContracts : Form
    {
        public frmAvailableContracts()
        {
            InitializeComponent();
        }

        private void btnEditSaver_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmContracts back = new frmContracts();
            this.Hide();
            back.Show();
        }

        private void btnEditBasic_Click(object sender, EventArgs e)
        {
            frmEditbasic frmEditbasicfrm = new frmEditbasic();
            this.Hide();
            frmEditbasicfrm.Show();
        }

        private void btnEditSaver_Click_1(object sender, EventArgs e)
        {
            frmEditSaver frmEditsaverfrm = new frmEditSaver();
            this.Hide();
            frmEditsaverfrm.Show();
        }

        private void btnEditExtra_Click(object sender, EventArgs e)
        {
            frmEditPremium frmEditPremiumfrm = new frmEditPremium();
            this.Hide();
            frmEditPremiumfrm.Show();
        }
    }
}
