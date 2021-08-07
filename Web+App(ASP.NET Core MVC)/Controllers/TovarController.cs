using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_App_ASP.NET_Core_MVC_.Controllers
{
    public class TovarController : Controller
    {
        // GET: TovarController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TovarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TovarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TovarController/Create
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

        // GET: TovarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TovarController/Edit/5
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

        // GET: TovarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TovarController/Delete/5
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
