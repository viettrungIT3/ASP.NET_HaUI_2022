using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenVietTrung_2019603066_De4.Models
{
    public class GiangVien
    {
        public string maGV { get; set; }
        public string hoTen { get; set; }
        public string khoa { get; set; }
        public double luongGio { get; set; }
        public int soGio { get; set; }

        public double LuongThang()
        {
            if (soGio >= 120)
                return soGio * luongGio * 1.1;
            else
                return soGio * luongGio;
        }
    }
}