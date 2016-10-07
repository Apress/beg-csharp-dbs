using System;
using System.Data;
using System.Data.OleDb;
namespace CommandOleDbQuery
{
   class CommandOleDbQuery
   {
      static void Main() 
      {
         OleDbConnection thisConnection = new OleDbConnection(
            @"Provider=Microsoft.Jet.OLEDB.4.0;" +   
            @"Data Source=" +
            @"C:\Program Files\Microsoft Office\Office10\Samples\" +
            @"northwind.mdb");
      
         OleDbCommand thisCommand = 
            new OleDbCommand("SELECT ProductID, ProductName FROM Products",
            thisConnection);

         try 
         {
            // open connection
            thisConnection.Open();
            OleDbDataReader thisReader = thisCommand.ExecuteReader();

            while (thisReader.Read()) 
            {
               Console.WriteLine("Product ID and Name: {0} {1}",
                  thisReader.GetValue(0),
                  thisReader.GetValue(1));
            }
         } 
         catch (OleDbException ex) 
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
