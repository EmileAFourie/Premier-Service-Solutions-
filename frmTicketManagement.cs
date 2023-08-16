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
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Premier_Service_Solutions
{
    public partial class frmTicketManagement : Form
    {
        private int selectedTicketID = -1;

        string connect = Global.connectionString;
        private DataHandler dataHandler;

       

        public frmTicketManagement() // No parameter needed
        {
            InitializeComponent();
            clientID = Global.ClientID; // Retrieve the ClientID from the Global class
            LoadDataToDataGridView();
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
            try
            {
                // Retrieve data from UI controls
                string typeOfError = txtbxTypeOfError.Text;
                string description = txtbxDescription.Text;
                DateTime dateOpened = DateTime.Now;
                string priority = txtbxPriority.Text;
                const string status = "Unassigned";

                // Validate and parse ClientID
                if (!int.TryParse(txtbxClientID.Text, out int clientID))
                {
                    MessageBox.Show("Invalid Client ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Initialize DataHandler and Log Ticket
                dataHandler = new DataHandler();
                dataHandler.LogTicket(typeOfError, description, dateOpened, priority, status, clientID);

                // Refresh the DataGridView
                LoadDataToDataGridView();

                MessageBox.Show("Ticket added", "Ticket Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadDataToDataGridView()
        {
            // Use the member variable for ClientID
            
            using (SqlConnection con = new SqlConnection(connect))
            {
                // Use parameters to avoid SQL injection
                string query = "Select * from Ticket Where ClientID = @ClientID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@ClientID", clientID);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPreviousTickets.DataSource = dt;
            }
        }


        private void grpbxNewTicket_Enter(object sender, EventArgs e)
        {

        }


        /* private void dgvPreviousTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             {

                 if (dgvPreviousTickets.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)

                 {

                     //string name = dgvPreviousTickets.Rows[e.RowIndex].Cells["ClientID"].FormattedValue.ToString();

                     string typeoferror = dgvPreviousTickets.Rows[e.RowIndex].Cells["TypeOfError"].FormattedValue.ToString();

                     string description = dgvPreviousTickets.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();

                     string priority = dgvPreviousTickets.Rows[e.RowIndex].Cells["Priority"].FormattedValue.ToString();

                     //string gender = dgvPreviousTickets.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();



                     txtbxTypeOfError.Text = typeoferror;

                     txtbxDescription.Text = description;

                     txtbxPriority.Text = priority;




                 }

             }


         }*/

        // Declare a member variable to store ClientID
        private int clientID;

        public frmTicketManagement(int ClientID)
        {
            InitializeComponent();

            // Store the passed ClientID
            this.clientID = ClientID;
        }

        private void frmTicketManagement_Load(object sender, EventArgs e)
        {

            txtbxClient.Text = clientID.ToString();

            txtbxClientID.Text = clientID.ToString();

            LoadDataToDataGridView();

        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {

 
            DateTime currentDatetime = DateTime.Now;

            string formattedDatetime = currentDatetime.ToString("yyyy-MM-dd HH:mm:ss");

            txtbxCallDuration.Text = formattedDatetime;

        }

        private void dgvPreviousTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if a valid row is selected
                if (e.RowIndex >= 0 && e.RowIndex < dgvPreviousTickets.Rows.Count)
                {
                    // Retrieve the TicketID and ensure it's not null or empty
                    object ticketIDValue = dgvPreviousTickets.Rows[e.RowIndex].Cells["TicketID"].Value;
                    if (ticketIDValue == null || ticketIDValue == DBNull.Value)
                    {
                        MessageBox.Show("Invalid or unpopulated record selected. Please select a valid ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    selectedTicketID = Convert.ToInt32(ticketIDValue);
                    txtbxTypeOfError.Text = dgvPreviousTickets.Rows[e.RowIndex].Cells["TypeOfError"].FormattedValue.ToString();
                    txtbxDescription.Text = dgvPreviousTickets.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
                    txtbxPriority.Text = dgvPreviousTickets.Rows[e.RowIndex].Cells["Priority"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a record is selected
                if (selectedTicketID < 0)
                {
                    MessageBox.Show("Please select a ticket to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

 

                // Gather new data from text boxes
                string newTypeOfError = txtbxTypeOfError.Text;
                string newDescription = txtbxDescription.Text;
                string newPriority = txtbxPriority.Text;

                // Update the database
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();

                    // Use parameters to avoid SQL injection
                    string query = @"UPDATE Ticket 
                             SET TypeOfError = @TypeOfError, Description = @Description, Priority = @Priority 
                             WHERE TicketID = @TicketID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TypeOfError", newTypeOfError);
                        cmd.Parameters.AddWithValue("@Description", newDescription);
                        cmd.Parameters.AddWithValue("@Priority", newPriority);
                        cmd.Parameters.AddWithValue("@TicketID", selectedTicketID);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView
                LoadDataToDataGridView();

                MessageBox.Show("Ticket updated", "Ticket Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dgvPreviousTickets.SelectedRows.Count > 0)
            {
                // Get the TicketID of the selected row
                int ticketID = Convert.ToInt32(dgvPreviousTickets.SelectedRows[0].Cells[0].Value);

                // Create the database connection and command
                string connect = @"Data source = (local); Initial Catalog=PremierServiceSolutions; Integrated Security= SSPI";
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();

                    // Use parameterized query to avoid SQL injection
                    string query = "DELETE FROM Ticket WHERE TicketID = @TicketID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TicketID", ticketID);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView to reflect the changes
                LoadDataToDataGridView(); 
            }
            else
            {
                MessageBox.Show("Please select a ticket to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmExistingClientSearch Back = new frmExistingClientSearch();
            this.Hide();
            Back.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxClientID.Clear();
            txtbxDescription.Clear();
            txtbxPriority.Clear();  
            txtbxTypeOfError.Clear();

        }
    }
    }

