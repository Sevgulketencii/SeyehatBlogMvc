using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelMvc.Models;
using TravelMvc.Models.Context;

namespace TravelMvc.Controllers
{
    
    public class AdminController : Controller
    {
        
        Dbcontext dbbaglan = new Dbcontext();

        [Authorize]
        public IActionResult Admin()
        {
            
            return View(dbbaglan.Blgodb.ToList());
        }

        public IActionResult BlogEkle()
        {

            return View();
        }

        [HttpPost]
        public IActionResult BlogEkle(Blog eklenecek)
        { 
                dbbaglan.Blgodb.Add(eklenecek);
                dbbaglan.SaveChanges();
                return RedirectToAction("Admin");
        }

        public IActionResult BlogSil(int id)
        {
            var silinecek = dbbaglan.Blgodb.Find(id);
            dbbaglan.Blgodb.Remove(silinecek);
            dbbaglan.SaveChanges();
            return RedirectToAction("Admin");
        }

        public IActionResult BlogGüncelle(int id)
        {
            var güncellenen = dbbaglan.Blgodb.Find(id);
            ViewBag.id = id;
            return View(güncellenen);
        }

        [HttpPost]
        public IActionResult BlogGüncelle(Blog güncel)
        {
            var güncelle = dbbaglan.Blgodb.Find(güncel.Id);
            güncelle.Baslik = güncel.Baslik;
            güncelle.Tarih = güncel.Tarih;
            güncelle.Aciklama = güncel.Aciklama;
            güncelle.BlogImg = güncel.BlogImg;
            dbbaglan.SaveChanges();
            return RedirectToAction("Admin");
        }
        
        public IActionResult YorumListe()
        {
            return View(dbbaglan.Yorumdb.ToList());
        }

        public IActionResult YorumSil(int id)
        {
            var silinecek = dbbaglan.Yorumdb.Find(id);
            dbbaglan.Remove(silinecek);
            dbbaglan.SaveChanges();
            return RedirectToAction("YorumListe");
        }

        public IActionResult YorumEkle()
        {

            return View();
        }

        [HttpPost]
        public IActionResult YorumEkle(Yorum eklenecek)//burda bir mallık var
        {
            //dbbaglan.Yorumdb.Add(eklenecek);
            //dbbaglan.SaveChanges();
            return View("YorumEkle");

        }

        public async Task<IActionResult> Cikis()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        
    }
}
