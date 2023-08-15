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
    public partial class frmExistingClientSearch : Form
    {
        public frmExistingClientSearch()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxClientID.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtbxClientID.Text);

            TicketClientID ClientID = new TicketClientID();

            ClientID.ClientID1 = ID;

            frmTicketManagement Ticket = new frmTicketManagement();
            Ticket.Show();

            this.Hide();
        }
    }
}
