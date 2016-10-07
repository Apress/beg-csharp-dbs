using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetExceptions
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Button button5;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.button2 = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.button5 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Location = new System.Drawing.Point(0, 0);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(344, 232);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.label2);
         this.tabPage1.Controls.Add(this.label1);
         this.tabPage1.Controls.Add(this.button2);
         this.tabPage1.Controls.Add(this.button1);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Size = new System.Drawing.Size(336, 206);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "ADO.NET";
         this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(160, 64);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(168, 32);
         this.label2.TabIndex = 3;
         this.label2.Text = "Accessing a nonexistent column will cause an exception.";
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(160, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(168, 40);
         this.label1.TabIndex = 2;
         this.label1.Text = "Incorrect ADO.NET code will cause an exception.";
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(16, 64);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(128, 23);
         this.button2.TabIndex = 1;
         this.button2.Text = "ADO.NET Exception-2";
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(16, 8);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(128, 23);
         this.button1.TabIndex = 0;
         this.button1.Text = "ADO.NET Exception-1";
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.label5);
         this.tabPage2.Controls.Add(this.label4);
         this.tabPage2.Controls.Add(this.label3);
         this.tabPage2.Controls.Add(this.button5);
         this.tabPage2.Controls.Add(this.button4);
         this.tabPage2.Controls.Add(this.button3);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Size = new System.Drawing.Size(336, 206);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Database";
         // 
         // label5
         // 
         this.label5.Location = new System.Drawing.Point(240, 152);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(88, 40);
         this.label5.TabIndex = 5;
         this.label5.Text = "Multiple SqlError objects created.";
         // 
         // label4
         // 
         this.label4.Location = new System.Drawing.Point(240, 80);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(88, 56);
         this.label4.TabIndex = 4;
         this.label4.Text = "Calls a stored procedure that encounters an error.";
         // 
         // label3
         // 
         this.label3.Location = new System.Drawing.Point(240, 8);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(88, 56);
         this.label3.TabIndex = 3;
         this.label3.Text = "Calls a stored procedure that uses RAISERROR.";
         // 
         // button5
         // 
         this.button5.Location = new System.Drawing.Point(16, 152);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(216, 23);
         this.button5.TabIndex = 2;
         this.button5.Text = "Database Exception-3 (Errors collection)";
         this.button5.Click += new System.EventHandler(this.button5_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(16, 80);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(216, 23);
         this.button4.TabIndex = 1;
         this.button4.Text = "Database Exception-2 (SP Error)";
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(16, 8);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(216, 23);
         this.button3.TabIndex = 0;
         this.button3.Text = "Database Exception-1 (RAISERROR)";
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(352, 272);
         this.Controls.Add(this.tabControl1);
         this.Name = "Form1";
         this.Text = "ADO.NET Exceptions";
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage2.ResumeLayout(false);
         this.ResumeLayout(false);

      }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

      private void tabPage1_Click(object sender, System.EventArgs e)
      {
      
      }

      private void button1_Click(object sender, System.EventArgs e)
      {
         // Create connection
         SqlConnection conn = new SqlConnection(@"
     data source = (local)\netsdk; 
     integrated security = sspi;
     database = northwind
  ");
  
         // Create command
         SqlCommand cmd = conn.CreateCommand(); 
  
         // Specify that a stored procedure is to be executed
         cmd.CommandType = CommandType.StoredProcedure;
  
         // Deliberately fail to specify the procedure
         // cmd.CommandText = "sp_Select_AllEmployees";

         try
         {  
            // Open connection
            conn.Open();
            // Create data reader
            SqlDataReader dr = cmd.ExecuteReader();    
            // Close reader
            dr.Close();      
         }
         catch (System.Data.SqlClient.SqlException ex)
         {
            string str;
            str = "Source:" + ex.Source;
            str += "\n" + "Exception Message:" + ex.Message;
            MessageBox.Show (str, "Database Exception");
         }
         catch (System.Exception ex) 
         {
            string str;
            str = "Source:" + ex.Source;
            str += "\n" + "Exception Message:" + ex.Message;
            MessageBox.Show (str, "Non-Database Exception");
         }
         finally
         {
            if (conn.State == ConnectionState.Open)
            {
               MessageBox.Show ("Finally block closing the connection", "Finally");
               conn.Close();
            }   
         } 
      }

      private void button2_Click(object sender, System.EventArgs e)
      {
         // Create connection
         SqlConnection conn = new SqlConnection(@"
      data source = (local)\netsdk; 
      integrated security = sspi;
      database = northwind
   ");
        
         // Create command
         SqlCommand cmd = conn.CreateCommand();
      
         // Specify stored procedure to be executed
         cmd.CommandType = CommandType.StoredProcedure; 
         cmd.CommandText = "sp_Select_AllEmployees";

         try
         {
            // Open connection
            conn.Open();
 
            // Create data reader
            SqlDataReader dr = cmd.ExecuteReader();

            // Access nonexistent column
            string str = dr.GetValue(20).ToString();

            // Close data reader
            dr.Close();
         }
         catch (System.InvalidOperationException ex)
         {
            string str;
            str = "Source:" + ex.Source;
            str += "\n" + "Message:"+ ex.Message;
            str += "\n" + "\n";
            str += "\n" + "Stack Trace :" + ex.StackTrace;
            MessageBox.Show (str, "Specific Exception");
         }
         catch (System.Data.SqlClient.SqlException ex)
         {
            string str;
            str = "Source:" + ex.Source;
            str += "\n" + "Message:" + ex.Message;
            MessageBox.Show (str, "Database Exception");
         }
         catch (System.Exception ex)
         {
            string str;
            str = "Source:" + ex.Source;
            str += "\n"+ "Message:" + ex.Message;
            MessageBox.Show (str, "Generic Exception");
         }
         finally
         {
            if ( conn.State == ConnectionState.Open)
            {
               MessageBox.Show ("Finally block closing the connection", "Finally");
               conn.Close();
            }
         }

      }

      private void button3_Click(object sender, System.EventArgs e)
      {
         // Create connection
         SqlConnection conn = new SqlConnection(@"
      data source = (local)\netsdk; 
      integrated security = sspi;
      database = northwind"
            );
  
         // Create command
         SqlCommand cmd = conn.CreateCommand();

         // Specify stored procedure to be executed
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.CommandText = "sp_DBException_1";

         try
         {
            // Open onnection
            conn.Open();
 
            // Execute stored procedure
            cmd.ExecuteNonQuery();
         }  
         catch (System.Data.SqlClient.SqlException ex)
         {
            string str;
            str = "Source:"+ ex.Source;        
            str += "\n"+ "Number:"+ ex.Number.ToString();
            str += "\n"+ "Message:"+ ex.Message;
            str += "\n"+ "Class:"+ ex.Class.ToString ();
            str += "\n"+ "Procedure:"+ ex.Procedure.ToString();
            str += "\n"+ "Line Number:"+ex.LineNumber.ToString();
            str += "\n"+ "Server:"+ ex.Server.ToString();
        
            MessageBox.Show (str, "Database Exception");
         }
         catch (System.Exception ex)
         {
            string str;
            str = "Source:"+ ex.Source;
            str += "\n"+ "Error Message:"+ ex.Message;
            MessageBox.Show (str, "General Exception");
         }
         finally
         {
            if (conn.State == ConnectionState.Open)
            {
               MessageBox.Show ("Finally block closing the connection", "Finally");
               conn.Close();
            }        
         } 

      }

      private void button4_Click(object sender, System.EventArgs e)
      {
         // Create connection
         SqlConnection conn = new SqlConnection(@"
      data source = (local)\netsdk; 
      integrated security = sspi;
      database = northwind"
            );
  
         // Create command
         SqlCommand cmd = conn.CreateCommand();

         // Specify stored procedure to be executed
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.CommandText = "sp_DBException_2";

         try
         {
            // Open onnection
            conn.Open();
 
            // Execute stored procedure
            cmd.ExecuteNonQuery();
         }  
         catch (System.Data.SqlClient.SqlException ex)
         {
            string str;
            str = "Source:"+ ex.Source;        
            str += "\n"+ "Number:"+ ex.Number.ToString();
            str += "\n"+ "Message:"+ ex.Message;
            str += "\n"+ "Class:"+ ex.Class.ToString ();
            str += "\n"+ "Procedure:"+ ex.Procedure.ToString();
            str += "\n"+ "Line Number:"+ex.LineNumber.ToString();
            str += "\n"+ "Server:"+ ex.Server.ToString();
        
            MessageBox.Show (str, "Database Exception");
         }
         catch (System.Exception ex)
         {
            string str;
            str = "Source:"+ ex.Source;
            str += "\n"+ "Error Message:"+ ex.Message;
            MessageBox.Show (str, "ADO.NET Exception");
         }
         finally
         {
            if (conn.State == ConnectionState.Open)
            {
               MessageBox.Show ("Finally block closing the connection", "Finally");
               conn.Close();
            }
         }  

      }

      private void button5_Click(object sender, System.EventArgs e)
      {
         // Create connection
         SqlConnection conn = new SqlConnection(@"
      data source = (local)\netsdk; 
      integrated security = sspi;
      database = northwnd"
            );
  
         // Create command
         SqlCommand cmd = conn.CreateCommand();

         // Specify stored procedure to be executed
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.CommandText = "sp_DBException_2";

         try
         {
            // Open onnection
            conn.Open();
 
            // Execute stored procedure
            cmd.ExecuteNonQuery();
         }  
         catch (System.Data.SqlClient.SqlException ex)
         {
            string str ="";
            for (int i = 0; i < ex.Errors.Count; i++)
            {
               str += "\n" + "Index #" + i + "\n" +
                  "Exception : " + ex.Errors[i].ToString() + "\n" +
                  "Number:" + ex.Errors[i].Number.ToString() + "\n"
                  ;
            }
        
            MessageBox.Show (str, "Database Exception");
         }
         catch (System.Exception ex)
         {
            string str;
            str = "Source:"+ ex.Source;
            str += "\n"+ "Error Message:"+ ex.Message;
            MessageBox.Show (str, "ADO.NET Exception");
         }
         finally
         {
            if (conn.State == ConnectionState.Open)
            {
               MessageBox.Show ("Finally block closing the connection", "Finally");
               conn.Close();
            }
         }  

      }
	}
}
