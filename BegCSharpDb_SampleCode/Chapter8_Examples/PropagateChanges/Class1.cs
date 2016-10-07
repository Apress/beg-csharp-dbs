using System;
using System.Data;
using System.Data.SqlClient;

namespace PropagateChanges
{
   class PropagateChanges
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

         // SQL to update Employees
         string upd = @"
            update employees   
            set
               city = @city
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

            // Modify City in first row
            dt.Rows[0]["city"] = "Wilmington";

            // Display Rows
            foreach (DataRow row in dt.Rows)
            {
               Console.WriteLine(
                  "{0} {1} {2}",
                  row["firstname"].ToString().PadRight(15),
                  row["lastname"].ToString().PadLeft(25),
                  row["city"]);
            }

            // Update employees
            //
            // 1. Create command
            SqlCommand cmd = new SqlCommand(upd, conn);
            //
            // 2. Map parameters
            //
            // 2.1. City
            cmd.Parameters.Add(
               "@city",
               SqlDbType.NVarChar,
               15,
               "city");
            //
            // 2.2. Employee ID
            SqlParameter parm =
               cmd.Parameters.Add(
               "@employeeid",
               SqlDbType.Int,
               4,
               "employeeid");
            parm.SourceVersion = DataRowVersion.Original;
            //
            // 3. Update Employees
            da.UpdateCommand = cmd;
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
