using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Model
{
    internal class Thuoc
    {
        private String mathuoc;
        private String tenthuoc;
        private String nuocsx;
        private String loaithuoc;
        private DateTime hansudung;
        private String ghichu;
        
        public Thuoc() { }
        public Thuoc(String mathuoc, String tenthuoc, String nuocsx, String loaithuoc, DateTime hansudung, String ghichu)
        {
            this.mathuoc = mathuoc;
            this.tenthuoc = tenthuoc;
            this.nuocsx = nuocsx;
            this.loaithuoc = loaithuoc;
            this.hansudung = hansudung;
            this.ghichu = ghichu;
            
        }

        public String getMathuoc() { return mathuoc; }
        public String getTenthuoc() { return tenthuoc; }
        public String getNuocsx() { return nuocsx; }
        public String getLoaithuoc() { return loaithuoc; }
        public DateTime getHansudung() { return hansudung; }
        public String getGhichu() { return ghichu; }
        


        public void setMathuoc(string mathuoc) { this.mathuoc = mathuoc; }
        public void setTenthuoc(string tenthuoc) { this.tenthuoc = tenthuoc; }
        public void setNuocsx(string nuocsx) { this.nuocsx = nuocsx; }
        public void setLoaithuoc(string loaithuoc) { this.loaithuoc = loaithuoc; }
        public void setHansudung(DateTime hansudung) { this.hansudung = hansudung; }
        public void setGhichu(string ghichu) { this.ghichu = ghichu; }
        


        public String toString()
        {
            return mathuoc + tenthuoc + nuocsx + loaithuoc + hansudung + ghichu;
        }
    }
}

