using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    internal class TicketClientID
    {
        int ClientID;

        // Default constructor
        public TicketClientID()
        {
        }

        public TicketClientID(int clientID)
        {
            ClientID1 = clientID;
        }

        public int ClientID1 { get => ClientID; set => ClientID = value; }
    }
}
