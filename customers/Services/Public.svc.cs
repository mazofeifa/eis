using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace customers.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Public" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Public.svc or Public.svc.cs at the Solution Explorer and start debugging.
    public class Public : IPublic
    {
        public string DoSomething()
        {
            return "Hello, I'm a service hosted in AppHarbor";
        }
    }
}
