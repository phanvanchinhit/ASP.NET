using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Dien.Models
{
    public class HoDan
    {
        private string tenChuHo;
        private string hoUuTien = "false";
        private string loaiDien = "SinhHoat";
        private int soCu;
        private int soMoi;
        private int soDien;
        private double tongTien;

        public string TenChuHo { get => tenChuHo; set => tenChuHo = value; }
        public string LoaiDien { get => loaiDien; set => loaiDien = value; }
        public int SoCu { get => soCu; set => soCu = value; }
        public int SoMoi { get => soMoi; set => soMoi = value; }
        public int SoDien { get => soDien; set => soDien = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        public string HoUuTien { get => hoUuTien; set => hoUuTien = value; }
    }
}