using System;
using System.Data; 
using System.Data.SqlClient; 

namespace OrdinalIndexer
{
   class OrdinalIndexer
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
               companyname,
               contactname
            from
               customers
            where
               contactname like 'M%'
         ";

         // Pass connection string to connection 
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            // Open connection 
            conn.Open();

            // Pass query string and connection command 
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Get data reader 
            SqlDataReader reader = cmd.ExecuteReader();

            // Print titles 
            Console.WriteLine("\t{0}   {1}",
               "Company Name".PadRight(25),
               "Contact Name".PadRight(20));

            Console.WriteLine("\t{0}   {1}",
               "============".PadRight(25),
               "============".PadRight(20));

            // Loop through result set
            while(reader.Read())
            {
               Console.WriteLine(" {0} | {1}", 
                  reader[0].ToString().PadLeft(25),
                  reader[1].ToString().PadLeft(20));
            }

            // Close reader
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
