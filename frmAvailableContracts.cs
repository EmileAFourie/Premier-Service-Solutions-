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
            frmEditSaver EditSaver = new frmEditSaver();
            this.Close();
            EditSaver.Show();
        }

        private void btnEditBasic_Click(object sender, EventArgs e)
        {

        }

        private void btnEditExtra_Click(object sender, EventArgs e)
        {

        }
    }
}
