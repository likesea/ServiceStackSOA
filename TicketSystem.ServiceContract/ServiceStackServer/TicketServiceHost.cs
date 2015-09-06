using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Funq;
using ServiceStack;

namespace ServiceStackServer
{
    public class TicketServiceHost:AppHostBase
    {
        public TicketServiceHost():
            base("Ticket Service", typeof(TicketService).Assembly) { }

        public override void Configure(Container container)
        {
            
        }
    }
}