using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public class ClientData
    {
        public string FirstName { get; }
        public int ContractID { get; }

        public ClientData(string firstName, int contractID)
        {
            FirstName = firstName;
            ContractID = contractID;
        }
    }

}
