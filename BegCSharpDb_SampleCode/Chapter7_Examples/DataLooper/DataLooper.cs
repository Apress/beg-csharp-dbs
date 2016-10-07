using System;
using System.Data; 
using System.Data.SqlClient; 

namespace DataLooper 
{
   class DataLooper
   {
      static void Main(string[] args)
      {
         // Connection string
         string connString = @"
            server = (local)\netsdk; 
            integrated security = sspi;
            database = northwind
         ";

         // Query 
         string sql = @"
            select
               contactname
            from
               customers
         ";

         // Pass connection string to the connection 
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            // Open connection 
            conn.Open();

            // Pass query string and connection to the command 
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Get a data reader 
            SqlDataReader reader = cmd.ExecuteReader();

            // Loop through the record set
            while(reader.Read())
            {
               // Print one row at a time 
               Console.WriteLine("{0}", reader[0]);
            }

            // Close data reader
            reader.Close();
         }
         catch(Exception e)
         {
            Console.WriteLine("Error Occurred: " + e);
         }
         finally
         {
            //Close connection
            conn.Close();
         }
      }
   } 
}
