using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.ServiceContract
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int TableNumber { get; set; }
        public int ServerId { get; set; }
        public List<Order> Orders;
        public DateTime Timestamp { get; set; }
    }
}
