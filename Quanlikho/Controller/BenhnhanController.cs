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
    internal class BenhnhanController
    {
        List<Benhnhan> benhnhanList;

        public BenhnhanController()
        {
            benhnhanList = new List<Benhnhan>();

        }
        public List<Benhnhan> load()
        {

            SqlConnection conn = Datahelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from benhnhan", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String mabenhnhan = reader["mabenhnhan"].ToString();
                    String tenbenhnhan = reader["tenbenhnhan"].ToString();
                    int tuoi = Convert.ToInt32(reader["tuoi"].ToString());
                    String gioitinh = reader["gioitinh"].ToString();
                    String diachi = reader["diachi"].ToString();
                    Benhnhan benhnhan = new Benhnhan(mabenhnhan, tenbenhnhan, tuoi, gioitinh, diachi);
                    benhnhanList.Add(benhnhan);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { conn.Close(); }
            return benhnhanList;
        }
        public Benhnhan get(string Mabenhnhan)
        {

            foreach (Benhnhan benhnhan in benhnhanList)
            {
                if (benhnhan.getMabenhnhan() == Mabenhnhan)
                {
                    return benhnhan;
                }
            }
            return null;

        }
        public bool insert(Benhnhan benhnhan)
        {

            Benhnhan newbenhnhan = new Benhnhan();
            benhnhanList.Add(newbenhnhan);
            using (SqlConnection conn = Datahelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO benhnhan (mabenhnhan, tenbenhnhan, tuoi, gioitinh, diachi) VALUES (@mabenhnhan, @tenbenhnhan, @tuoi, @gioitinh, @diachi)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mabenhnhan", benhnhan.getMabenhnhan());
                    command.Parameters.AddWithValue("@tenbenhnhan", benhnhan.getTenbenhnhan());
                    command.Parameters.AddWithValue("@tuoi", benhnhan.getTuoi());
                    command.Parameters.AddWithValue("@gioitinh", benhnhan.getGioitinh());
                    command.Parameters.AddWithValue("@diachi", benhnhan.getDiachi());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool update(Benhnhan benhnhan)
        {
            using (SqlConnection conn = Datahelper.getConnection())
            {
                conn.Open();
                string query = "UPDATE benhnhan SET tenbenhnhan = @tenbenhnhan, tuoi = @tuoi, gioitinh = @gioitinh, diachi = @diachi  WHERE mabenhnhan = @mabenhnhan";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mabenhnhan", benhnhan.getMabenhnhan());
                    command.Parameters.AddWithValue("@tenbenhnhan", benhnhan.getTenbenhnhan());
                    command.Parameters.AddWithValue("@tuoi", benhnhan.getTuoi());
                    command.Parameters.AddWithValue("@gioitinh", benhnhan.getGioitinh());
                    command.Parameters.AddWithValue("@diachi", benhnhan.getDiachi());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool delete(String mabenhnhan)
        {
            using (SqlConnection conn = Datahelper.getConnection())
            {
                conn.Open();
                string query = "DELETE FROM benhnhan WHERE mabenhnhan = @mabenhnhan";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mabenhnhan", mabenhnhan);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        //Method name: isExist
        //Parameter: Tham so truyen 
        //String id: ma kho can kiem tra su ton tai
        //Output:
        //true neu id da ton tai trong csdl
        //false neu id chua ton tai trong csdl

        public bool isExist(String Ma_Benh_Nhan)
        {
            // Create a connection to the database
            SqlConnection conn = Datahelper.getConnection();
            try
            {
                // Open the connection
                conn.Open();

                // Create a command to check if the id exists in the QLKho table
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM benhnhan WHERE mabenhnhan = @mabenhnhan", conn);
                // Add a parameter for the id
                command.Parameters.AddWithValue("@mabenhnhan", Ma_Benh_Nhan);
                // Execute the command and get the result
                int count = (int)command.ExecuteScalar();
                // If the count is greater than zero, the id exists
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }
        public bool isExist(Benhnhan benhnhan)
        { // Kiểm tra xem đối tượng Kho có hợp lệ hay không
            if (benhnhan == null || string.IsNullOrEmpty(benhnhan.getMabenhnhan()))
            {
                return false;
            }

            // Tạo một kết nối đến cơ sở dữ liệu
            SqlConnection conn = Datahelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo một lệnh để kiểm tra xem mã kho của đối tượng Kho có tồn tại trong bảng QLKho hay không
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM benhnhan WHERE mabenhnhan = @mabenhnhan", conn);
                // Thêm một tham số cho mã kho
                command.Parameters.AddWithValue("@mabenhnhan", benhnhan.getMabenhnhan());
                // Thực thi lệnh và lấy kết quả
                int count = (int)command.ExecuteScalar();
                // Nếu số lượng lớn hơn không, tức là mã kho tồn tại
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Đóng kết nối
                conn.Close();
            }
        }
    }
}



