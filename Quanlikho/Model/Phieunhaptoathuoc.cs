using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Model
{
    internal class Phieunhaptoathuoc
    {
        private String maphieunhap;
        private String sohoadon;
        private String mabenhnhan;
        private DateTime ngaykham;
        private DateTime ngayhoadon;
        private String diachi;

        public Phieunhaptoathuoc() { }
        public Phieunhaptoathuoc(String maphieunhap, String sohoadon, String mabenhnhan, DateTime ngaykham, DateTime ngayhoadon, String diachi)
        {
            this.maphieunhap = maphieunhap;
            this.sohoadon = sohoadon;
            this.mabenhnhan = mabenhnhan;
            this.ngaykham = ngaykham;
            this.ngayhoadon = ngayhoadon;
            this.diachi = diachi;

        }

        public String getMaphieunhap() { return maphieunhap; }
        public String getSohoadon() { return sohoadon; }
        public String getMabenhnhan() { return mabenhnhan; }
        public DateTime getNgaykham() { return ngaykham; }
        public DateTime getNgayhoadon() { return ngayhoadon; }
        public String getDiachi() { return diachi; }



        public void setMaphieunhap(string maphieunhap) { this.maphieunhap = maphieunhap; }
        public void setSohoadon(string sohoadon) { this.sohoadon = sohoadon; }
        public void setMabenhnhan(string mabenhnhan) { this.mabenhnhan = mabenhnhan; }
        public void setNgaykham(DateTime ngaykham) { this.ngaykham = ngaykham; }
        public void setNgayhoadon(DateTime ngayhoadon) { this.ngayhoadon = ngayhoadon; }
        public void setDiachi(string diachi) { this.diachi = diachi; }



        public String toString()
        {
            return maphieunhap + sohoadon + mabenhnhan + ngaykham + ngayhoadon + diachi;
        }
    }
}

