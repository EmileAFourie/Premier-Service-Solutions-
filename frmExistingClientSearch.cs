using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.TwiML.Voice;


namespace Premier_Service_Solutions
{
    public partial class frmExistingClientSearch : Form
    {

        string connect = Global.connectionString;
        // Ensure proper initialization and implementation
        private DataHandler dataHandler;

        public frmExistingClientSearch()
        {
            InitializeComponent();
            dataHandler = new DataHandler();
        }

        private void PopulateClientIDs()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    string query = "SELECT ClientID FROM IndividualClient";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbClientID.Items.Add(reader.GetInt32(0).ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbClientID.SelectedItem != null && int.TryParse(cmbClientID.SelectedItem.ToString(), out int clientID))
            {
                Global.ClientID = clientID; // Set the ClientID in the Global class

                frmTicketManagement ticketManagementForm = new frmTicketManagement(); // No need to pass clientID
                ticketManagementForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a valid Client ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*private void btnSearch_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtbxClientID.Text);

            frmTicketManagement Ticket = new frmTicketManagement(ID);
            Ticket.Show();

            this.Hide();
        }*/

        private void frmExistingClientSearch_Load(object sender, EventArgs e)
        {
            PopulateClientIDs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerType back = new frmCustomerType();
            this.Close();
            back.Show();
        }
    }
}
