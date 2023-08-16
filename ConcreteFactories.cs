using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public class ConcreteFactories : ClientFactory
    {
        public override ClientDetail CreateClient()
        {
            return new ClientDetail(/* parameters for individual client */);
        }
    }

    public class BusinessClientFactory : ClientFactory
    {
        public override ClientDetail CreateClient()
        {
            return new ClientDetail(/* parameters for business client */);
        }
    }
}
