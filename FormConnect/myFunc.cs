using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormConnect
{
    public class myFunc
    {
        public static string _srv;
        public static string _us;
        public static string _pw;
        public static string _db;
        static SqlConnection conn = new SqlConnection();
        public static void CreateConnect()
        {
            conn.ConnectionString = "Data Source = ASUS; Initial Catalog = Hotels; User ID = sa; Password = 1234";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi ket noi " + ex.Message);
            }
        }

        public static void Close()
        {
            conn.Close();
        }
        public static DataTable layDuLieu(string qr)
        {
            CreateConnect();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand(qr, conn);
            dap.Fill(dt);
            Close();
            return dt;
        }


        public static DateTime GetFirstDayOfMonth(int year, int month)
        {
            return new DateTime(year, month, 1);
        }


    }
}
