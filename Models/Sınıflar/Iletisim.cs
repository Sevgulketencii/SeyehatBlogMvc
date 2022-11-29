using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelMvc.Models
{
    public class Iletisim
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Adi { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Mesaj { get; set; }
        public string Tel { get; set; }
    }
}
