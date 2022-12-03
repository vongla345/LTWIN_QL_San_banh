using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBanh.Object
{
    internal class NhanVien
    {
        string maNV, tenNV, gioiTinh, sdt, diaChi, matKhau;
        DateTime ngaySinh = new DateTime();
        bool admin;

        public NhanVien()
        {
            this.maNV = "";
            this.tenNV = "";
            this.gioiTinh = "";
            this.sdt = "";
            this.diaChi = "";
            this.matKhau = "";
            this.admin = false;
        }

        public NhanVien(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string sdt, string diaChi, string matKhau, bool admin)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.matKhau = matKhau;
            this.ngaySinh = ngaySinh;
            this.admin = admin;
        }

        public string xuat ()
        {
            string tmp = ngaySinh.ToString("dd-MM-yyyy");
            return tmp;
        }
        
    }
}
