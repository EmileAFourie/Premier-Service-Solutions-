using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Premier_Service_Solutions
{
   class Ticket
    {
        private string connectionString = Global.connectionString;
        SqlConnection cnn;


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
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlDataAdapter data = new SqlDataAdapter($@"SELECT Ticket.TicketID, Ticket.Description, Ticket.Priority FROM Ticket LEFT JOIN EmployeeTickets ON Ticket.TicketID = EmployeeTickets.TicketID WHERE EmployeeTickets.TicketID IS NULL", cnn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            cnn.Close();
            return dt;
        }

        public DataTable GetSpecficUnassignedTicket(int TicketID)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlDataAdapter data = new SqlDataAdapter($@"SELECT Ticket.TicketID, Ticket.Description, Ticket.Priority FROM Ticket LEFT JOIN EmployeeTickets ON Ticket.TicketID = EmployeeTickets.TicketID WHERE EmployeeTickets.TicketID IS NULL AND Ticket.TicketID = {TicketID}", cnn);
            DataTable dt = new DataTable();

            data.Fill(dt);

            cnn.Close();
            return dt;
        }

        public DataTable GetSpecficAssignedTicket(int TicketID)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlDataAdapter data = new SqlDataAdapter($@"SELECT EmployeeTickets.EmployeeID, Ticket.TicketID, Ticket.Description, Ticket.Priority FROM Ticket LEFT JOIN EmployeeTickets ON Ticket.TicketID = EmployeeTickets.TicketID WHERE EmployeeTickets.TicketID IS NOT NULL AND Ticket.TicketID = {TicketID} AND EmployeeTickets.CurrentlyWorkingOn = 1", cnn);
            DataTable dt = new DataTable();

            data.Fill(dt);

            cnn.Close();
            return dt;
        }

    }
}
