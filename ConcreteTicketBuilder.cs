using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public class ConcreteTicketBuilder : TicketBuilder
    {
        private TicketManagementAndTracking ticket = new TicketManagementAndTracking(/* parameters */);

        public override void SetClientID(int clientID) => ticket.ClientID = clientID;
        public override void SetTypeOfErr(string typeOfErr) => ticket.TypeOfErr = typeOfErr;
        public override void SetDescription(string description) => ticket.Description = description;
        public override void SetDateOpened(DateTime dateOpened) => ticket.DateOpened = dateOpened;
        public override void SetPriority(string priority) => ticket.Priority = priority;

        public override TicketManagementAndTracking Build() => ticket;
    }
}
