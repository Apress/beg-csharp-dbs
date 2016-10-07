using System;
using System.Data;
using System.Data.SqlClient;

namespace PropagateAdds
{
   class PropagateAdds
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
            insert into employees
            (
               firstname,
               lastname,
               titleofcourtesy,
               city,
               country
            )  
            values
            (   
               @firstname,
               @lastname,
               @titleofcourtesy,
               @city,
               @country
            )
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

            // Update employees
            //
            // 1. Create command
            SqlCommand cmd = new SqlCommand(upd, conn);
            //
            // 2. Map parameters
            cmd.Parameters.Add(
               "@firstname",
               SqlDbType.NVarChar,
               10,
               "firstname");
            cmd.Parameters.Add(
               "@lastname",
               SqlDbType.NVarChar,
               20,
               "lastname");
            cmd.Parameters.Add(
               "@titleofcourtesy",
               SqlDbType.NVarChar,
               25,
               "titleofcourtesy");
            cmd.Parameters.Add(
               "@city",
               SqlDbType.NVarChar,
               15,
               "city");
            cmd.Parameters.Add(
               "@country",
               SqlDbType.NVarChar,
               15,
               "country");
            //
            // 3. Update Employees
            da.InsertCommand = cmd;
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
