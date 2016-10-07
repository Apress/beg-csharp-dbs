using System;
using System.Data;
using System.Data.SqlClient;

namespace WriteXML
{
   class WriteXML
   {
      static void Main()
      {
         // Connection string
         string connString = @"
            server = (local)\netsdk; 
            integrated security = sspi; 
            database = northwind
         ";

         // Query 
         string qry = @"
            select
               productname,
               unitprice
            from
               products
         ";
 
         // Create connection
         SqlConnection conn = new SqlConnection(connString);

         try
         {
            //Create data adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(qry, conn);

            //Open connection
            conn.Open();

            // Create and fill dataset
            DataSet ds = new DataSet();   
            da.Fill(ds, "products");

            // Extract dataset to XML file
            ds.WriteXml(
               @"c:\begcsharpdb\chapter8_examples\productstable.xml");
         }
         catch(Exception e)
         {
            Console.WriteLine("Error: " + e);
         }
         finally
         {
            // Close connection
            conn.Close();
         }
      }
   }
}
