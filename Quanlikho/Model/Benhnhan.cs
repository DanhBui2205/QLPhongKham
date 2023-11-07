using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Model
{
    internal class Benhnhan
    {
        private String mabenhnhan;
        private String tenbenhnhan;
        private int tuoi;
        private String gioitinh;
        private String diachi;
        

        public Benhnhan () { }
        public Benhnhan(String mabenhnhan, String tenbenhnhan, int tuoi, String gioitinh, String diachi)
        {
            this.mabenhnhan = mabenhnhan;
            this.tenbenhnhan = tenbenhnhan;
            this.tuoi = tuoi;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
          

        }

        public String getMabenhnhan() { return mabenhnhan; }
        public String getTenbenhnhan() { return tenbenhnhan; }
        public int getTuoi() { return tuoi; }
        public String getGioitinh() { return gioitinh; }
        public String getDiachi() { return diachi; }
       



        public void setMabenhnhan(string mabenhnhan) { this.mabenhnhan = mabenhnhan; }
        public void setTenbenhnhan(string tenbenhnhan) { this.tenbenhnhan = tenbenhnhan; }
        public void setTuoi(int tuoi) { this.tuoi = tuoi; }
        public void setGioitinh(string gioitinh) { this.gioitinh = gioitinh; }
        public void setDiachi(string diachi) { this.diachi = diachi; }
        



        public String toString()
        {
            return mabenhnhan + tenbenhnhan + tuoi + gioitinh + diachi;
        }
    }
}

