using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    // Defines an updating interface for objects that should be notified of changes in
    // a subject.
    public interface Observer
    {
        void Update();
    }
}
