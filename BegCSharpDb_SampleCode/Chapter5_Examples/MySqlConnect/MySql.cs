using System;
using System.Data;
using ByteFX.Data.MySqlClient;

namespace MySqlConnect
{
   class MySqlConnect
   {
      static void Main() 
      {
         // Connection string
         string connString = @"
            user id = jim;
         ";
         // Create connection
         MySqlConnection conn = new MySqlConnection(connString);

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
         catch (MySqlException e) 
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
