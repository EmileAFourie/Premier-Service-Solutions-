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
        private int clientID;
        private TicketManagement ticketManagement = new TicketManagement();



        public frmTicketManagement()
        {
            InitializeComponent();
            clientID = Global.ClientID;
            LoadDataToDataGridView();
        }



        private void frmTicketManagement_Load(object sender, EventArgs e)
        {
            int clientID = Global.ClientID;
            txtbxClientID.Text = clientID.ToString();
            LoadDataToDataGridView();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string typeOfError = txtbxTypeOfError.Text;
                string description = txtbxDescription.Text;
                DateTime dateOpened = DateTime.Now;
                string priority = txtbxPriority.Text;
                const string status = "Unassigned";



                if (!int.TryParse(txtbxClientID.Text, out clientID))
                {
                    MessageBox.Show("Invalid Client ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                ticketManagement.LogTicket(typeOfError, description, dateOpened, priority, status, clientID);
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
            dgvPreviousTickets.DataSource = ticketManagement.GetTickets(clientID);
        }



        private void btnEndCall_Click(object sender, EventArgs e)
        {
            txtbxCallDuration.Text = ticketManagement.GetCurrentFormattedDatetime();
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
                if (selectedTicketID < 0)
                {
                    MessageBox.Show("Please select a ticket to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                string newTypeOfError = txtbxTypeOfError.Text;
                string newDescription = txtbxDescription.Text;
                string newPriority = txtbxPriority.Text;



                ticketManagement.UpdateTicket(selectedTicketID, newTypeOfError, newDescription, newPriority);
                LoadDataToDataGridView();
                MessageBox.Show("Ticket updated", "Ticket Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPreviousTickets.SelectedRows.Count > 0)
            {
                int ticketID = Convert.ToInt32(dgvPreviousTickets.SelectedRows[0].Cells[0].Value);
                ticketManagement.DeleteTicket(ticketID);
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a ticket to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grpbxNewTicket_Enter(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmNavigation Home = new frmNavigation();
            this.Hide();
            Home.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmPremierServiceSolutionsLogin Logout = new frmPremierServiceSolutionsLogin();
            this.Hide();
            Logout.Show();
            MessageBox.Show("You have been logged out!");
        }

       
    }
}

