using System;
using System.Data;
using System.Data.OracleClient;

namespace OracleConnect
{
   class OracleConnect
   {
      static void Main() 
      {
         // Connection string
         string connString = @"
            server = o92;
            uid = scott;
            password = tiger;
         ";

         // Create connection
         OracleConnection conn = new OracleConnection(connString);

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
               "\tServerVersion: {0}",
               conn.ServerVersion);
            Console.WriteLine(
               "\tState: {0}",
               conn.State);
         } 
         catch (OracleException e) 
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
