using System;
using System.Data;
using System.Data.SqlClient;
namespace CommandExampleCreate
{
   class CommandExampleCreate
   {
      static void Main() 
      {
         // create SqlConnection object
         SqlConnection thisConnection = new SqlConnection(
            @"Server=(local)\NetSDK;"     +
            "Integrated Security=SSPI;"   +
            "Database=tempdb;");

         // create SqlCommand object 
         SqlCommand nonqueryCommand = thisConnection.CreateCommand();

         try 
         {
            // open connection
            thisConnection.Open();

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
