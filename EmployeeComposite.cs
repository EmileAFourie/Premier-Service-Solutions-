using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public class EmployeeComposite : EmployeeComponent
    {
        private List<EmployeeComponent> employees = new List<EmployeeComponent>();

        public void Add(EmployeeComponent employee)
        {
            employees.Add(employee);
        }

        public void Remove(EmployeeComponent employee)
        {
            employees.Remove(employee);
        }

        public EmployeeComponent GetChild(int i)
        {
            return employees[i];
        }
    }
}
