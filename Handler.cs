using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premier_Service_Solutions
{
    public abstract class Handler
    {
        protected Handler nextHandler;

        public void SetNextHandler(Handler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(string request);
    }
}
