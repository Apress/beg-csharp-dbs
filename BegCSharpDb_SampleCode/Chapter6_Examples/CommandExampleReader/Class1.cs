using System;
using System.Data;
using System.Data.SqlClient;
namespace CommandExampleReader
{
   class CommandExampleReader
   {
      static void Main() 
      {
         // create SqlConnection object
         SqlConnection thisConnection = 
            new SqlConnection(
            @"Server=(local)\NetSDK;"   +
            "Integrated Security=SSPI;" +
            "Database=Northwind;" );

         SqlCommand thisCommand = 
            new SqlCommand("SELECT FirstName, LastName FROM Employees",
            thisConnection);

         try 
         {
            // open connection
            thisConnection.Open();
        
            SqlDataReader thisReader = thisCommand.ExecuteReader();

            while (thisReader.Read()) 
            {
               Console.WriteLine("Employee name: {0} {1}",
                  thisReader.GetValue(0),
                  thisReader.GetValue(1));
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
