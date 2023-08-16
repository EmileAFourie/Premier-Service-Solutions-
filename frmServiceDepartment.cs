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
    public partial class frmServiceDepartment : Form
    {
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
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchTicket_Click_1(object sender, EventArgs e)
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
    }
}
