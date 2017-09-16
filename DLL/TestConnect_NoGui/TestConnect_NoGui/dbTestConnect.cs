using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace TestConnect_NoGui
{
    public class dbTestConnect
    {
        private SqlConnection conn;
        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }


        public dbTestConnect(string s)
        {
            conn = new SqlConnection(s);
        }
        
        public void Connect()
        {
            if (conn != null && conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void Disconnet()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        
        /// thực hiện câu lệnh truy vấn bảng dữ liệu
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader();
        }

        public int testConnect(string sl)//Kiem tra ket noi DB
        {
            SqlDataReader rdr = ExecuteReader(sl);
            if (rdr.Read())
            {
                rdr.Close();
                return 1;
            }
            else
            {
                rdr.Close();
                return 0;
            }
        }
        /// thực hiện câu lệnh truy vấn không trả về giá trị (update insert)
        public int ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }

        /// thực hiện nhưng câu lệnh trả về đơn giá trị
        public object ExecuteScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteScalar();
        }

    }
}
