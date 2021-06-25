using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoeStore.Models;

namespace ShoeStore.Models
{
    public class Giohang
    {
        dbQLShoeStoreDataContext data = new dbQLShoeStoreDataContext();

        public int iMagiay { set; get; }
        public String sTengiay { set; get; }
        public String sAnhbia { set; get; }
        public Double dDongia { set; get; }
        public int iSoluong { set; get; }
        public Double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }
        public Giohang(int Magiay)
        {
            iMagiay = Magiay;
            GIAY giay = data.GIAYs.Single(n => n.Magiay == iMagiay);
            sTengiay = giay.Tengiay;
            sAnhbia = giay.Anhbia;
            dDongia = Double.Parse(giay.Giaban.ToString());
            iSoluong = 1;
        }
    }
}