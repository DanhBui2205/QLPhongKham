using Quanlikho.Model;
using Quanlikho.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikho.Controller
{
    internal class PhieunhaptoathuocController
    {
        List<Phieunhaptoathuoc> phieunhaptoathuocList;

        public PhieunhaptoathuocController()
        {
            phieunhaptoathuocList = new List<Phieunhaptoathuoc>();

        }
        public List<Phieunhaptoathuoc> load()
        {

            SqlConnection conn = Datahelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from phieunhaptoathuoc", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String maphieunhap = reader["maphieunhap"].ToString();
                    String sohoadon = reader["sohoadon"].ToString();
                    String mabenhnhan = reader["mabenhnhan"].ToString();
                    DateTime ngaykham = Convert.ToDateTime(reader["ngaykham"].ToString());
                    DateTime ngayhoadon = Convert.ToDateTime(reader["ngayhoadon"].ToString());
                    String diachi = reader["diachi"].ToString();
                    
                    Phieunhaptoathuoc phieunhaptoathuoc = new Phieunhaptoathuoc(maphieunhap, sohoadon, mabenhnhan, ngaykham, ngayhoadon, diachi);
                    phieunhaptoathuocList.Add(phieunhaptoathuoc);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return phieunhaptoathuocList;
        }
        public Phieunhaptoathuoc get(string Maphieunhap)
        {

            foreach (Phieunhaptoathuoc phieunhaptoathuoc in phieunhaptoathuocList)
            {
                if (phieunhaptoathuoc.getMaphieunhap() == Maphieunhap)
                {
                    return phieunhaptoathuoc;
                }
            }
            return null;
        }
        public bool insert(Phieunhaptoathuoc phieunhaptoathuoc)
        {

            SqlConnection conn = Datahelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO phieunhaptoathuoc(maphieunhap, sohoadon, mabenhnhan, ngaykham, ngayhoadon, diachi)  VALUES (@maphieunhap, @sohoadon, @mabenhnhan, @ngaykham, @ngayhoadon, @diachi)", conn);
                command.Parameters.AddWithValue("@maphieunhap", phieunhaptoathuoc.getMaphieunhap());
                command.Parameters.AddWithValue("@sohoadon", phieunhaptoathuoc.getSohoadon());
                command.Parameters.AddWithValue("@mabenhnhan", phieunhaptoathuoc.getMabenhnhan());
                command.Parameters.AddWithValue("@ngaykham", phieunhaptoathuoc.getNgaykham());
                command.Parameters.AddWithValue("@ngayhoadon", phieunhaptoathuoc.getNgayhoadon());
                command.Parameters.AddWithValue("@diachi", phieunhaptoathuoc.getDiachi());
                
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
            return false;
        }
    }
}
