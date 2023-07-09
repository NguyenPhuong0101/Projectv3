using System;
using System.Collections.Generic;
using System.Text;

namespace NguyenThiMyPhuong__BTL3
{
    class KhachHang
    {
        //Thuoc tinh:
        public string HoTen;
        public string SoDT;
        public string DiaChi;
        public string MaKH;
        public int SoLuong;
        public DateTime NgayKH;

        public ThietBi[] TB;
        //Ham khoi tao:
        public KhachHang()
        {
            
            NgayKH = DateTime.Now;
            SoLuong = 0 ;
            MaKH = "";
            TB = new ThietBi[2];
            HoTen = "";
            SoDT = "";
            DiaChi = "";

        }
    }
}
