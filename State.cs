using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    // Defines an interface for encapsulating the behavior associated with a
    // particular state of the Context.
    public interface State
    {
        void Handle(TicketManagementAndTracking context);
    }
}
