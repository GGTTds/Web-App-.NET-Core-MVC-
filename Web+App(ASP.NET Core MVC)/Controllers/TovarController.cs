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
    public class TovarController : Controller
    {
        // GET: TovarController
        private TaxiInDronContext db;
        public TovarController(TaxiInDronContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Drons.ToListAsync());
        }

    }
}
