using System;
using System.Data;
using System.Data.SqlClient;

namespace MultipleResults
{
   class MultipleResults
   {
      static void Main(string[] args)
      {
         // Connection string 
         string connString = @"
            server = (local)\netsdk; 
            integrated security = sspi; 
            database = northwind
         ";

         // Query 1 
         string sql1 = @"
            select
               companyname,
               contactname
            from
               customers
            where
               companyname like 'A%'
         ";

         // Query 2 
         string sql2 = @"
            select
               firstname,
               lastname
            from
               employees
         ";

         // Combine queries 
         string sql = sql1 + sql2;

         // Pass connection string to connection 
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            // Open connection 
            conn.Open();

            // Get command 
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Get data reader 
            SqlDataReader reader = cmd.ExecuteReader();

            // Loop through result sets
            do
            {
            while(reader.Read())
            {
               // Print one row at a time 
               Console.WriteLine("{0} : {1}", reader[0], reader[1]);
            }
               Console.WriteLine("".PadLeft(60, '='));
            }
            while(reader.NextResult());

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
