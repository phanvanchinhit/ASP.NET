using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Dien.Models;

namespace MVC_Dien.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TinhTien(HoDan hoDan)
        {
            ViewBag.tenChuHo = hoDan.TenChuHo;
            ViewBag.hoUuTien = hoDan.HoUuTien;
            ViewBag.loaiDien = hoDan.LoaiDien;
            ViewBag.soCu = hoDan.SoCu;
            ViewBag.soMoi = hoDan.SoMoi;
            hoDan.SoDien = hoDan.SoMoi - hoDan.SoCu;
            ViewBag.soDien = hoDan.SoDien;

            if(hoDan.HoUuTien.Equals("false"))
            {
                if (hoDan.LoaiDien.Equals("SinhHoat"))
                {
                    hoDan.TongTien = Tinh(hoDan.SoDien);
                }
                else if (hoDan.LoaiDien.Equals("KinhDoanh"))
                {
                    hoDan.TongTien = Tinh(hoDan.SoDien) * 1.2;
                }
                else
                {
                    hoDan.TongTien = Tinh(hoDan.SoDien) * 1.3;
                }
            }
            else
            {
                if (hoDan.LoaiDien.Equals("SinhHoat"))
                {
                    hoDan.TongTien = Tinh(hoDan.SoDien) * 0.9;
                }
                else if (hoDan.LoaiDien.Equals("KinhDoanh"))
                {
                    hoDan.TongTien = Tinh(hoDan.SoDien) * 1.2 * 0.9;
                }
                else
                {
                    hoDan.TongTien = Tinh(hoDan.SoDien) * 1.3 * 0.9;
                }
            }

            ViewBag.tongTien = hoDan.TongTien;
            return View();
        }

        public int Tinh(int soDien)
        {
            int tongTien = 0;
            if (soDien <= 100)
            {
                tongTien = 2000 * soDien;
            }
            else if (soDien <= 150)
            {
                tongTien = 2000 * 100 + 2500 * (soDien - 100);
            }
            else if (soDien <= 200)
            {
                tongTien = 2000 * 100 + 2500 * 50 + 3000 * (soDien - 150);
            }
            else
            {
                tongTien = 2000 * 100 + 2500 * 50 + 3000 * 50 + 4000 * (soDien - 200);
            }
            return tongTien;
        }
    }
}