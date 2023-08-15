using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        public string ClientFirstName
        {
            get { return txtbxClient.Text; }
            set { txtbxClient.Text = value; }
        }

        public int ClientContractID
        {
            get { return int.Parse(txtbxContract.Text); }
            set { txtbxContract.Text = value.ToString(); }
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

        private void dgvPreviousTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTicketManagement_Load(object sender, EventArgs e)
        {
            TicketClientID ClientID = new TicketClientID();

            string connect = @"Data source = (local) ; Initial Catalog=PremierServiceSolutions ; Integrated Security= SSPI";
            SqlConnection con = new SqlConnection(connect);
            string query = @"Select * from Ticket Where ClientID = ('" + ClientID.ClientID1 + "')";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPreviousTickets.DataSource = dt;
        }
    }
}
