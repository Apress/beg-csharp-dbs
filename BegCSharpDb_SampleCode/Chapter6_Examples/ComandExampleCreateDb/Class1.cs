using System;
using System.Data;
using System.Data.SqlClient;
namespace CommandExampleCreateDb
{
   class CommandExampleCreateDb
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

            // create new database called MyDatabase
            nonqueryCommand.CommandText = "CREATE DATABASE MyDb";
            Console.WriteLine(nonqueryCommand.CommandText);

            // always returns -1, no need to display return value
            nonqueryCommand.ExecuteNonQuery();
            Console.WriteLine("Database created, now switching");
            thisConnection.ChangeDatabase("MyDb");

            // execute nonquery to create temporary table
            nonqueryCommand.CommandText =
               "CREATE TABLE MyTmpTable (COL1 integer)";
            Console.WriteLine(nonqueryCommand.CommandText);
            Console.WriteLine("Number of Rows Affected is: {0}",
               nonqueryCommand.ExecuteNonQuery());

            // execute nonquery to insert some data
            nonqueryCommand.CommandText = "INSERT INTO MyTmpTable VALUES (37)";
            Console.WriteLine(nonqueryCommand.CommandText);
            Console.WriteLine("Number of Rows Affected is: {0}",
               nonqueryCommand.ExecuteNonQuery());
         } 
         catch (SqlException ex) 
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
