using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventApplication.Models {
	public class SampleData : DropCreateDatabaseIfModelChanges<EventDBContext> {
		protected override void Seed(EventDBContext context) {

			List<EventType> eventTypes = new List<EventType> {
				new EventType { Id = 1, Name = "Music" },
				new EventType { Id = 2, Name = "Food and Drink" },
				new EventType { Id = 3, Name = "Charity" },
				new EventType { Id = 4, Name = "Health" },
				new EventType { Id = 5, Name = "Business" },
				new EventType { Id = 6, Name = "Hobby" },
				new EventType { Id = 7, Name = "Community" },
				new EventType { Id = 10, Name = "Religion" },
				new EventType { Id = 8, Name = "Sports" },
				new EventType { Id = 9, Name = "Other" }
			};

			eventTypes.ForEach(e => context.EventTypes.Add(e));



			List<Event> events = new List<Event> {
				new Event { Title = "June Rock Show", Description = "Come watch local bands play!",
							StartDateTime = DateTime.Parse("6/22/2018 06:00:00 PM"), EndDateTime = DateTime.Parse("6/22/2018 10:00:00 PM"),
							LocationCity = "Cleveland", LocationState = "OH", EventTypeId = 1,
							Organizer = "Admin", MaxTickets = 100, AvailableTickets = 30 },
				new Event { Title = "Community Picnic", Description = "Bring your family to a fun community picnic",
							StartDateTime = DateTime.Parse("5/09/2018 11:00:00 AM"), EndDateTime = DateTime.Parse("5/09/2018 01:00:00 PM"),
							LocationCity = "Westlake", LocationState = "OH", EventTypeId = 5,
							Organizer = "Admin", MaxTickets = 30, AvailableTickets = 10 },
				new Event { Title = "Christian Gathering", Description = "Gather for food, community, and speakers",
							StartDateTime = DateTime.Parse("5/09/2018 03:00:00 PM"), EndDateTime = DateTime.Parse("5/09/2018 05:00:00 PM"),
							LocationCity = "Lakewood", LocationState = "OH", EventTypeId = 8,
							Organizer = "Admin", MaxTickets = 100, AvailableTickets = 50 },
				new Event { Title = "Food Drive", Description = "Bring non-perishable food items and socialize with community",
							StartDateTime = DateTime.Parse("5/08/2018 12:00:00 PM"), EndDateTime = DateTime.Parse("5/08/2018 08:00:00 PM"),
							LocationCity = "Lakewood", LocationState = "OH", EventTypeId = 4,
							Organizer = "Admin", MaxTickets = 100, AvailableTickets = 45 },
				new Event { Title = "Charitable Auction", Description = "Auction for various items; all proceeds go to charity.",
							StartDateTime = DateTime.Parse("8/23/2018 07:00:00 PM"), EndDateTime = DateTime.Parse("8/23/2018 09:00:00 PM"),
							LocationCity = "Westlake", LocationState = "OH", EventTypeId = 4,
							Organizer = "Admin", MaxTickets = 80, AvailableTickets = 45 },
				//6
				new Event { Title = "Summer Music Fest", Description = "Three day music event",
							StartDateTime = DateTime.Parse("5/08/2018 12:00:00 PM"), EndDateTime = DateTime.Parse("5/11/2018 08:00:00 PM"),
							LocationCity = "Cleveland", LocationState = "OH", EventTypeId = 1,
							Organizer = "Admin", MaxTickets = 300, AvailableTickets = 203 },
				new Event { Title = "Cavs Game 1", Description = "Cheer on your favorite team",
							StartDateTime = DateTime.Parse("5/05/2018 6:00:00 PM"), EndDateTime = DateTime.Parse("5/05/2018 10:00:00 PM"),
							LocationCity = "Cleveland", LocationState = "OH", EventTypeId = 3,
							Organizer = "Admin", MaxTickets = 1000, AvailableTickets = 3 },
				new Event { Title = "Art Class", Description = "Learn various art techniques",
							StartDateTime = DateTime.Parse("7/28/2018 11:00:00 AM"), EndDateTime = DateTime.Parse("7/28/2018 12:00:00 PM"),
							LocationCity = "Parma", LocationState = "OH", EventTypeId = 6,
							Organizer = "Admin", MaxTickets = 20, AvailableTickets = 12 },
				new Event { Title = "July 4th BBQ", Description = "Come eat and celebrate the 4th of July!",
							StartDateTime = DateTime.Parse("7/04/2018 07:00:00 PM"), EndDateTime = DateTime.Parse("7/04/2018 10:00:00 PM"),
							LocationCity = "Lakewood", LocationState = "OH", EventTypeId = eventTypes.Single(e => e.Name == "Food and Drink").Id,
							Organizer = "Admin", MaxTickets = 100, AvailableTickets = 60 },
				new Event { Title = "Business Tips", Description = "Learn tried and true business tips.",
							StartDateTime = DateTime.Parse("8/04/2018 07:00:00 AM"), EndDateTime = DateTime.Parse("8/04/2018 9:00:00 PM"),
							LocationCity = "Parma", LocationState = "OH", EventTypeId = 7,
							Organizer = "Admin", MaxTickets = 250, AvailableTickets = 101 },
				//11
				new Event { Title = "Yoga in the Morning", Description = "Morning Yoga Class",
							StartDateTime = DateTime.Parse("5/08/2018 07:00:00 AM"), EndDateTime = DateTime.Parse("5/08/2018 8:00:00 AM"),
							LocationCity = "Lakewood", LocationState = "OH", EventTypeId = 2,
							Organizer = "Admin", MaxTickets = 20, AvailableTickets = 3 },
				new Event { Title = "Yoga in the Evening", Description = "Evening Yoga Class",
							StartDateTime = DateTime.Parse("5/09/2018 07:00:00 PM"), EndDateTime = DateTime.Parse("5/09/2018 8:00:00 PM"),
							LocationCity = "Lakewood", LocationState = "OH", EventTypeId = 2,
							Organizer = "Admin", MaxTickets = 20, AvailableTickets = 8 },
				new Event { Title = "Business Insider", Description = "More tried and true business tips.",
							StartDateTime = DateTime.Parse("9/04/2018 07:00:00 AM"), EndDateTime = DateTime.Parse("9/04/2018 9:00:00 PM"),
							LocationCity = "Parma", LocationState = "OH", EventTypeId = 7,
							Organizer = "Admin", MaxTickets = 250, AvailableTickets = 201 },
				new Event { Title = "July Rock Show", Description = "Come watch local bands play!",
							StartDateTime = DateTime.Parse("7/24/2018 06:00:00 PM"), EndDateTime = DateTime.Parse("7/24/2018 10:00:00 PM"),
							LocationCity = "Cleveland", LocationState = "OH", EventTypeId = 1,
							Organizer = "Admin", MaxTickets = 100, AvailableTickets = 44 },
				new Event { Title = "May Rock Show", Description = "Come watch local bands play!",
							StartDateTime = DateTime.Parse("5/29/2018 06:00:00 PM"), EndDateTime = DateTime.Parse("5/29/2018 10:00:00 PM"),
							LocationCity = "Cleveland", LocationState = "OH", EventTypeId = 1,
							Organizer = "Admin", MaxTickets = 100, AvailableTickets = 12 },
				//16
				new Event { Title = "April Rock Show", Description = "Come watch local bands play!",
							StartDateTime = DateTime.Parse("4/24/2018 06:00:00 PM"), EndDateTime = DateTime.Parse("4/24/2018 10:00:00 PM"),
							LocationCity = "Cleveland", LocationState = "OH", EventTypeId = 1,
							Organizer = "Admin", MaxTickets = 100, AvailableTickets = 4 },
				new Event { Title = "Community Picnic June", Description = "Bring your family to a fun community picnic",
							StartDateTime = DateTime.Parse("6/01/2018 11:00:00 AM"), EndDateTime = DateTime.Parse("6/01/2018 01:00:00 PM"),
							LocationCity = "Westlake", LocationState = "OH", EventTypeId = 5,
							Organizer = "Admin", MaxTickets = 30, AvailableTickets = 8 },
				new Event { Title = "Community Picnic July", Description = "Bring your family to a fun community picnic",
							StartDateTime = DateTime.Parse("07/01/2018 11:00:00 AM"), EndDateTime = DateTime.Parse("07/01/2018 01:00:00 PM"),
							LocationCity = "Westlake", LocationState = "OH", EventTypeId = 5,
							Organizer = "Admin", MaxTickets = 30, AvailableTickets = 18 },
				new Event { Title = "Community Picnic August", Description = "Bring your family to a fun community picnic",
							StartDateTime = DateTime.Parse("8/01/2018 11:00:00 AM"), EndDateTime = DateTime.Parse("8/01/2018 01:00:00 PM"),
							LocationCity = "Westlake", LocationState = "OH", EventTypeId = 5,
							Organizer = "Admin", MaxTickets = 30, AvailableTickets = 25 },
				new Event { Title = "Cavs Game 2", Description = "Cheer on your favorite team",
							StartDateTime = DateTime.Parse("5/18/2018 6:00:00 PM"), EndDateTime = DateTime.Parse("5/18/2018 10:00:00 PM"),
							LocationCity = "Cleveland", LocationState = "OH", EventTypeId = 3,
							Organizer = "Admin", MaxTickets = 1000, AvailableTickets = 33 },
				//21
				new Event { Title = "Indians Game 1", Description = "Cheer on your favorite team",
							StartDateTime = DateTime.Parse("7/15/2018 6:00:00 PM"), EndDateTime = DateTime.Parse("7/15/2018 10:00:00 PM"),
							LocationCity = "Cleveland", LocationState = "OH", EventTypeId = 3,
							Organizer = "Admin", MaxTickets = 1000, AvailableTickets = 301 },
				new Event { Title = "Indians Game 2", Description = "Cheer on your favorite team",
							StartDateTime = DateTime.Parse("7/25/2018 6:00:00 PM"), EndDateTime = DateTime.Parse("7/25/2018 10:00:00 PM"),
							LocationCity = "Cleveland", LocationState = "OH", EventTypeId = 3,
							Organizer = "Admin", MaxTickets = 1000, AvailableTickets = 506 },
				new Event { Title = "Indians Game 3", Description = "Cheer on your favorite team",
							StartDateTime = DateTime.Parse("8/01/2018 6:00:00 PM"), EndDateTime = DateTime.Parse("8/01/2018 10:00:00 PM"),
							LocationCity = "Cleveland", LocationState = "OH", EventTypeId = 3,
							Organizer = "Admin", MaxTickets = 1000, AvailableTickets = 665 },
				new Event { Title = "Another Charitable Auction", Description = "Auction for various items; all proceeds go to charity.",
							StartDateTime = DateTime.Parse("10/24/2018 07:00:00 PM"), EndDateTime = DateTime.Parse("10/24/2018 09:00:00 PM"),
							LocationCity = "Westlake", LocationState = "OH", EventTypeId = 4,
							Organizer = "Admin", MaxTickets = 80, AvailableTickets = 55 },
				new Event { Title = "Cardio in the Morning", Description = "Morning Cardio Class",
							StartDateTime = DateTime.Parse("9/04/2018 07:00:00 AM"), EndDateTime = DateTime.Parse("9/04/2018 8:00:00 AM"),
							LocationCity = "Lakewood", LocationState = "OH", EventTypeId = 2,
							Organizer = "Admin", MaxTickets = 20, AvailableTickets = 8 },
				//26
				new Event { Title = "Cardio in the Evening", Description = "Evening Cardio Class",
							StartDateTime = DateTime.Parse("9/12/2018 07:00:00 AM"), EndDateTime = DateTime.Parse("9/12/2018 8:00:00 AM"),
							LocationCity = "Lakewood", LocationState = "OH", EventTypeId = 2,
							Organizer = "Admin", MaxTickets = 20, AvailableTickets = 12 },
				new Event { Title = "Art Class 2", Description = "Learn various art techniques",
							StartDateTime = DateTime.Parse("8/14/2018 11:00:00 AM"), EndDateTime = DateTime.Parse("8/14/2018 12:00:00 PM"),
							LocationCity = "Parma", LocationState = "OH", EventTypeId = 6,
							Organizer = "Admin", MaxTickets = 20, AvailableTickets = 14 },
				new Event { Title = "Art Class 3", Description = "Learn various art techniques",
							StartDateTime = DateTime.Parse("8/30/2018 11:00:00 AM"), EndDateTime = DateTime.Parse("8/30/2018 12:00:00 PM"),
							LocationCity = "Parma", LocationState = "OH", EventTypeId = 6,
							Organizer = "Admin", MaxTickets = 20, AvailableTickets = 16 },
				new Event { Title = "Art Class 4", Description = "Learn various art techniques",
							StartDateTime = DateTime.Parse("9/12/2018 11:00:00 AM"), EndDateTime = DateTime.Parse("9/12/2018 12:00:00 PM"),
							LocationCity = "Parma", LocationState = "OH", EventTypeId = 6,
							Organizer = "Admin", MaxTickets = 20, AvailableTickets = 11 },
				new Event { Title = "Art Class 5", Description = "Learn various art techniques",
							StartDateTime = DateTime.Parse("9/20/2018 11:00:00 AM"), EndDateTime = DateTime.Parse("9/20/2018 12:00:00 PM"),
							LocationCity = "Parma", LocationState = "OH", EventTypeId = 6,
							Organizer = "Admin", MaxTickets = 20, AvailableTickets = 5 },
			};
			events.ForEach(e => context.Events.Add(e));

			context.SaveChanges();

			List<Order> orders = new List<Order> {
				new Order { OrderDate = DateTime.Today, NumOfTickets = 3, User = "User1", Evnt = events.Single (e => e.Id == 1) },
				new Order { OrderDate = DateTime.Today, NumOfTickets = 2, User = "User2", Evnt = events.Single (e => e.Id == 1) }
			};
			orders.ForEach(o => context.Orders.Add(o));


		}

	}
}