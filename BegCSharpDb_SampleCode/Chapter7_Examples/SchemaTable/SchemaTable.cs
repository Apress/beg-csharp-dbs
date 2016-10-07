using System;
using System.Data;
using System.Data.SqlClient;

namespace SchemaTable
{
   class SchemaTable
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
               *
            from
               employees
         ";

         // Pass connection string to connection 
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            // Store the Employees schema in a data table
            DataTable schema = reader.GetSchemaTable();

            // Display info from each row in the data table.
            // Each row describes a column in the database table.
            foreach (DataRow row in schema.Rows)
            { 
               foreach (DataColumn col in schema.Columns)
                  //Console.WriteLine(col.ColumnName + " = " + row[col]);
  Console.WriteLine("Null value allowed: " + col.AllowDBNull);
               Console.WriteLine("----------------");
            }

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
