using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Lab2.Controllers
{
    public class ProductController : Controller
    {
        public string Index()
        {
			return "Product/Index is displayed";
        }

		public string Browse()
		{
			return "Browse displayed";
		}

		public string Details(int id)
		{
			return "Details displayed for Id="+id;
		}

		public string Location(string zip)
		{
			string message = WebUtility.HtmlEncode("Location displayed for zip=" + zip);

			return message;
		}
    }
}