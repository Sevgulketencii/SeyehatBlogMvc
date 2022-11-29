using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelMvc.Models.Context
{
    public class Dbcontext:DbContext
    {
        public DbSet<Anasayfa> Anasayfadb { get; set; }
        public DbSet<Hakkımızda> Hakkımızdadb { get; set; }
        public DbSet<Blog> Blgodb { get; set; }
        public DbSet<Admin> Admindb { get; set; }
        public DbSet<Iletisim> Iletisimdb { get; set; }
        public DbSet<Yorum> Yorumdb { get; set; }
        public DbSet<Adres> Adresdb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=travelMvc;integrated security=true")  ;
        }

    }
}
