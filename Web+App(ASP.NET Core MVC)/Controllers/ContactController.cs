using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_App_ASP.NET_Core_MVC_.Models;

namespace Web_App_ASP.NET_Core_MVC_.Controllers
{
    public class ContactController : Controller
    {
        private TaxiInDronContext db;
        public ContactController(TaxiInDronContext context)
        {
            db = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // POST: ContactController/Create
        [HttpPost]
        public async Task<IActionResult> Create(Zvonk zv)
        {
            db.Zvonks.Add(zv);
            await db.SaveChangesAsync();
            return RedirectToAction("EndCont");
        }

        public IActionResult EndCont()
        {
            return View();
        }

    }
}
