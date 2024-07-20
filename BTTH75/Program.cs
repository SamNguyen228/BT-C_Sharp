using System;
using System.Data.SqlClient;
namespace Database_Operation
{
    class UpdateStatement
    {
        // Main Method
        static void Main()
        {
            Update();
            Console.ReadKey();
        }
        static void Update()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=LAPTOP-PPUJ4OAL\SQLEXPRESS;Initial Catalog=Demodb;User ID=sa;Password=cmcuni";
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();
            string sql = "";
            sql = "update demo set articleName='django' where articleID=3";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            // Đóng các đối tượng
            cmd.Dispose();
            conn.Close();
        }
    }
}