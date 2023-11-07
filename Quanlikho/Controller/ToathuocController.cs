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
    internal class ToathuocController
    {
        List<Toathuoc> toathuocList;

        public ToathuocController()
        {
            toathuocList = new List<Toathuoc>();

        }
        public List<Toathuoc> load()
        {

            SqlConnection conn = Datahelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from toathuoc", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   
                    int stt = Convert.ToInt32(reader["stt"].ToString());
                    String mabenhnhan = reader["mabenhnhan"].ToString();
                    String benhduocchuandoan = reader["benhduocchuandoan"].ToString();
                    DateTime ngaykham = Convert.ToDateTime(reader["ngaykham"].ToString());
                    Toathuoc toathuoc = new Toathuoc(stt, mabenhnhan, benhduocchuandoan, ngaykham);
                    toathuocList.Add(toathuoc);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return toathuocList;
        }
        public Toathuoc get(int Stt)
        {

            foreach (Toathuoc toathuoc in toathuocList)
            {
                if (toathuoc.getStt() == Stt)
                {
                    return toathuoc;
                }
            }
            return null;

        }
        public bool insert(Toathuoc toathuoc)
        {

            Toathuoc newtoathuoc = new Toathuoc();
            toathuocList.Add(newtoathuoc);
            using (SqlConnection conn = Datahelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO toathuoc (stt, mabenhnhan, benhduocchuandoan, ngaykham) VALUES (@stt, @mabenhnhan, @benhduocchuandoan, @ngaykham)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@stt", toathuoc.getStt());
                    command.Parameters.AddWithValue("@mabenhnhan", toathuoc.getMabenhnhan());
                    command.Parameters.AddWithValue("@benhduocchuandoan", toathuoc.getBenhduocchuandoan());
                    command.Parameters.AddWithValue("@ngaykham", toathuoc.getNgaykham());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
