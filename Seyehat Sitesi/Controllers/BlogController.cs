using Seyehat_Sitesi.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Seyehat_Sitesi.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Blog()
        {
            //  var degerler = c.Blogs.ToList();
            by.BlogDegerler = c.Blogs.ToList();
            by.SonBlogDegerler = c.Blogs.OrderByDescending(x => x.Tarih).Take(2).ToList();
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            //  var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.BlogDegerler = c.Blogs.Where(x => x.ID == id).ToList();
            by.YorumDegerler = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            by.SonBlogDegerler = c.Blogs.OrderByDescending(x => x.Tarih).Take(2).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id; // blog idsini tutuyorum
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}