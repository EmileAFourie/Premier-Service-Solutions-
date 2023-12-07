using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public class CallCenter : ClientDetail, Observer
    {
        private DateTime timeStamp;
        private string cellNo;
        private bool isNew;
        private int ticketID;

        public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
        public string CellNo { get => cellNo; set => cellNo = value; }
        public bool IsNew { get => isNew; set => isNew = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }

        public CallCenter(DateTime timeStamp, string cellNo, bool isNew, int ticketID, int clientID, string name, string address, string email, string clientType, int contractId)
            : base(clientID, name, address, cellNo, email, clientType, contractId)
        {
            this.TimeStamp = timeStamp;
            this.CellNo = cellNo;
            this.IsNew = isNew;
            this.TicketID = ticketID;
        }

        public void AnswerCall(string cellNo, bool isNew)
        {
            // Implementation to start logging a call from a client
        }

        private void EndCall()
        {
            // Implementation to stop logging a call from a client
        }

        public void GetPreviousRequest(bool isNew)
        {
            // Implementation to retrieve the previous ticket logged by a client
        }

        public void CreateTicket(string issueDescription)
        {
            // Implementation to create a new ticket for a client
        }

        public new ClientDetail GetClientDetails()
        {
            // Implementation to obtain the client details
            return this;
        }

        public void CreateNewClient()
        {
            // Create a new client
        }

        // Observer Pattern Implementation
        public void Update()
        {
            // Implementation to update the CallCenter when a ticket state changes
        }
    }

}
