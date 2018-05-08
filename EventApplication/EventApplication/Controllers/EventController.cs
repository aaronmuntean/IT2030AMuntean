using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;

namespace EventApplication.Controllers { 
    public class EventController : Controller {

		private EventDBContext db = new EventDBContext();

        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Search(string evnt, string loc) {
			//seach by event and location
			List<Event> events = new List<Event>();
			if (evnt != null && loc != null) {
				events = db.Events.Where(e => (e.Title.Contains(evnt) ||
												e.EvntType.Name.Contains(evnt)) &&
												(e.LocationCity.Contains(loc) ||
												e.LocationState.Contains(loc))).ToList();
				return PartialView(events);
			}

			if (evnt != null) {
				events = db.Events.Where(e => e.Title.Contains(evnt) ||
											  e.EvntType.Name.Contains(evnt)).ToList();
			}

			if (loc != null) {
				events = db.Events.Where(e => e.LocationCity.Contains(loc) ||
										 e.LocationState.Contains(loc)).ToList();
			}

			return PartialView(events);
		}

		public ActionResult Details(int id) {
			Event evnt = db.Events.Single(e => e.Id == id);
			return View(evnt);
		}

		public ActionResult Register(int id) {
			Event evnt = db.Events.Single(e => e.Id == id);

			return PartialView(evnt);
		}

		public ActionResult LastMinuteDeal() {
			List<Event> events = new List<Event>();
			DateTime twoDaysFromToday = DateTime.Today.AddDays(2);
			DateTime today = DateTime.Today;

			events = db.Events.Where(ev => ev.StartDateTime <= twoDaysFromToday && ev.StartDateTime >= today).ToList();

			return PartialView(events);
		}
    }
}