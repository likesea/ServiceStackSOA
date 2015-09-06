using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using ServiceStack;
using TicketSystem.ServiceContract;

namespace TicketClient.cs.Controllers
{
    public class DefaultController : Controller
    {
        private static JsonServiceClient client = new JsonServiceClient("http://localhost:49468/");
        // GET: Default
        public ActionResult Index()
        {
            var result = client.Get<List<Ticket>>(new GetAllTicketInQueueRequest());
            
            return View();
        }
    }
}