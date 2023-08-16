using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public class Contract
    {
        public int ContractID { get; set; }
        public string ContractName { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        private string Description { get; set; }
        private double Price { get; set; }
        protected bool Availability { get; set; }
        public int ClientID { get; set; }

        public Contract(int contractID, string contractName, DateTime startDate, DateTime endDate, string description, double price, bool availability, int clientID)
        {
            ContractID = contractID;
            ContractName = contractName;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
            Price = price;
            Availability = availability;
            ClientID = clientID;
        }

        public void ModifyContract(string newName, string newDescription, double newFee)
        {
            // Implementation to modify an existing contract
        }

        public void AddContract(string newName, string newDescription, double newFee)
        {
            // Implementation to add a new contract
        }

        public void ViewActiveContracts()
        {
            // Implementation to view the currently active contracts the client has
        }

        public void RenewContract()
        {
            // Implementation to renew the currently active contract the client has
        }

        public void ViewContract()
        {
            // Implementation to view the details of the available contracts
        }

        public void DeleteContract()
        {
            // Implementation to remove a contract
        }

        public static void ContractAvailability()
        {
            // Implementation to see what contracts are currently being offered
        }
    }

}
