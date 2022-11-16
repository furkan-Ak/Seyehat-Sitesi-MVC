using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seyehat_Sitesi.Models.Sınıflar;
namespace Seyehat_Sitesi.Controllers
{
    public class AnaSayfaController : Controller
    {

        // GET: AnaSayfa
        Context c = new Context();
        public ActionResult AnaSayfa()
        {

            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public ActionResult Hakkında()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        } 
        public PartialViewResult Partial2()
        {
            var degerler = c.Blogs.Where(x => x.ID==1).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult PartialTop10()
        {
            var degerler = c.Blogs.Take(8).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult PartialBestPlaces() // left best place
        {
            var değerler = c.Blogs.Take(3).ToList();
            return PartialView(değerler);
        }
        public PartialViewResult PartialBestPlaces2() // rigt best place
        {
            var değerler = c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(değerler);
        }
    }
}