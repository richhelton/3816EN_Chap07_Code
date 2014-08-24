using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Mapping
{
    public class SubscriptionExt
    {
        public string MessageType { get; set; }
        public List<Address> Clients { get; set; }
    }
    public class Address
    {
        public string Queue { get; set; }
        public string Machine { get; set; }
    }
    public class SubscriptionExtView
    {
        public string MessageType { get; set; }
        public string Queue { get; set; }
        public string Machine { get; set; }
    }

}