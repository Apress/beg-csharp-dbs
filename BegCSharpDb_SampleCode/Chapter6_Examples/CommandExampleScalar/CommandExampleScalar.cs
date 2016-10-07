using System;
using System.Data;
using System.Data.SqlClient;

namespace CommandExampleScalar
{
   class CommandExampleScalar
   {
      static void Main() 
      {
         // create SqlConnection object
         SqlConnection thisConnection = new SqlConnection(
            @"Server=(local)\NetSDK;"   +
            "Integrated Security=true;" +
            "Database=Northwind;"); 

         // create SqlCommand
         SqlCommand thisCommand = 
            new SqlCommand("SELECT COUNT(*) FROM Employees", thisConnection);

         try 
         {
            // open connection
            thisConnection.Open();

            // execute query to return number of employees
            Console.WriteLine("Number of Employees is: {0}",
               thisCommand.ExecuteScalar());
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
