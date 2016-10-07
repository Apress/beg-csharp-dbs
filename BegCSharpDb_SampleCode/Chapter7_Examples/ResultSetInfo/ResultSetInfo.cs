using System;
using System.Data;
using System.Data.SqlClient;

namespace ResultSetInfo
{
   class ResultSetInfo
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
               contactname,
               contacttitle
            from
               customers
            where
               contactname like 'M%'
         ";

         // Pass connection string to connection
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
      
            SqlDataReader reader = cmd.ExecuteReader();

            // Get column names 
            Console.WriteLine(
               "Column Name:\t{0} {1}",
               reader.GetName(0).PadRight(25),
               reader.GetName(1));

            // Get column data types 
            Console.WriteLine(
               "Data Type:\t{0} {1}", 
               reader.GetDataTypeName(0).PadRight(25),
               reader.GetDataTypeName(1));

            Console.WriteLine();

            while(reader.Read())
            {
               // Get column values for all rows 
               Console.WriteLine(
                  "\t\t{0} {1}", 
                  reader.GetString(0).ToString().PadRight(25),
                  reader.GetString(1));
            }

            // Get number of columns 
            Console.WriteLine();
            Console.WriteLine(
               "Number of columns in a row: {0}",
               reader.FieldCount);

            // Get info about each column 
            Console.WriteLine(
               "'{0}' is at index {1} " + 
               "and its type is: {2}", 
               reader.GetName(0),
               reader.GetOrdinal("contactname"),
               reader.GetFieldType(0));

            Console.WriteLine(
               "'{0}' is at index {1} " + 
               "and its type is: {2}", 
               reader.GetName(1), 
               reader.GetOrdinal("contacttitle"),
               reader.GetFieldType(1));

            reader.Close();
         }
         catch(Exception e)
         {
            Console.WriteLine("Error Occurred: " + e);
         }
         finally
         {
            conn.Close();
         }
      }  
   }
}
