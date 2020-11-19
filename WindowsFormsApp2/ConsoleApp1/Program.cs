using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=test1;Persist Security Info=True;User ID=sa;Password=1234");
            sql.Open();

            SqlCommand cmd = new SqlCommand("insert into input(1,3,4,5)");
            cmd.ExecuteNonQuery();
            sql.Close();
        }
    }
}
