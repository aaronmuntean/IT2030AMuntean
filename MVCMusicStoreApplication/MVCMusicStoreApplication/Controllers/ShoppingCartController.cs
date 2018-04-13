using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models;
using MVCMusicStoreApplication.Models.ViewModels;

namespace MVCMusicStoreApplication.Controllers {
    public class ShoppingCartController : Controller {
		MVCMusicStoreDB db = new MVCMusicStoreDB();

        // GET: ShoppingCart
        public ActionResult Index() {
			ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
			ShoppingCartViewModel vm = new ShoppingCartViewModel() {
				CartItems = cart.GetCartItems(),
				CartTotal = cart.GetCartTotal()
			};

			return View(vm);
        }

		// GET: ShoppingCart/AddToCart/5
		public ActionResult AddToCart(int id) {
			ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);
			cart.AddToCart(id);
			return RedirectToAction("Index");
		}

		[HttpPost]
		//POST: Ajax Call
		public ActionResult RemoveFromCart(int id) {
			//id == RecordId
			ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);

			string albumTitle = db.Carts.SingleOrDefault(c => c.RecordId == id).AlbumSelected.Title;

			int count = cart.RemoveFromCart(id);

			ShoppingCartRemoveViewModel vm = new ShoppingCartRemoveViewModel() {
				ItemCount = count,
				DeleteId = id,
				CartTotal = cart.GetCartTotal(),
				Message = albumTitle + " has been removed from the cart."
			};

			return Json(vm);
		}
    }
}