using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbtest
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source = .; Initial Catalog = test_db; Integrated Security = True");
            conn.Open();
            string query = "insert into sales(salecode,customercode,itemcode,data,qty,price) values  (1, '홍길동', '컴퓨터', '2024-08-02', 10, 10000)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


        }
    }
}
