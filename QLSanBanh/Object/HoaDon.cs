using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBanh.Object
{
    internal class HoaDon
    {
        string maDon, maSan, tenSan, maNV, tenNV, tenNguoiDat, thoiGianDat;
        int thoiLuong, giaSan, tongTien;

        public HoaDon()
        {
            this.maDon = "";
        }
        public HoaDon(string maDon, string maSan, string tenSan, string maNV, string tenNV, string tenNguoiDat, string thoiGianDat, int thoiLuong, int giaSan)
        {
            this.maDon = maDon;
            this.maSan = maSan;
            this.tenSan = tenSan;
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.tenNguoiDat = tenNguoiDat;
            this.thoiGianDat = thoiGianDat;
            this.thoiLuong = thoiLuong;
            this.giaSan = giaSan;
        }

        public int tinhTien()
        {
            return thoiLuong * giaSan;
        }
    }
}
