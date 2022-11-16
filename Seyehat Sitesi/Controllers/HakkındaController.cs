using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seyehat_Sitesi.Models.Sınıflar;

namespace Seyehat_Sitesi.Controllers
{
    public class HakkındaController : Controller
    {
        // GET: Hakkında
        Context c = new Context();
        public ActionResult Hakkında()
        {
            var degerler = c.Hakkındas.ToList();
            return View(degerler);
        }
    }
}