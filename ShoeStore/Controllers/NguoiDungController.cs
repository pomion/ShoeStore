using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeStore.Models;

namespace ShoeStore.Controllers
{
    public class NguoiDungController : Controller
    {
        dbQLShoeStoreDataContext db = new dbQLShoeStoreDataContext();
        // GET: NguoiDung
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dangky()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Dangky(FormCollection collection,KHACHHANG kh)
        {
            var hoten = collection["HotenKH"];
            var tendn = collection["TenDN"];
            var matkhau = collection["Matkhau"];
            var nhaplaimatkhau = collection["Nhaplaimatkhau"];
            var email = collection["email"];
            var diachi = collection["Diachi"];
            var sodienthoai = collection["Sodienthoai"];
            var ngaysinh = String.Format("{0:MM/dd/yyyy}", collection["Ngaysinh"]);
            if (String.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Họ tên khách hàng không được để trống";
            }
            else if(String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi2"] = "Phải Nhập Tên Đăng Nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Phải Nhập Mật Khẩu";
            }
            else if (String.IsNullOrEmpty(nhaplaimatkhau))
            {
                ViewData["Loi4"] = "Phải Nhập Lại Mật Khẩu";
            }
            if (String.IsNullOrEmpty(email))
            {
                ViewData["Loi5"] = "Phải Nhập Email";
            }
            if (String.IsNullOrEmpty(diachi))
            {
                ViewData["Loi6"] = "Phải Nhập Địa Chỉ";
            }
            if (String.IsNullOrEmpty(sodienthoai))
            {
                ViewData["Loi7"] = "Phải Nhập Số Điện Thoại ";
            }
            else
            {
                kh.HoTen = hoten;
                kh.Taikhoan = tendn;
                kh.Matkhau = matkhau;
                kh.Email = email;
                kh.DiachiKH = diachi;
                kh.DienthoaiKH = sodienthoai;
                kh.Ngaysinh = DateTime.Parse(ngaysinh);
                db.KHACHHANGs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return RedirectToAction("Dangnhap");
            }
            return this.Dangky();
        }
        [HttpGet]
        public ActionResult Dangnhap(FormCollection collection)
        {
            var tendn = collection["TenDN"];
            var matkhau = collection["MatKhau"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải Nhập Tên Đăng Nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải Nhập Mật Khẩu";
            }
            else
            {
                KHACHHANG kh = db.KHACHHANGs.SingleOrDefault(n => n.Taikhoan == tendn && n.Matkhau == matkhau);
                if(kh != null)
                {
                    ViewBag.ThongBao = "Chúc Mừng Bạn Đã Đăng Nhập Thành Công .";
                    Session["Taikhoan"] = kh;
                }
                else
                {
                    ViewBag.ThongBao = "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng !";
                }
            }
            return View();
        }
    }
}