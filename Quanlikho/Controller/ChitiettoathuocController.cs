using Quanlikho.Model;
using Quanlikho.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlikho.Controller
{
    internal class ChitiettoathuocController
    {
        List<Chitiettoathuoc> chitiettoathuocList;

        public ChitiettoathuocController()
        {
            chitiettoathuocList = new List<Chitiettoathuoc>();

        }
        public List<Chitiettoathuoc> load()
        {

            SqlConnection conn = Datahelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from chitiettoathuoc", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String id = reader["id"].ToString();
                    string maphieunhap = reader["maphieunhap"].ToString();
                    String mathuoc = reader["mathuoc"].ToString();
                    int stt = Convert.ToInt32(reader["stt"].ToString());
                    int soluong = Convert.ToInt32(reader["soluong"].ToString());
                    String lieudung = reader["lieudung"].ToString();
                    int dongia = Convert.ToInt32(reader["dongia"].ToString());
                    Chitiettoathuoc chitiettoathuoc = new Chitiettoathuoc(id, maphieunhap, mathuoc, stt, soluong, lieudung, dongia);
                    chitiettoathuocList.Add(chitiettoathuoc);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return chitiettoathuocList;
        }
        public Chitiettoathuoc get(string id)
        {

            foreach (Chitiettoathuoc chitiettoathuoc in chitiettoathuocList)
            {
                if (chitiettoathuoc.getId() == id)
                {
                    return chitiettoathuoc;
                }
            }
            return null;

        }
        public bool insert(Chitiettoathuoc chitiettoathuoc)
        {

            Chitiettoathuoc newchitiettoathuoc = new Chitiettoathuoc();
            chitiettoathuocList.Add(newchitiettoathuoc);
            using (SqlConnection conn = Datahelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO chitiettoathuoc ( maphieunhap,mathuoc, stt, soluong, lieudung, dongia) VALUES (@maphieunhap, @mathuoc, @stt, @soluong, @lieudung, @dongia)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@maphieunhap", chitiettoathuoc.getMaphieunhap());
                    command.Parameters.AddWithValue("@mathuoc", chitiettoathuoc.getMathuoc());
                    command.Parameters.AddWithValue("@stt", chitiettoathuoc.getStt());
                    command.Parameters.AddWithValue("@soluong", chitiettoathuoc.getSoluong());
                    command.Parameters.AddWithValue("@lieudung", chitiettoathuoc.getLieudung());
                    command.Parameters.AddWithValue("@dongia", chitiettoathuoc.getDongia());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
