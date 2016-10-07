using System;
using System.Data;
using System.Data.SqlClient;

namespace PopDataset
{
   class PopDataset
   {
      static void Main()
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
               unitprice
            from
               products
            where
               unitprice < 20
         ";

         // Create connection
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            // Open connection
            conn.Open();

            // Get data adapter
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            // Create and fill dataset
            DataSet ds = new DataSet();    
            da.Fill(ds, "products");

            // Get data table 
            DataTable dt = ds.Tables["products"];

            // Display data 
            foreach (DataRow row in dt.Rows)
            {
               foreach (DataColumn col in dt.Columns)
                  Console.WriteLine(row[col]);
               Console.WriteLine("".PadLeft(20, '='));
            }
         }
         catch(Exception e)
         {
            Console.WriteLine("Error: " + e);
         }
         finally
         {
            // Close connection
            conn.Close();
         }
      }  
   }
}
