using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelMvc.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string AdminAdi { get; set; }
        public string AdminSifre { get; set; }
    }
}
