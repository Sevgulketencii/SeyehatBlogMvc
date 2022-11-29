using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelMvc.Models.Context;

namespace TravelMvc.Controllers
{
    public class AboutController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();
        public IActionResult About()
        {
            var hakkımızda = dbbaglan.Hakkımızdadb.ToList();
            return View(hakkımızda);
        }
    }
}
