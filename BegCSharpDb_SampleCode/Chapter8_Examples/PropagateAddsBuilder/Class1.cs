using System;
using System.Data;
using System.Data.SqlClient;

namespace PropagateAddsBuilder
{
   class PropagateAddsBuilder
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
         string qry = @"
            select
               *
            from
               employees
            where
               country = 'UK'
         ";
 
         // Create connection
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            //Create data adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(qry, conn);

            //Create command builder
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            // Create and fill dataset
            DataSet ds = new DataSet();   
            da.Fill(ds, "employees");

            // Get data table reference
            DataTable dt = ds.Tables["employees"];

            // Add a row
            DataRow newRow = dt.NewRow();
            newRow["firstname"] = "Roy";
            newRow["lastname"] = "Beatty";
            newRow["titleofcourtesy"] = "Sir";
            newRow["city"] = "Birmingham";
            newRow["country"] = "UK";
            dt.Rows.Add(newRow);

            // Display Rows
            foreach (DataRow row in dt.Rows)
            {
               Console.WriteLine(
                  "{0} {1} {2}",
                  row["firstname"].ToString().PadRight(15),
                  row["lastname"].ToString().PadLeft(25),
                  row["city"]);
            }

            // Insert employees
            da.Update(ds, "employees");
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
