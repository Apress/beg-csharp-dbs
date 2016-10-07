using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO; 
 
namespace LoadText
{
   class LoadText
   {
      static string fileName =
         @"c:\begcsharpdb\chapter21_examples\loadimages\loadimages.cs";

      SqlConnection conn = null;
      SqlCommand cmd = null;

      static void Main() 
      {
         LoadText loader = new LoadText();
         try 
         {
            // Get text file
            loader.GetTextFile(fileName);
            // Open connection
            loader.OpenConnection();
            // Create command
            loader.CreateCommand();
            // Create table
            loader.CreateTextTable();
            // Prepare insert command
            loader.PrepareInsertTextFile();
            // Load text file
            loader.ExecuteInsertTextFile(fileName);
            Console.WriteLine(
               "Loaded {0} into texttable.", fileName
               );
         } 
         catch (SqlException ex)
         {
            Console.WriteLine(ex.ToString());
         }
         finally 
         {
            loader.CloseConnection();
         }
      }

      void CreateTextTable()
      {
         ExecuteCommand(@" 
            if exists
              (
                 select
                    table_name
                 from
                    information_schema.tables
                 where
                    table_name = 'texttable'
              )
              drop table texttable 
         ");

         ExecuteCommand(@"  
            create table texttable
            (
               textfile varchar(255),
               textdata text         
            )
         ");
      }

      void OpenConnection() 
      {
         // Create connection
         conn = new SqlConnection(@"
            data source = (local)\netsdk;
            integrated security = sspi; 
            initial catalog = tempdb;
         ");

         // Open connection
         conn.Open();
      }

      void CloseConnection() 
      {
         // Close connection
         conn.Close();
      }

      void CreateCommand()
      {
         cmd = new SqlCommand();
         cmd.Connection = conn;
      }

      void ExecuteCommand(string commandText)
      {
         int commandResult;
         cmd.CommandText = commandText;
         Console.WriteLine("Executing command:");
         Console.WriteLine(cmd.CommandText);
         commandResult = cmd.ExecuteNonQuery();
         Console.WriteLine("ExecuteNonQuery returns {0}.", commandResult);
      }
      void PrepareInsertTextFile()
      {
         cmd.CommandText = @"
            insert into texttable
            values (@TextFile, @TextData)
         ";
         cmd.Parameters.Add("@TextFile", SqlDbType.NVarChar);
         cmd.Parameters.Add("@TextData", SqlDbType.Text);
      }

      void ExecuteInsertTextFile(string textFile)
      {
         string textData = GetTextFile(textFile);
         cmd.Parameters["@TextFile"].Value = textFile;
         cmd.Parameters["@TextData"].Value = textData;
         ExecuteCommand(cmd.CommandText);
      }

      string GetTextFile(string textFile) 
      {
         string textBytes = null;
         Console.WriteLine("Loading File: " + textFile);

         FileStream fs = new FileStream(textFile, FileMode.Open);
         StreamReader sr = new StreamReader(fs);
         textBytes = sr.ReadToEnd();   

         Console.WriteLine("TextBytes has length {0} bytes.", 
            textBytes.Length);

         return textBytes;
      }
   }
}
