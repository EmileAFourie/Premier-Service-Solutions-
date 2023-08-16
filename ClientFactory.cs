using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public abstract class ClientFactory
    {
        public abstract ClientDetail CreateClient();
    }
}
