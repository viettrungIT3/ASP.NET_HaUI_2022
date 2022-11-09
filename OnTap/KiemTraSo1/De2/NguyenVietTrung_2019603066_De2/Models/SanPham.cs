using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenVietTrung_2019603066_De2.Models
{
    public class SanPham
    {
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string loaiSP { get; set; }
        public int soLuong { get; set; }
        public double donGia { get; set; }

        public double ThanhTien()
        {
            if (soLuong >= 200)
            {
                return soLuong * donGia * 0.85;
            }
            else
            {
                return soLuong * donGia;
            }
        }
    }
}