using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeStore.Models;

namespace ShoeStore.Controllers
{
    public class GiohangController : Controller
    {
        dbQLShoeStoreDataContext data = new dbQLShoeStoreDataContext();
        // GET: Giohang

        public List<Giohang> Laygiohang()
        {
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if (lstGiohang == null)
            {
                lstGiohang = new List<Giohang>();
                Session["Giohang"] = lstGiohang;
            }
            return lstGiohang;
        }

        public ActionResult ThemGioHang(int iMagiay, string strURL)
        {
            List<Giohang> lstGiohang = Laygiohang();
            Giohang sanpham = lstGiohang.Find(n => n.iMagiay == iMagiay);
            if (sanpham == null)
            {
                sanpham = new Giohang(iMagiay);
                lstGiohang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoluong++;
                return Redirect(strURL);
            }
        }

        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if(lstGiohang != null)
            {
                iTongSoLuong = lstGiohang.Sum(n => n.iSoluong);
            }
            return iTongSoLuong;
        }

        private double TongTien()
        {
            double iTongTien = 0;
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if(lstGiohang != null)
            {
                iTongTien = lstGiohang.Sum(n => n.dThanhtien);
            }
            return iTongTien;
        }

        public ActionResult GioHang()
        {
            List<Giohang> lstGiohang = Laygiohang();
            if(lstGiohang.Count == 0)
            {
                return RedirectToAction("Index", "ShoeStore");
            }
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return View(lstGiohang);
        }

        public ActionResult GiohangPartial()
        {
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return PartialView();
        }
        //xoa gio hang
        public ActionResult XoaGioHang(int iMaSp)
        {
            //lay gio hang tu session
            List<Giohang> lstGiohang = Laygiohang();
            //kiem tra giay da co trong session["giohang"]
            Giohang sanpham = lstGiohang.SingleOrDefault(n => n.iMagiay == iMaSp);
            //Neu ton tai san pham thi cho sua so luong
            if (sanpham != null)
            {
                lstGiohang.RemoveAll(n => n.iMagiay == iMaSp);
                return RedirectToAction("GioHang");
            }
            if(lstGiohang.Count == 0)
            {
                return RedirectToAction("Index", "ShoeStore");
            }
            return RedirectToAction("GioHang");
        }
        //cap nhat gio hang
        public ActionResult CapNhatGioHang(int iMaSp, FormCollection f)
        {
            //lay gio hang tu session
            List<Giohang> lstGiohang = Laygiohang();
            //kiem tra giay da có trong session ["Giohang"]
            Giohang sanpham = lstGiohang.SingleOrDefault(n => n.iMagiay == iMaSp);
            //Neu ton tai thi cho sua so luong
            if (sanpham != null)
            {
                sanpham.iSoluong = int.Parse(f["txtSoluong"].ToString());
            }
            return RedirectToAction("Giohang");
        }
        //Xoa Tat Ca Gio Hang
        public ActionResult XoaTatCaGioHang()
        {
            //lay Gio Hang Tu Session
            List<Giohang> lstGiohang = Laygiohang();
            lstGiohang.Clear();
            return RedirectToAction("Index", "ShoeStore");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}