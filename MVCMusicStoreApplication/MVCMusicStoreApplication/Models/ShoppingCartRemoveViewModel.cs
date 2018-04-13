using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStoreApplication.Models.ViewModels {
	public class ShoppingCartRemoveViewModel {
		public int DeleteId { get; set; } //Match with RecordId
		public decimal CartTotal { get; set; }
		public int ItemCount { get; set; }
		public int CartCount { get; set; }
		public string Message { get; set; }
	}
}