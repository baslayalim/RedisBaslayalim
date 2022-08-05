using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedisBaslayalim.Controllers
{
    public class HomeController : Controller
    {
        string hostport = "localhost:6379";
        // GET: Home
        public ActionResult Index()
        {
            RedisBaslayalim.BaslayalimKaydet(hostport, "siteayarlari", "Burası Başlık");
            ViewBag.ayar = RedisBaslayalim.BaslayalimRead(hostport, "siteayarlari");
            return View();
        }
    }
}