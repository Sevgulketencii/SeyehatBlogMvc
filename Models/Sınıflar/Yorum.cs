using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelMvc.Models
{
    public class Yorum
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Aciklama { get; set; }
        public int blogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
