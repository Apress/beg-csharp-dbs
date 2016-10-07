using System;
using System.Data;
using System.Data.Odbc;
namespace CommandOdbcExample
{
   class CommandOdbcExample
   {
      static void Main() 
      {
         // create OdbcConnection object
         OdbcConnection thisConnection = new OdbcConnection(
            "DRIVER={MySQL ODBC 3.51 Driver};" +   
            "SERVER=localhost;" +   
            "DATABASE=test;" +   
            "UID=root;" +
            "PASSWORD=;");        

         // create OdbcCommands 
         OdbcCommand nonqueryCommand = thisConnection.CreateCommand();

         try 
         {
            // open connection
            thisConnection.Open();

            // execute nonquery to create temporary table
            nonqueryCommand.CommandText = 
               "CREATE TABLE MyTable (MyName VARCHAR (30), MyNumber integer)";
            Console.WriteLine(nonqueryCommand.CommandText);
            nonqueryCommand.ExecuteNonQuery();

            // create INSERT command with ? unnamed parameters
            nonqueryCommand.CommandText = 
               "INSERT INTO MyTable VALUES (?, ?)";

            // add parameters to command Parameters collection
            nonqueryCommand.Parameters.Add("@MyName", OdbcType.VarChar, 30);
            nonqueryCommand.Parameters.Add("@MyNumber", OdbcType.Int);
        
            // prepare not supported by current version of myODBC and mySQL
            // nonqueryCommand.Prepare();
        
            // data to be inserted
            string[] names = { "Enrico", "Franco", "Gloria", "Horace" } ;
            int i;
            for (i=1; i<=4; i++)
            {
               nonqueryCommand.Parameters["@MyName"].Value = names[i-1];
               nonqueryCommand.Parameters["@MyNumber"].Value = i;
               Console.WriteLine(nonqueryCommand.CommandText);
               Console.WriteLine("Number of Rows Affected is: {0}",
                  nonqueryCommand.ExecuteNonQuery());
            }

            // check to see the data we inserted
            nonqueryCommand.CommandText =
               "SELECT MyName, MyNumber FROM MyTable";
            OdbcDataReader thisReader = nonqueryCommand.ExecuteReader();

            while (thisReader.Read())
            {
               Console.WriteLine("Name and Number: {0} {1}",
                  thisReader.GetValue(0),
                  thisReader.GetValue(1));
            }
            // close the reader so we can execute another command
            thisReader.Close();

            // drop temporary table
            nonqueryCommand.CommandText = "DROP TABLE MyTable";
            nonqueryCommand.ExecuteNonQuery();
         } 
         catch (OdbcException ex) 
         {
            Console.WriteLine(ex.ToString());
         }
         finally 
         {  
            thisConnection.Close();  // close connection
            Console.WriteLine("Connection Closed.");
         }
      }
   }
}
