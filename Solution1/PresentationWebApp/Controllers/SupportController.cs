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
			//...inform the responsible staff

			/*
				*feedback = [Thank you for getting in touch with us. We will answer back asap]
				*warning = [Type in some question]
				*key = [value]
				*key = [value]
			 */

			if (string.IsNullOrEmpty(query))
			{
				ViewData["warning"] = "Type in some question";
			}
			else
			{
				ViewData["primary"] = "Thank you for getting in touch with us!";
			}

			return View();
		}
	}
}
