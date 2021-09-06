using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLBanHangMVC.Models;
using PagedList;

namespace QLBanHangMVC.Controllers
{
    public class HomeController : Controller
    {
        private WineStore db = new WineStore();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display( int? page)
        {
            var danhmuc = db.Catalogies.Select(s => s);
            danhmuc = danhmuc.OrderBy(s => s.CatalogyID);
            int pageSize = 3;
            int pageNumber = (page ?? 1);

            return View(danhmuc.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}