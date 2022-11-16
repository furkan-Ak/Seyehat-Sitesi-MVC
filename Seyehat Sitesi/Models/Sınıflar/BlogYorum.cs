using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Seyehat_Sitesi.Models;
namespace Seyehat_Sitesi.Models.Sınıflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> BlogDegerler { get; set; }
        public IEnumerable<Yorumlar> YorumDegerler { get; set; }
        public IEnumerable<Blog> SonBlogDegerler { get; set; }  


    }
}