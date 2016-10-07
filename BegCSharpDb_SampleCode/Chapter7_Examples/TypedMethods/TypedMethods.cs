using System;
using System.Data;
using System.Data.SqlClient;

namespace TypedMethods
{
   class TypedMethods
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
               productname,
               unitprice,
               unitsinstock,
               discontinued
            from
               products
         ";

    
         // Pass connection string to connection 
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            // Open connection 
            conn.Open();

            // Create command 
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Get data reader 
            SqlDataReader reader = cmd.ExecuteReader();

            // Fetch data 
            while(reader.Read())
            {
               Console.WriteLine(
                  "{0}\t {1}\t\t {2}\t {3}", 
                  // nvarchar
                  reader.GetString(0).PadRight(30),
                  // money
                  reader.GetDecimal(1),
                  // smallint
                  reader.GetInt16(2),
                  // bit
                  reader.GetBoolean(3));
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
            // Close connection 
            conn.Close();
         }
      }
   }
}
