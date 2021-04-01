using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMiniProject.Controllers
{
	public class PersonController : Controller
	{
		// GET: PersonController
		public ActionResult Index()
		{
			return View();
		}

		// GET: PersonController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: PersonController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
