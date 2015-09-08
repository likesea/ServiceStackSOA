using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace TicketSystem.ServiceContract
{
    public class TicketSystemClient : JsonServiceClient
    {
        public const string OriginalServiceName = "ServiceStackServer";
        public TicketSystemClient(string baseUrl) : base(baseUrl)
        {
            
        }

        private static string baseUrl = System.Configuration.ConfigurationManager.AppSettings["soaUrl"];
        public TicketSystemClient()
            : base(baseUrl + OriginalServiceName)
        {
            
        }
    }
}
