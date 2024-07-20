using System;
using System.Data.SqlClient;

namespace Database_Operation
{

    class SelectStatement
    {

        // Main Method
        static void Main()
        {
            Read();
            Console.ReadKey();
        }

        static void Read()
        {
            string constr;

            SqlConnection conn;

            // Data Source is the name of the 
            // server on which the database is stored.
            // The Initial Catalog is used to specify
            // the name of the database
            // The UserID and Password are the credentials
            // required to connect to the database.
            constr = @"Data Source=LAPTOP-PPUJ4OAL\SQLEXPRESS;Initial Catalog=Demodb;User ID=sa;Password=cmcuni";

            conn = new SqlConnection(constr);


            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql, output = "";
            sql = "Select articleID, articleName from demo";
            cmd = new SqlCommand(sql, conn);
            dreader = cmd.ExecuteReader();

            // Đọc từng dòng (bản ghi)
            while (dreader.Read())
            {
                output = output + dreader.GetValue(0) + " - " +
                                    dreader.GetValue(1) + "\n";
            }

            Console.Write(output);

            // Đóng
            dreader.Close();
            cmd.Dispose();
            conn.Close();
        }
    }
}