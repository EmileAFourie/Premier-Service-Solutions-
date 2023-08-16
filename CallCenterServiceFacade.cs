using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public class CallCenterServiceFacade
    {
        private CallCenter callCenter;
        private ServiceDepartment serviceDepartment;

        public CallCenterServiceFacade(CallCenter callCenter, ServiceDepartment serviceDepartment)
        {
            this.callCenter = callCenter;
            this.serviceDepartment = serviceDepartment;
        }

        public void CreateServiceRequest()
        {
            callCenter.CreateServiceRequest();
            // Additional logic here...
        }

        public void AssignTechnician()
        {
            serviceDepartment.AssignTechnician();
            // Additional logic here...
        }
    }
}
