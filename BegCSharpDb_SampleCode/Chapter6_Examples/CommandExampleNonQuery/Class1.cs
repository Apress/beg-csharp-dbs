using System;
using System.Data;
using System.Data.SqlClient;

namespace CommandExampleNonQuery
{
   class CommandExampleNonQuery
   {
      static void Main() 
      {
         // create SqlConnection object
         SqlConnection thisConnection = new SqlConnection(
            @"Server=(local)\NetSDK;"   +
            "Integrated Security=SSPI;" +
            "Database=Northwind;");

         // create SqlCommands 
         SqlCommand selectCommand = 
            new SqlCommand("SELECT COUNT(*) FROM Employees", thisConnection);
         SqlCommand nonqueryCommand = thisConnection.CreateCommand();

         try 
         {
            // open connection
            thisConnection.Open();

            // execute query to return number of employees
            Console.WriteLine("Before INSERT: Number of Employees is: {0}",
               selectCommand.ExecuteScalar());
            nonqueryCommand.CommandText = 
               "INSERT INTO Employees (Firstname, Lastname) " +
               "VALUES ('Zachariah', 'Zinn')";
            Console.WriteLine(nonqueryCommand.CommandText);
            Console.WriteLine("Number of Rows Affected is: {0}",
               nonqueryCommand.ExecuteNonQuery());
            Console.WriteLine("After INSERT: Number of Employees is: {0}",
               selectCommand.ExecuteScalar());
            nonqueryCommand.CommandText = 
               "DELETE FROM Employees WHERE Firstname='Zachariah'" +
               "AND Lastname='Zinn'";
            Console.WriteLine(nonqueryCommand.CommandText);
            Console.WriteLine("Number of Rows Affected is: {0}",
               nonqueryCommand.ExecuteNonQuery());
            Console.WriteLine("After DELETE: Number of Employees is: {0}",
               selectCommand.ExecuteScalar());
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
