using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TravelMvc.Models;
using TravelMvc.Models.Context;
using TravelMvc.Models.Sınıflar;

namespace TravelMvc.Controllers
{
    public class HomeController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();
        public IActionResult Index()
        {
            BlogYorum a = new BlogYorum();
          
            a.deger4 = dbbaglan.Blgodb.OrderByDescending(x => x.Id).Take(2).ToList();
            a.deger3= dbbaglan.Blgodb.OrderByDescending(x => x.Id==1).Take(1).ToList();
            a.deger1 = dbbaglan.Blgodb.ToList();
            return View(a);
        }

    }
}
