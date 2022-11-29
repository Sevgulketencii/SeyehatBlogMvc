using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelMvc.Models;
using TravelMvc.Models.Context;
using TravelMvc.Models.Sınıflar;

namespace TravelMvc.Controllers
{
    public class BlogController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();
        BlogYorum a = new BlogYorum();
       
        public IActionResult Blog()
        {
            a.deger1= dbbaglan.Blgodb.ToList();
            a.deger3 = dbbaglan.Blgodb.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(a);
        }

        public IActionResult BlogDetay(int id)
        {
            a.deger1 = dbbaglan.Blgodb.Where(x=>x.Id==id).ToList();
            ViewBag.id = id;
            a.deger2 = dbbaglan.Yorumdb.Where(x =>x.blogId==id).ToList();
            a.deger3 = dbbaglan.Blgodb.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(a);
           
        }

        [HttpPost]
        public IActionResult BlogDetay(Yorum yeniyorum)
        {
            dbbaglan.Yorumdb.Add(yeniyorum);
            dbbaglan.SaveChanges();
            return RedirectToAction("Blog");
        }


    }
}
