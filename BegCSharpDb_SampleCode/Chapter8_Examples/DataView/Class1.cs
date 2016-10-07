using System;
using System.Data;
using System.Data.SqlClient;

namespace DataViewExample
{
   class DataViewExample
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
               contactname,
               country
            from
               customers
         ";

         // Create connection
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            //Create data adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(sql, conn);

            //Create and fill dataset
            DataSet ds = new DataSet();
            da.Fill(ds, "customers");

            //Get data table reference
            DataTable dt = ds.Tables["customers"];

            // Create data view
            DataView dv = new DataView(
               dt,
               "country = 'Germany'", 
               "country", 
               DataViewRowState.CurrentRows);

            // Display data from data view
            foreach (DataRowView drv in dv)
            {
               for (int i = 0; i < dv.Table.Columns.Count; i++)
                  Console.Write(drv[i] + "\t");
               Console.WriteLine();
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
