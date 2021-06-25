using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeStore.Models;

namespace ShoeStore.Controllers
{
    public class ShoeStoreController : Controller
    {
        dbQLShoeStoreDataContext data = new dbQLShoeStoreDataContext();
        // GET: ShoeStore

        private List<GIAY> Laygiaymoi(int count)
        {
            return data.GIAYs.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
        }
        public ActionResult Index()
        {
            var giaymoi = Laygiaymoi(5);
            return View(giaymoi);
        }

        public ActionResult Loaigiay()
        {
            var loaigiay = from lg in data.LOAIGIAYs select lg;
            return PartialView(loaigiay);
        }

        public ActionResult HangGiay()
        {
            var hanggiay = from hgg in data.HANGGIAYs select hgg;
            return PartialView(hanggiay);
        }

        public ActionResult SPTheoloai(int id)
        {
            var giay = from s in data.GIAYs where s.MaLG == id select s;
            return View(giay);
        }

        public ActionResult SPTheohang(int id)
        {
            var giay = from s in data.GIAYs where s.MaHG == id select s;
            return View(giay);
        }

        public ActionResult Details (int id)
        {
            var sach = from s in data.GIAYs
                       where s.Magiay == id
                       select s;
            return View(sach.Single());
        }
    }
}