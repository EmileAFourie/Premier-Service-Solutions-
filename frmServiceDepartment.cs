﻿using System;
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
    public partial class frmServiceDepartment : Form
    {
        int UnassignedTicketID = -1;
        int AssignedTicketID = -1;

        public frmServiceDepartment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmNavigation back = new frmNavigation();
            back.Show();
            this.Hide();
        }

        private void btnAssignTicket_Click(object sender, EventArgs e)
        {
            //wilioService twilioService = new TwilioService();
            // twilioService.SendTicketNotification("+27763237618", "12345", "Install new HVAC system");
        }

        private void frmServiceDepartment_Load(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();

            DataTable dt = ticket.GetUnassignedTickets();
            DataTable dt2 = ticket.GetAssignedTickets();

            dataGridView2.DataSource = dt2;
            dataGridView1.DataSource = dt;

            UnassignedTicketID = DataGridViewGetTicketID(dataGridView1.Rows[0]);
            AssignedTicketID = DataGridViewGetTicketID(dataGridView2.Rows[0]);

            lblAssigned.Text = "Selected Assigned Ticket ID: " + AssignedTicketID.ToString();
            lblUnassigned.Text = "Selected Unassigned Ticket ID: " + UnassignedTicketID.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {
            try
            {
                int ticketID = int.Parse(txtbxSearchTicket.Text);

                Ticket ticket = new Ticket();

                DataTable dt = ticket.GetSpecficUnassignedTicket(ticketID);
                DataTable dt2 = ticket.GetSpecficAssignedTicket(ticketID);

                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            UnassignedTicketID = DataGridViewGetTicketID(row);
            lblUnassigned.Text = "Selected Unassigned Ticket ID: " + UnassignedTicketID.ToString();
            //MessageBox.Show(UnassignedTicketID.ToString());
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

            AssignedTicketID = DataGridViewGetTicketID(row);
            lblAssigned.Text = "Selected Assigned Ticket ID: " + AssignedTicketID.ToString();
        }
        private int DataGridViewGetTicketID(DataGridViewRow row)
        {
            if (row.Cells[0].Value.ToString() != "")
            {
                return int.Parse(row.Cells[0].Value.ToString());
            }
            else
            {
                return -1;
            }
        }
    }
}
