using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;

namespace EventApplication.Controllers {	
	[Authorize]
    public class OrderController : Controller {

		private EventDBContext db = new EventDBContext();

		// GET: Order
		public ActionResult Create(int tickets, int id) {
			Order order = new Order {
				OrderDate = DateTime.Today,
				NumOfTickets = tickets,
				Evnt = db.Events.Single(e => e.Id == id),
				User = User.Identity.Name
			};

			db.Orders.Add(order);
			db.SaveChanges();

            return View();
        }

		public ActionResult Cancel() {
			//find the order
			//delete the order
			//give amount of tickets back to available
			return View();
		}

		public ActionResult TicketsOrdered() {
			return View();
		}
	}
}