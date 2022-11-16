using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Seyehat_Sitesi.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<Admin>Admins { get; set; }
        public DbSet<AdresBlog>AdresBlogs { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Hakkında>Hakkındas { get; set; }
        public DbSet<Iletisim>Iletisims { get; set; }
        public DbSet<Yorumlar>Yorumlars { get; set; }


    }
}