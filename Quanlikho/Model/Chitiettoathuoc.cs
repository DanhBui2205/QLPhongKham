using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Model
{
    internal class Chitiettoathuoc
    {
        private String id;
        private String maphieunhap;
        private String mathuoc;
        private int stt;
        private int soluong;
        private String lieudung;
        private int dongia;

        public Chitiettoathuoc() { }
        public Chitiettoathuoc(String id, String maphieunhap, String mathuoc, int stt, int soluong, String lieudung, int dongia)
        {
            this.id = id;
            this.maphieunhap = maphieunhap;
            this.mathuoc = mathuoc;
            this.stt = stt;
            this.soluong = soluong;
            this.lieudung = lieudung;
            this.dongia = dongia;
        }

        public String getId() { return id; }
        public String getMaphieunhap() {  return maphieunhap; }
        public String getMathuoc() { return mathuoc; }
        public int getStt() { return stt; }
        public int getSoluong() { return soluong; }
        public String getLieudung() { return lieudung; }
        public int getDongia() { return dongia; }



        public void setId(string id) { this.id = id; }
        public void setMaphieunhap(string maphieunhap) { this.maphieunhap = maphieunhap; }
        public void setMathuoc(string mathuoc) { this.mathuoc = mathuoc; }
        public void setStt(int stt) { this.stt = stt; }
        public void setSoluong(int soluong) { this.soluong = soluong; }
        public void setLieudung(string lieudung) { this.lieudung = lieudung; }
        public void setDongia(int dongia) { this.dongia = dongia; }



        public String toString()
        {
            return id + maphieunhap + mathuoc + stt + soluong + lieudung + dongia;
        }

        
    }
}

