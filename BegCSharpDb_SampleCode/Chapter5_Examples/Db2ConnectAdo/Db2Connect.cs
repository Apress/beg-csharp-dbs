using System;
using System.Data;
using IBM.Data.DB2;

namespace Db2Connect
{
   class Db2Connect
   {
      static void Main() 
      {
         // Connection string
         string connString = @"
            database = sample;
         ";

         // Create connection
         DB2Connection conn = new DB2Connection(connString);

         try 
         {
            // Open connection
            conn.Open();
            Console.WriteLine("Connection opened.");

            // Display connection properties
            Console.WriteLine("Connection Properties:");   
            Console.WriteLine(
               "\tConnection String: {0}", 
               conn.ConnectionString);    
            Console.WriteLine(
               "\tDatabase: {0}",
               conn.Database);   
            Console.WriteLine(
               "\tServerVersion: {0}",
               conn.ServerVersion);
            Console.WriteLine(
               "\tState: {0}",
               conn.State);
         } 
         catch (DB2Exception e) 
         {
            // Display error
            Console.WriteLine("Error: " + e);  
         }
         finally 
         {
            // Close connection
            conn.Close();
            Console.WriteLine("Connection closed.");
         }
      }
   }
}
