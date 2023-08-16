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
            
            
            txtbxFirstName.Clear();
            txtbxLastname.Clear();
            txtbxAddressNewClient.Clear();
            txtbxCellNumberNewClient.Clear();
            txtbxEmailNewClient.Clear();
            cmbxContractNewClient.SelectedIndex = -1;
           

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstname = txtbxFirstName.Text;
            string lastname = txtbxLastname.Text;
            string address = txtbxAddressNewClient.Text;
            string cellNumber = txtbxCellNumberNewClient.Text;
            string email = txtbxEmailNewClient.Text;
            string contract = cmbxContractNewClient.SelectedItem?.ToString();

            dataHandler.ClientIWriteToDB(firstname, lastname, address, cellNumber, email, Convert.ToInt32(contract));

            frmTicketManagement newTicket = new frmTicketManagement();
            newTicket.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerType back = new frmCustomerType();
            this.Hide();
            back.Show();
        }
    }
}
