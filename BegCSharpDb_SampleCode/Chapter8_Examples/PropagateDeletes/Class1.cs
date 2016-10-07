using System;
using System.Data;
using System.Data.SqlClient;

namespace PropagateDeletes
{
   class PropagateDeletes
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

         // SQL to delete employees
         string del = @"
            delete from employees
            where
               employeeid = @employeeid
         ";

         // Create connection
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            //Create data adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(qry, conn);

            // Create and fill dataset
            DataSet ds = new DataSet();   
            da.Fill(ds, "employees");

            // Get data table reference
            DataTable dt = ds.Tables["employees"];

            // Delete employees
            //
            // 1. Create command
            SqlCommand cmd = new SqlCommand(del, conn);
            //
            // 2. Map parameters
            cmd.Parameters.Add(
               "@employeeid",
               SqlDbType.Int,
               4,
               "employeeid");
            //
            // 3. Select employees
            string filt = @"
                  firstname = 'Roy'
                  and
                  lastname = 'Beatty'
            ";
            //
            // 4. Delete employees
            foreach (DataRow row in dt.Select(filt))
            {
               row.Delete();
            }
            da.DeleteCommand = cmd;
            da.Update(ds, "employees");

            // Display Rows
            foreach (DataRow row in dt.Rows)
            {
               Console.WriteLine(
                  "{0} {1} {2}",
                  row["firstname"].ToString().PadRight(15),
                  row["lastname"].ToString().PadLeft(25),
                  row["city"]);
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
