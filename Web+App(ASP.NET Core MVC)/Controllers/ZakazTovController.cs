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
    public class ZakazTovController : Controller
    {
        private TaxiInDronContext db;
        public static int? ThisId = 0;

        public ZakazTovController(TaxiInDronContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
                return StatusCode(401);
            else
            {
                ThisId = id;
                ViewBag.Title = "Заказ дрона";
                return View(await db.HarkDrons.Where(p => p.WhoIsAvto == id).ToListAsync());
            }
        }
       
        [HttpPost]
        public async Task<IActionResult> Create(Zakaz zak)
        {
            zak.DateZak = DateTime.Now;
            zak.CurrZak = ThisId;
            zak.Status = 1;
            db.Zakazs.Add(zak);
            await db.SaveChangesAsync();
            return RedirectToAction("EndZak");

        }
        public IActionResult EndZak()
        {
            return Ok("Покупка завершена");
        }


    }
}
