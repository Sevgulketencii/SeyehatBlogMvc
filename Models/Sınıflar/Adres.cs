using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelMvc.Models
{
    public class Adres
    {
        [Key]
        public int Id { get; set; }
        public string Baslik{ get; set; }
        public string Aciklama{ get; set; }
        public string Telefonumuz { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

    }
}
