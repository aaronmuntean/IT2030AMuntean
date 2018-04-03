using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers {
    public class StoreController : Controller {
		private MVCMusicStoreDB db = new MVCMusicStoreDB();

		// GET: Store
		public ActionResult Index(int id) {
			var albums = db.Albums.Where(a => a.GenreId.Equals(id)).ToList();
			
			if(albums == null) {
				return HttpNotFound();
			}

            return View(albums);
        }

		//HTTP GET
		public ActionResult Browse() {
			//get all genres in a list and send to view
			var genres = db.Genres.OrderBy(g => g.Name).Take(db.Genres.Count());
			return View(genres);
		}

		public ActionResult Details(int id) {
			Album album = db.Albums.Find(id);

			if (album == null) {
				return HttpNotFound();
			}

			return View(album);
		}
	}
}