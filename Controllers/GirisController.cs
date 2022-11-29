using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TravelMvc.Models;
using TravelMvc.Models.Context;


namespace TravelMvc.Controllers
{
    public class GirisController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();

        

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Admin gelenkullanici)
        {
            var admin = dbbaglan.Admindb.FirstOrDefault(x => x.AdminAdi == gelenkullanici.AdminAdi && x.AdminSifre == gelenkullanici.AdminSifre);
            if (admin != null)
            {
                
                var claims = new List<Claim>
               {
                   new Claim(ClaimTypes.Name,gelenkullanici.AdminAdi)
               };

                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Admin","Admin");

            }
            
            
                return View();
            
        }



    }
}
