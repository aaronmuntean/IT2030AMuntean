using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EventApplication.Infrastructure;

namespace EventApplication.Models {
	public class Event {
		public int Id { get; set; }
		[Display(Name = "Type of Event")]
		public int EventTypeId { get; set; }
		[StringLength(50, ErrorMessage = "Title cannot exceed 50 characters.")]
		[Required(ErrorMessage = "Title is required.")]
		[Display(Name = "Event Title")]
		public string Title { get; set; }
		[StringLength(150, ErrorMessage = "Description cannot exceed 150 characters.")]
		[Required(ErrorMessage = "Description is required.")]
		[Display(Name = "Event Description")]
		public string Description { get; set; }
		
		public EventType EvntType { get; set; }
		
		[Display(Name = "Start Date and Time")]
		[RegularExpression(@"\d{1,2}\/\d{1,2}\/\d{4} \d\d:\d\d:\d\d (AM|PM)", ErrorMessage = "Use format mm/dd/yyyy hh:mm AM/PM. Example: 1/1/2018 12:00:00 AM")]
		[Required(ErrorMessage = "Start Date and Time are required.")]
		[ValidDateAttribute]
		public DateTime StartDateTime { get; set; }

		[Display(Name = "End Date and Time")]
		[RegularExpression(@"\d{1,2}\/\d{1,2}\/\d{4} \d\d:\d\d:\d\d (AM|PM)", ErrorMessage = "Use format mm/dd/yyyy hh:mm AM/PM. Example: 1/1/2018 12:00:00 AM")]
		[Required(ErrorMessage = "End Date and Time are required.")]
		[ValidDateAttribute]
		public DateTime EndDateTime { get; set; }

		[Display(Name = "City")]
		public string LocationCity { get; set; }
		[Display(Name = "State")]
		public string LocationState { get; set; }

		[Display(Name = "Organizer's Name")]
		public string Organizer { get; set; }

		[Display(Name = "Max Tickets")]
		[Required(ErrorMessage = "Max Tickets is required.")]
		[Range(1, 100, ErrorMessage = "Max Tickets must be at least 1 and no more than 100.")]
		public int MaxTickets { get; set; }

		[Range(1, 100, ErrorMessage = "Available Tickets must be at least 1 and no more than 100.")]
		[Required(ErrorMessage = "Available Tickets is required.")]
		[Compare("MaxTickets")]
		[Display(Name = "Available Tickets")]
		public int AvailableTickets { get; set; }
	}
}