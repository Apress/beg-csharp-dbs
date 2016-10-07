using System;
using System.Data; 
using System.Data.SqlClient;
using System.IO; 

namespace LoadImages 
{
   class LoadImages
   {
      string imageFileLocation =
         @"C:\Program Files\Microsoft Visual Studio .NET 2003\"
         + @"SDK\v1.1\QuickStart\aspplus\images\";

      string imageFilePrefix = "milk";
      int numberImageFiles = 8;
      string imageFileType = ".gif";
      int maxImageSize = 10000;
      SqlConnection conn = null;
      SqlCommand cmd = null;

      static void Main() 
      {
         LoadImages loader = new LoadImages();

         try 
         {
            // Open connection
            loader.OpenConnection();
            // Create command
            loader.CreateCommand();
            // Create table
            loader.CreateImageTable();
            // Prepare insert
            loader.PrepareInsertImages();
            // Insert images
            int i;
            for (i = 1; i <= loader.numberImageFiles; i++)   
            {
               loader.ExecuteInsertImages(i);
            }
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

      void OpenConnection() 
      {
         // Create connection
         conn = new SqlConnection(@"
            server = (local)\netsdk;
            integrated security = sspi; 
            database = tempdb
         ");
         // Open connection
         conn.Open();
      }

      void CloseConnection() 
      {
         // Close connection
         conn.Close();
         Console.WriteLine("Connection Successfully Closed!");
      }
      
      void CreateCommand()
      {
         cmd = new SqlCommand();
         cmd.Connection = conn;
      }
      
      void ExecuteCommand(string cmdText)
      {
         int cmdResult;
         cmd.CommandText = cmdText;
         Console.WriteLine("Executing command:");
         Console.WriteLine(cmd.CommandText);
         cmdResult = cmd.ExecuteNonQuery();
         Console.WriteLine("ExecuteNonQuery returns {0}.", cmdResult);
      }

      void CreateImageTable()
      {
         ExecuteCommand(@"
            create table imagetable
            (
               imagefile nvarchar(20),
               imagedata image
            )
         ");
      }

      void PrepareInsertImages()
      {
         cmd.CommandText = @"
            insert into imagetable
            values (@ImageFile, @ImageData)
         ";
         cmd.Parameters.Add("@ImageFile", SqlDbType.NVarChar);
         cmd.Parameters.Add("@ImageData", SqlDbType.Image);
      }

      void ExecuteInsertImages(int imageFileNumber)
      {
         string imageFileName = null;
         byte[] imageImageData = null;

         imageFileName = 
            imageFilePrefix + imageFileNumber.ToString() + imageFileType;
         imageImageData = 
            LoadImageFile(imageFileName, imageFileLocation, maxImageSize);

         cmd.Parameters["@ImageFile"].Value = imageFileName;
         cmd.Parameters["@ImageData"].Value = imageImageData;

         ExecuteCommand(cmd.CommandText);
      }

      byte[] LoadImageFile(
         string fileName,
         string fileLocation,
         int maxImageSize
         ) 
      {
         byte[] imagebytes = null;
         string fullpath = fileLocation + fileName;
         Console.WriteLine("Loading File:");
         Console.WriteLine(fullpath);
         FileStream fs = new FileStream(fullpath, FileMode.Open);
         BinaryReader br = new BinaryReader(fs);
         imagebytes = br.ReadBytes(maxImageSize);

         Console.WriteLine(
            "Imagebytes has length {0} bytes.", 
            imagebytes.GetLength(0)
            );

         return imagebytes;
      }
   }
}
