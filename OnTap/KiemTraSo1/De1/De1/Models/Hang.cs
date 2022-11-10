using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace De1.Models
{
    public class Hang
    {
        public string maHang { get; set; }
        public string tenHang { get; set; }
        public string loaiHang { get; set; }
        public float donGia { get; set; }
        public int soLuong { get; set; }

        public float ThanhTien()
        {
            if (soLuong >= 100)
            {
                return (float)(soLuong * donGia * 0.9);
            }
            else
                return soLuong * donGia;
        }
    }
}