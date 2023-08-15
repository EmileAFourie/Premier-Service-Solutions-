using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Premier_Service_Solutions
{
    public partial class frmClientDetails : Form
    {
        private DataHandler dataHandler;
        public frmClientDetails()
        {
            InitializeComponent();
            dataHandler = new DataHandler();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtbxClientIDNewClient.Clear();
            txtbxFirstName.Clear();
            txtbxLastname.Clear();
            txtbxAddressNewClient.Clear();
            txtbxCellNumberNewClient.Clear();
            txtbxEmailNewClient.Clear();
            cmbxContractNewClient.SelectedIndex = -1;
            txtbxCompanyID.Clear();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int clientID = 0;
            if (int.TryParse(txtbxClientIDNewClient.Text, out clientID))
            {
                string firstname = txtbxFirstName.Text;
                string lastname = txtbxLastname.Text;
                string address = txtbxAddressNewClient.Text;
                string cellNumber = txtbxCellNumberNewClient.Text;
                string email = txtbxEmailNewClient.Text;
                string contract = cmbxContractNewClient.SelectedItem?.ToString();
                int companyID = 0;
                if (int.TryParse(txtbxCompanyID.Text, out companyID))
                {
                    dataHandler.ClientIWriteToDB(clientID, firstname, lastname, address, cellNumber, email, Convert.ToInt32(contract), companyID);

                    frmTicketManagement newTicket = new frmTicketManagement();
                    newTicket.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Company ID. Please enter a valid integer.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Client ID. Please enter a valid integer.");
            }
        }

    }
}
