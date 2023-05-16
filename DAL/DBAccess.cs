using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class sqlConnecTionData
    {
        public static SqlConnection connect()
        {
            string strcon = "Data Source=.;Initial Catalog=quan_trai_cay;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
    public class DBAccess
    {
        public string checkLoginDTO(NhanVien nhanvien)
        {
            string user = null;

            SqlConnection conn = sqlConnecTionData.connect();
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from nhanVien where taiKhoan = @taikhoan and matKhau = @matkhau", conn);
            command.Parameters.AddWithValue("@taikhoan", nhanvien.taiKhoan);
            command.Parameters.AddWithValue("@matkhau", nhanvien.matKhau);
            command.Connection= conn;
            SqlDataReader reader = command.ExecuteReader();

            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    user = reader.GetInt32(0).ToString();
                    return user;
                }
                reader.Close();
                conn.Close();

            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác";
            }

            return user;
        }
        
    }
}
