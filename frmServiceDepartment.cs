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

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignTicket_Click(object sender, EventArgs e)
        {
            TwilioService twilioService = new TwilioService();
            twilioService.SendTicketNotification("+27763237618", "12345", "Install new HVAC system");
        }
    }
}
