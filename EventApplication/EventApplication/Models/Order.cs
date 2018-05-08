using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models {
	public class Order {
		public int Id { get; set; }
		public DateTime OrderDate { get; set; }
		public Event Evnt { get; set; }
		public int NumOfTickets { get; set; }
		public string User { get; set; }
	}
}