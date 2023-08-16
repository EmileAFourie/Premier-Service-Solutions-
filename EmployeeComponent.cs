using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public interface EmployeeComponent
    {
        void Add(EmployeeComponent employee);
        void Remove(EmployeeComponent employee);
        EmployeeComponent GetChild(int i);
    }
}
