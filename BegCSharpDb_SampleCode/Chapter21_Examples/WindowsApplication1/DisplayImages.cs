using System;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.IO;

namespace DisplayImages
{
   public class DisplayImages
   {
      string imageFilename = null;
      byte[] imageBytes = null;

      SqlConnection imageConnection = null;
      SqlCommand imageCommand = null;
      SqlDataReader imageReader = null;

      // Constructor
      public DisplayImages()
      {
         imageConnection = new SqlConnection(@"
            data source = (local)\netsdk;
            integrated security = sspi; 
            initial catalog = tempdb;
         ");

         imageCommand = new SqlCommand(@"
            select
               imagefile,
               imagedata
            from
               imagetable
         ", imageConnection);

         // Open connection and create data reader
         imageConnection.Open();
         imageReader = imageCommand.ExecuteReader();
      }

      public Bitmap getImage()
      {
         MemoryStream ms = new MemoryStream(imageBytes);
         Bitmap bmap = new Bitmap(ms);

         return bmap;
      }

      public string GetFilename()
      {
         return imageFilename;
      }

      public bool GetRow()
      {
         if (imageReader.Read())
         {
            imageFilename = (string) imageReader.GetValue(0);
            imageBytes = (byte[]) imageReader.GetValue(1);

            return true;
         }
         else 
         {
            return false;
         }
      }

      public void EndImages() 
      {
         // Close the reader and the connection.
         imageReader.Close();
         imageConnection.Close();
      }
   }
}
