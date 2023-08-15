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
    public partial class frmTicketManagement : Form
    {
        private DataHandler dataHandler;
        public frmTicketManagement()
        {
            InitializeComponent();
            dataHandler = new DataHandler();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string TypeOfError = txtbxTypeOfError.Text;
            string Description = txtbxDescription.Text;
            DateTime DateOpened = DateTime.Now;
            string Priority = txtbxPriority.Text;
            string Status = "Unnassigned";
            int ClientID = int.Parse(txtbxClientID.Text); 

            dataHandler.LogTicket(TypeOfError, Description, DateOpened, Priority, Status, ClientID);

            MessageBox.Show("Ticket added", "Ticket Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void grpbxNewTicket_Enter(object sender, EventArgs e)
        {

        }
    }
}
