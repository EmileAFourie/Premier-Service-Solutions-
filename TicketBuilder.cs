using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public abstract class TicketBuilder
    {
        public abstract void SetClientID(int clientID);
        public abstract void SetTypeOfErr(string typeOfErr);
        public abstract void SetDescription(string description);
        public abstract void SetDateOpened(DateTime dateOpened);
        public abstract void SetPriority(string priority);
        public abstract TicketManagementAndTracking Build();
    }
}
