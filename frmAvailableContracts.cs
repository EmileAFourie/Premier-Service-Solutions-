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
            frmEditSaver editsaver = new frmEditSaver();
            this.Close();
            editsaver.Show();
        }

        private void btnEditBasic_Click(object sender, EventArgs e)
        {
            frmEditbasic editBasic = new frmEditbasic();
            this.Close();
            editBasic.Show();
        }

        private void btnEditExtra_Click(object sender, EventArgs e)
        {
            frmEditPremium frmEditPremium = new frmEditPremium();
            this.Close();
            frmEditPremium.Show();

        }
    }
}
