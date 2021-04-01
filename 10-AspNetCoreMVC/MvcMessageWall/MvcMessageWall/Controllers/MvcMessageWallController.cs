using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// 1. Create new Controller 

namespace MvcMessageWall.Controllers
{
	public class MvcMessageWallController : Controller
	{
		// GET: MvcMessageWallController
		public ActionResult Index()
		{
			return View();
		}

		// GET: MvcMessageWallController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: MvcMessageWallController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: MvcMessageWallController/Create
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

		// GET: MvcMessageWallController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: MvcMessageWallController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
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

		// GET: MvcMessageWallController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: MvcMessageWallController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
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
