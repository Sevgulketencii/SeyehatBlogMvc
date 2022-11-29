using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelMvc.Models;
using TravelMvc.Models.Context;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TravelMvc.Controllers
{
    public class IletisimController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();
        public IActionResult Iletisim()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Iletisim(Iletisim gelenveri)
        {
            if (ModelState.IsValid)
            {
                dbbaglan.Iletisimdb.Add(gelenveri);
                dbbaglan.SaveChanges();

            };
               
            return RedirectToAction("Iletisim");
        }
    }
}
