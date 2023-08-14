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
    public partial class frmClientDetails : Form
    {
        public frmClientDetails()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbxClientTypeNewClient.SelectedIndex = -1;
            txtbxClientIDNewClient.Clear();
            txtbxNameNewClient.Clear();
            txtbxAddressNewClient.Clear();
            txtbxCellNumberNewClient.Clear();
            txtbxEmailNewClient.Clear();
            cmbxContractNewClient.SelectedIndex = -1;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmTicketManagement NewTicket = new frmTicketManagement();
            NewTicket.Show();
            this.Hide();
        }
    }
}
