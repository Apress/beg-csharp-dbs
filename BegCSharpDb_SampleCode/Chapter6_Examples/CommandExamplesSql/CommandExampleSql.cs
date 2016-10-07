using System;
using System.Data;
using System.Data.SqlClient;

namespace CommandExampleSql
{
   class CommandExampleSql
   {
      static void Main() 
      {
         // create SqlConnection object
         SqlConnection thisConnection = new SqlConnection(
            @"Server=(local)\NetSDK;"   +
            "Integrated Security=SSPI;");

         // create SqlCommand
         SqlCommand thisCommand = new SqlCommand();
         Console.WriteLine("Command created.");

         try 
         {
            // open connection
            thisConnection.Open();

            // connect command to connection
            thisCommand.Connection = thisConnection;
            Console.WriteLine("Created Command on this connection.");
 
            // associate SQL with command
            thisCommand.CommandText = "SELECT COUNT(*) FROM Employees";
            Console.WriteLine("Ready to execute SQL command: {0}", 
               thisCommand.CommandText);
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
