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
        string connect = Global.connectionString;

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

            // Use the member variable here
            //string connect = @"Data source = (local); Initial Catalog=PremierServiceSolutions; Integrated Security= SSPI";
            SqlConnection con = new SqlConnection(connect);

            // Use parameters to avoid SQL injection
            string query = "Select * from Ticket Where ClientID = @ClientID";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ClientID", clientID);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPreviousTickets.DataSource = dt;
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {

        }

        private void dgvPreviousTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                if (dgvPreviousTickets.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)

                {

                    string typeoferror = dgvPreviousTickets.Rows[e.RowIndex].Cells["TypeOfError"].FormattedValue.ToString();

                    string description = dgvPreviousTickets.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();

                    string priority = dgvPreviousTickets.Rows[e.RowIndex].Cells["Priority"].FormattedValue.ToString();


                    txtbxTypeOfError.Text = typeoferror;

                    txtbxDescription.Text = description;

                    txtbxPriority.Text = priority;

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dgvPreviousTickets.SelectedRows.Count > 0)
            {
                // Get the TicketID of the selected row
                int ticketID = Convert.ToInt32(dgvPreviousTickets.SelectedRows[0].Cells[0].Value);

                // Create the database connection and command
               // string connect = @"Data source = (local); Initial Catalog=PremierServiceSolutions; Integrated Security= SSPI";
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
                LoadDataToDataGridView();  // Assuming you have a method to load data to the DGV
            }
            else
            {
                MessageBox.Show("Please select a ticket to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

