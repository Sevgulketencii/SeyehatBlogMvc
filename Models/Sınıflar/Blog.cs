using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelMvc.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        public string Baslik { get; set; }

        public DateTime Tarih { get; set; }

        public string Aciklama{ get; set; }

        public string BlogImg { get; set; }
        public ICollection<Yorum> Yorums{ get; set; }

    }
}
