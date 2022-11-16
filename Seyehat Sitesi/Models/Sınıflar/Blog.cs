using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seyehat_Sitesi.Models.Sınıflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }    // ıcollection kumeleme listeleme ve toplamada kullanılır bire çok ilişki kurduk.İlişkili tabloların prop değerleri ıcollectin şeklinde tutulur.

    }
}