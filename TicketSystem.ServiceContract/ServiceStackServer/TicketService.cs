using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using TicketSystem.ServiceContract;

namespace ServiceStackServer
{
    public class TicketService:Service,ITicketService
    {
        public List<Ticket> Any(GetAllTicketInQueueRequest request)
        {
            return new List<Ticket>(){new Ticket(){ServerId = 1,TableNumber = 123,TicketId = 09,Timestamp =  DateTime.Now}};
        }

        public void Any(QueueTicketRequest request)
        {
            
        }

        public Ticket Any(PullTicketRequest request)
        {
           return new Ticket();
        }
    }
}