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
<<<<<<< HEAD

        private void btn_Click(object sender, EventArgs e)
        {
            frmContracts Contracts = new frmContracts();
            Contracts.Show();
            this.Hide();
=======
        

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
>>>>>>> parent of 0d3feb7 (Merge branch 'master' into Andre_Johan_2)
        }
    }
}
