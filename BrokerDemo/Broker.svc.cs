using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BrokerDemo
{
    
    
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Broker : IBroker
    {
        static Dictionary<string, string> addresses = new Dictionary<string, string>();
        public string GetAddress(string id) => addresses[id];
        public void RegisterAddress(string id, string address) => addresses.Add(id, address);
    }
}
