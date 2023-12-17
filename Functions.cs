using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; // su dung doi tuong messagebox

namespace SalesShop
{
    class Functions
    {
        public static SqlConnection con;
        public static void Connect()
        {
            con = new SqlConnection(); // khoi tao connection
            con.ConnectionString = Properties.Settings.Default.QLBanHangConnectionString;

            // kiem tra ket noi
            if(con.State != ConnectionState.Open)
            {
                con.Open();
                MessageBox.Show("Kết nối thành công!");
            }
            else
            {
                MessageBox.Show("Kết nối không thành công!");
            }
        }

        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();   	//Đóng kết nối
                con.Dispose(); 	//Giải phóng tài nguyên
                con = null;
            }
        }
    }
}
