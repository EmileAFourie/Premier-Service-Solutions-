using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    // Defines behavior for leaf objects in the composition.
    public class EmployeeLeaf : EmployeeComponent
    {
        public void Add(EmployeeComponent employee)
        {
            throw new Exception("Cannot add to a leaf.");
        }

        public void Remove(EmployeeComponent employee)
        {
            throw new Exception("Cannot remove from a leaf.");
        }

        public EmployeeComponent GetChild(int i)
        {
            throw new Exception("Leaf does not have children.");
        }
    }
}
