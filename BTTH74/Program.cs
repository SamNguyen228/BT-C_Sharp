using System;
using System.Data.SqlClient;
namespace Database_Operation
{
    class InsertStatement
    {
        static void Main()
        {
            Insert();
            Console.ReadKey();
        }

        static void Insert()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=LAPTOP-PPUJ4OAL\SQLEXPRESS;Initial Catalog=Demodb;User ID=sa;Password=cmcuni";
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();
            string sql = "";
            sql = "insert into demo values(3, 'Python')";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}