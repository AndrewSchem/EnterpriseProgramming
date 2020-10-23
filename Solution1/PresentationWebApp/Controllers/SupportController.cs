using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PresentationWebApp.Controllers
{
	public class SupportController : Controller
	{
		public IActionResult Contact()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Contact(string email, string query)
		{

			ViewData["feedback"] = "Thank you for getting in touch with us!";

			return View();
		}
	}
}
