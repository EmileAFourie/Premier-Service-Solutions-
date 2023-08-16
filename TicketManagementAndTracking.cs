using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Premier_Service_Solutions
{
    public class TicketManagementAndTracking : ClientDetail
    {
        // Represents the internal state of the ticket, which,
        // when changed, will notify all observers.
        private State _state;
        private List<Observer> observers = new List<Observer>();


        private int clientID;
        private string typeOfErr;
        private string description;
        private DateTime dateOpened;
        private DateTime dateClosed;
        private string priority;
        private string status;
        private int ticketID;

        public int ClientID { get => clientID; set => clientID = value; }
        public string TypeOfErr { get => typeOfErr; set => typeOfErr = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DateOpened { get => dateOpened; set => dateOpened = value; }
        public DateTime DateClosed { get => dateClosed; set => dateClosed = value; }
        public string Priority { get => priority; set => priority = value; }
        public string Status { get => status; set => status = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }

        public TicketManagementAndTracking(int clientID, string typeOfErr, string description, DateTime dateOpened, DateTime dateClosed, string priority, string status, int ticketID)
            : base(clientID, "", "", "", "", "", 0) // Call to base constructor
        {
            this.clientID = clientID;
            this.typeOfErr = typeOfErr;
            this.description = description;
            this.dateOpened = dateOpened;
            this.dateClosed = dateClosed;
            this.priority = priority;
            this.status = status;
            this.ticketID = ticketID;
        }

        public void LogTicket(int clientID, string typeOfErr, string description, DateTime dateOpened, string priority)
        {
            // Log a new ticket with provided details.
        }

        public void AssignTicketToEmployee(int ticketID, int employeeID)
        {
            // Assign a ticket to an employee with the given ticketID and employeeID.
        }

        public void UpdateTicketStatus(int ticketID, string status)
        {
            // Update the status of a ticket with the given ticketID.
        }

        public TicketManagementAndTracking GetTicket(int ticketID)
        {
            // Get the ticket with the given ticketID.
            return this;
        }

        public List<TicketManagementAndTracking> GetAllOpenTickets()
        {
            // Get a list of all open tickets.
            return new List<TicketManagementAndTracking>();
        }

        public List<TicketManagementAndTracking> GetAssignedTickets(int employeeID)
        {
            // Get a list of tickets assigned to the employee with the given employeeID.
            return new List<TicketManagementAndTracking>();
        }

        public void ManagePriority(int ticketID, string priority)
        {
            // Manage the priority of a ticket with the given ticketID.
        }

        public TicketManagementAndTracking FindTicketByID(int ticketID)
        {
            // Find the ticket with the given ticketID and return the ticket object.
            return this;
        }
        //Observer Methods for TicketManagement Subject
        // Attaches an observer to the subject.
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        // Detaches an observer from the subject.
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        // Notifies all attached observers of a state change.
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }


        //State Implementations 
        public State TicketState
        {
            get => _state;
            set
            {
                _state = value;
                // This will notify observers of a state change
                NotifyObservers();
                // This will handle the internal logic of the current state
                _state.Handle(this);
            }
        }
        //Builder Pattern Code
        public void ConstructTicket(TicketBuilder builder)
        {
            builder.SetClientID(ClientID);
            builder.SetTypeOfErr(TypeOfErr);
            builder.SetDescription(Description);
            builder.SetDateOpened(DateOpened);
            builder.SetPriority(Priority);
        }
    }

}
