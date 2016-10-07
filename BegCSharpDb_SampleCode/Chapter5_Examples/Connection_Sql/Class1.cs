using System;
using System.Data;
using System.Data.SqlClient;

namespace Connection_Sql
{
   class Connection_Sql
   {
      static void Main() 
      {
         // Connection string
         string connString = @"
            server = (local)\netsdk;     
            integrated security = sspi;
         ";

         // Create connection
         SqlConnection conn = new SqlConnection(connString);

         try 
         {
            // Open connection
            conn.Open();
            Console.WriteLine("Connection opened.");
         } 
         catch (SqlException e) 
         {
            // Display error
            Console.WriteLine("Error: " + e);  
         }
         finally 
         {
            // close connection
            conn.Close();
            Console.WriteLine("Connection closed.");
         }
      }
   }
}
