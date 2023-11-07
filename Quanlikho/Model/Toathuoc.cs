using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Model
{
    internal class Toathuoc
    {
        private int stt;
        private String mabenhnhan;
        private String benhduocchuandoan;
        private DateTime ngaykham;
        


        public Toathuoc() { }
        public Toathuoc(int stt, String mabenhnhan, String benhduocchuandoan, DateTime ngaykham)
        {
            this.stt = stt;
            this.mabenhnhan = mabenhnhan;
            this.benhduocchuandoan = benhduocchuandoan;
            this.ngaykham = ngaykham;
            


        }

        public int getStt() { return stt; }
        public String getMabenhnhan() { return mabenhnhan; }
        public String getBenhduocchuandoan() { return benhduocchuandoan; }
        public DateTime getNgaykham() { return ngaykham; }
       




        public void setStt(int stt) { this.stt = stt; }
        public void setMabenhnhan(string mabenhnhan) { this.mabenhnhan = mabenhnhan; }
        public void setBenhduocchuandoan(string benhduocchuandoan) { this.benhduocchuandoan = benhduocchuandoan; }
        public void setNgaykham(DateTime ngaykham) { this.ngaykham = ngaykham; }
       




        public String toString()
        {
            return stt + mabenhnhan + benhduocchuandoan + ngaykham ;
        }
    }
}

