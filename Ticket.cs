using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Premier_Service_Solutions
{
   class Ticket
    {
        private string connectString = Global.connectionString;

        private string status;
        private int ticketID;
        private string typeOfError;
        private string description;
        private DateTime dateOpened;
        private DateTime? dateClosed; // Nullable DateTime
        private string priority;
        private int clientID;

        public string Status { get { return status; } }
        public int TicketID { get { return ticketID; } }
        public string TypeOfError { get { return typeOfError; } }
        public string Description { get { return description; } }
        public DateTime DateOpened { get { return dateOpened; } }
        public DateTime? DateClosed { get { return dateClosed; } }
        public string Priority { get { return priority; } }
        public int ClientID { get { return clientID; } }

        public DataTable GetUnassignedTickets()
        {

        }

    }
}
