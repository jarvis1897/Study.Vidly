using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class CustomerController : Controller
	{
		// GET: Customers
		public ActionResult Customer()
		{

			var customers = new List<Customer>
			{
				//new Customer { Name = "John Smith" },
				//new Customer { Name = "Mary Williams" }
			};

			return View(customers);
		}

		public ActionResult Detail(int id)
		{
			var customers = new List<Customer>
			{
				new Customer { Name = "John Smith", Id = 1},
				new Customer { Name = "Mary Williams", Id = 2 }
			};
			var customer = customers.FirstOrDefault(c => c.Id == id);
			if (customer != null)
			{
				return View(customer);
			}

			return HttpNotFound();
		}
	}
}