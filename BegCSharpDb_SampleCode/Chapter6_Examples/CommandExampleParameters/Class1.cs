using System;
using System.Data;
using System.Data.SqlClient;
namespace CommandExampleParameters
{
   class CommandExampleParameters
   {
      static void Main() 
      {
         // create SqlConnection object
         SqlConnection thisConnection = new SqlConnection(
            @"Server=(local)\NetSDK;"     + 
            "Integrated Security=SSPI;"   +
            "Database=tempdb;");

         // create SqlCommands 
         SqlCommand nonqueryCommand = thisConnection.CreateCommand();

         try 
         {
            // open connection
            thisConnection.Open();

            // execute nonquery to create temporary table
            nonqueryCommand.CommandText = 
               "CREATE TABLE MyTable (MyName VARCHAR (30), MyNumber integer)";
            Console.WriteLine(nonqueryCommand.CommandText);
            Console.WriteLine("Number of Rows Affected is: {0}",
               nonqueryCommand.ExecuteNonQuery());

            // create INSERT command with named parameters
            nonqueryCommand.CommandText = 
               "INSERT INTO MyTable VALUES (@MyName, @MyNumber)";

            // add parameters to Command Parameters collection
            nonqueryCommand.Parameters.Add("@MyName", SqlDbType.VarChar, 30);
            nonqueryCommand.Parameters.Add("@MyNumber", SqlDbType.Int);
        
            // prepare INSERT command for repeated execution
            nonqueryCommand.Prepare();
        
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
         }
         catch (SqlException ex) 
         {
            Console.WriteLine(ex.ToString());
         }
         finally 
         {  
            thisConnection.Close();
            Console.WriteLine("Connection Closed.");
         }
      }
   }
}
