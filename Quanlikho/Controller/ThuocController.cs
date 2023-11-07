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
    internal class ThuocController
    {
        List<Thuoc> thuocList;

        public ThuocController()
        {
            thuocList = new List<Thuoc>();

        }
        public List<Thuoc> load()
        {

            SqlConnection conn = Datahelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from thuoc", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String mathuoc = reader["mathuoc"].ToString();
                    String tenthuoc = reader["tenthuoc"].ToString();
                    String nuocsx = reader["nuocsx"].ToString();
                    String loaithuoc = reader["loaithuoc"].ToString();
                    DateTime hansudung = Convert.ToDateTime(reader["hansudung"].ToString());
                    String ghichu = reader["ghichu"].ToString();

                    Thuoc thuoc = new Thuoc(mathuoc, tenthuoc, nuocsx, loaithuoc, hansudung, ghichu);
                    thuocList.Add(thuoc);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return thuocList;
        }
        public Thuoc get(string Mathuoc)
        {

            foreach (Thuoc thuoc in thuocList)
            {
                if (thuoc.getMathuoc() == Mathuoc)
                {
                    return thuoc;
                }
            }
            return null;
        }

        public bool insert(Thuoc thuoc)
        {

            Thuoc newthuoc = new Thuoc();
            thuocList.Add(newthuoc);
            using (SqlConnection conn = Datahelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO thuoc (mathuoc, tenthuoc, nuocsx, loaithuoc, hansudung, ghichu) VALUES (@mathuoc, @tenthuoc, @nuocsx, @loaithuoc, @hansudung, @ghichu)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    command.Parameters.AddWithValue("@mathuoc", thuoc.getMathuoc());
                    command.Parameters.AddWithValue("@tenthuoc", thuoc.getTenthuoc());
                    command.Parameters.AddWithValue("@nuocsx", thuoc.getNuocsx());
                    command.Parameters.AddWithValue("@loaithuoc", thuoc.getLoaithuoc());
                    command.Parameters.AddWithValue("@hansudung", thuoc.getHansudung());
                    command.Parameters.AddWithValue("@ghichu", thuoc.getGhichu());

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
