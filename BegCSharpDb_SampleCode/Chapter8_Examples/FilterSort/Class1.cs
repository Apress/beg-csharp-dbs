using System;
using System.Data;
using System.Data.SqlClient;

namespace FilterSort
{
   class FilterSort
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
               *
            from
               customers
         ";

         // Query 2 
         string sql2 = @"
            select
               *
            from
               products
            where
               unitprice < 10
         ";

         // Combine queries 
         string sql = sql1 + sql2;

         // Create connection
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            //Create data adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(sql, conn);

            //Create and fill data set
            DataSet ds = new DataSet();
            da.Fill(ds, "customers");

            // Get the data tables collection 
            DataTableCollection dtc = ds.Tables;

            // Display data from first data table
            // 
            // 1. Display output header 
            Console.WriteLine("Results from Customers table:");
            Console.WriteLine(
               "CompanyName".PadRight(20) +
               "ContactName".PadLeft(23) + "\n");
            // 2. Set display filter 
            string fl = "country = 'Germany'";
            // 3. Set sort 
            string srt = "companyname asc";
            // 4. Display filtered and sorted data 
            foreach (DataRow row in dtc["customers"].Select(fl, srt))
            {
               Console.WriteLine(
                  "{0}\t{1}", 
                  row["CompanyName"].ToString().PadRight(25),
                  row["ContactName"]);
            }

            // Display data from second data table
            // 
            // 1. Display output header 
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Results from Products table:");
            Console.WriteLine(
               "ProductName".PadRight(20) + 
               "UnitPrice".PadLeft(21) + "\n");
            // 2. Display data
            foreach (DataRow row in dtc[1].Rows)
            {
               Console.WriteLine("{0}\t{1}", 
                  row["productname"].ToString().PadRight(25),
                  row["unitprice"]);
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
