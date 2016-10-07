using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Events
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.ListBox listBox1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Label label1;
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
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // listBox1
         // 
         this.listBox1.Location = new System.Drawing.Point(160, 24);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(280, 238);
         this.listBox1.TabIndex = 0;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(8, 24);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(128, 32);
         this.button1.TabIndex = 1;
         this.button1.Text = "Connection StateChange Event";
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(8, 72);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(128, 32);
         this.button2.TabIndex = 2;
         this.button2.Text = "Connection InfoMessage Event";
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(8, 120);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(128, 32);
         this.button3.TabIndex = 3;
         this.button3.Text = "SqlDataAdapter Row Updating Event";
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(8, 168);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(128, 32);
         this.button4.TabIndex = 4;
         this.button4.Text = "Multiple Handlers";
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(160, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(100, 16);
         this.label1.TabIndex = 5;
         this.label1.Text = "Event Log";
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(448, 272);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.listBox1);
         this.Name = "Form1";
         this.Text = "ADO.NET Events";
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

      private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
      {
      
      }

      private void button1_Click(object sender, System.EventArgs e)
      {
         // Create connection
         SqlConnection cn = new SqlConnection(@"Data Source=(local)\NETSDK;" + 
            "Integrated Security=SSPI;database=Northwind");

         // Create command
         SqlCommand cmd = new SqlCommand();
         cmd.CommandText = "SELECT TOP 1 CustomerId, CompanyName FROM Customers";
         cmd.Connection = cn;

         // Delegate the StateChange event to the CnStateChange function
         cn.StateChange += new StateChangeEventHandler(CnStateChange);

         try
         {
            listBox1.Items.Clear();

            //Open connection
            cn.Open();

            // Create data reader
            SqlDataReader dr = cmd.ExecuteReader();

            // Display the rows in list box
            while(dr.Read())
            {
               listBox1.Items.Add(dr.GetString(0) + "-" + dr.GetString(1));
            }
         }
         catch(SqlException e1)
         {
            MessageBox.Show (e1.Message);
         }
         finally
         {
            //Close connection – CnStateChange event will be fired.
            cn.Close();
         }
      }
      private void CnStateChange(object sender, StateChangeEventArgs ev)
      {
         // Event handler for the StateChange Event
         listBox1.Items.Add("------------------------------");
         listBox1.Items.Add("Entering StateChange EventHandler");
         listBox1.Items.Add("Sender = "+ sender.ToString());
         listBox1.Items.Add("Original State = "+ ev.OriginalState.ToString());
         listBox1.Items.Add("Current State = "+ ev.CurrentState.ToString()); 
         listBox1.Items.Add("Exiting StateChange EventHandler");
         listBox1.Items.Add("------------------------------");
      }

      private void button2_Click(object sender, System.EventArgs e)
      {
         // Create connection
         SqlConnection cn = new SqlConnection(@"Data Source=(local)\NETSDK;" + 
            "Integrated Security=SSPI;database=Northwind");

         // Delegate the InfoMessage event to the CnInfoMessage method
         cn.InfoMessage += new SqlInfoMessageEventHandler(CnInfoMessage);

         // Delegate the StateChange event to the CnStateChange function
         cn.StateChange += new StateChangeEventHandler(CnStateChange); 

         // Create command
         SqlCommand cmd = new SqlCommand();
         cmd.CommandText = "SELECT TOP 2 CustomerId FROM Customers";
         cmd.Connection = cn;

         try
         {
            // Clear list box
            listBox1.Items.Clear();

            //Open connection
            cn.Open();

            // Create data reader
            SqlDataReader dr = cmd.ExecuteReader();      

            while(dr.Read())
            {
               listBox1.Items.Add(dr.GetString(0));    
            }

            dr.Close();

            // Execute a PRINT statement
            cmd.CommandText = "PRINT 'Get CustomerId for all customers'";
            cmd.ExecuteNonQuery();
         }
         catch(SqlException ex)
         {
            MessageBox.Show (ex.Message);
         }      
         finally
         {
            //Close connection 
            cn.Close();
         }      
      }
      private void CnInfoMessage(object sender, SqlInfoMessageEventArgs ev)
      {
         foreach (SqlError err in ev.Errors)
         {
            listBox1.Items.Add("------------------------------");
            listBox1.Items.Add("Entering InfoMessage Event Handler");
            listBox1.Items.Add("Source- " + err.Source);
            listBox1.Items.Add("State- " + err.State);
            listBox1.Items.Add("Number- " + err.Number);
            listBox1.Items.Add("Procedure- " + err.Procedure);
            listBox1.Items.Add("Server- " + err.Server);
            listBox1.Items.Add("Message- " + err.Message);
            listBox1.Items.Add("Exiting InfoMessage Event Handler");
            listBox1.Items.Add("------------------------------");
         }
      }

      private void button3_Click(object sender, System.EventArgs e)
      {
         // Clear list box
         listBox1.Items.Clear();

         // Create connection
         SqlConnection cn = new SqlConnection(@"Data Source=(local)\NETSDK;" + 
            "Integrated Security=SSPI;database=Northwind");

         try
         {
            //Open connection
            cn.Open();

            // Create data adapter
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customers", cn);
     
            // Build command
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            // Create and fill dataset (select only first row)
            DataSet ds = new DataSet();
            da.Fill(ds, 0, 1, "Customers");

            // Add handlers        
            da.RowUpdating += new SqlRowUpdatingEventHandler(OnRowUpdating);
            da.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

            // Modify dataSet
            DataTable dt = ds.Tables["Customers"];
            dt.Rows[0][1] = "The Volcano Corporation";

            // Update - this operation fires two events (RowUpdating/RowUpdated). 
            da.Update(ds, "Customers");

            // Remove handlers
            da.RowUpdating -= new SqlRowUpdatingEventHandler(OnRowUpdating);
            da.RowUpdated -= new SqlRowUpdatedEventHandler(OnRowUpdated);
 
         }
         catch (SqlException ex)
         {
            MessageBox.Show(ex.Message);
         }
         finally
         {
            //Close connection
            cn.Close();
         }
      }
      // Event Handler for RowUpdating event
      private void OnRowUpdating(object sender, SqlRowUpdatingEventArgs e) 
      {
         DisplayEventArgs(e);
      } 


      // Event Handler for RowUpdated event
      private void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e) 
      {
         DisplayEventArgs(e);
      }
      private void DisplayEventArgs(SqlRowUpdatingEventArgs args) 
      {
         listBox1.Items.Add("OnRowUpdating event");
         if (args.Status != UpdateStatus.Continue) 
            listBox1.Items.Add("RowStatus = " + args.Status.ToString());
      }

      private void button4_Click(object sender, System.EventArgs e)
      {
         // Create connection
         SqlConnection cn = new SqlConnection(@"Data Source=(local)\NETSDK;" + 
            "Integrated Security=SSPI;database=Northwind");

         // Delegate the StateChange event to two handlers
         cn.StateChange += new StateChangeEventHandler(CnStateChange);
         cn.StateChange += new StateChangeEventHandler(CnStateChange2);
      
         // Create command
         SqlCommand cmd = new SqlCommand();
         cmd.CommandText = "SELECT TOP 1 CustomerId, CompanyName FROM Customers";
         cmd.Connection = cn;

         try
         {
            listBox1.Items.Clear();
            // Open connection
            cn.Open();
            // Create data reader
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
               listBox1.Items.Add(dr.GetString(0) + "-" + dr.GetString(1));    
            }
         }
         catch(SqlException ex)
         {
            MessageBox.Show (ex.Message);
         }
         finally
         {
            //Close connection
            cn.Close();
         }   
      }

      private void DisplayEventArgs(SqlRowUpdatedEventArgs args) 
      {
         listBox1.Items.Add("OnRowUpdated event");
         listBox1.Items.Add("Records Affected = " + args.RecordsAffected);
      }
      private void CnStateChange2(object sender, StateChangeEventArgs ev)
      {
         // Second Event handler for the StateChange Event
         listBox1.Items.Add("------------------------------");
         listBox1.Items.Add("Entering Second Statechange EventHandler");
         listBox1.Items.Add("Sender = " + sender.ToString());  
         listBox1.Items.Add("Original State = " + ev.OriginalState.ToString());
         listBox1.Items.Add("Current State = " + ev.CurrentState.ToString());    
         listBox1.Items.Add("Exiting Second StateChange EventHandler");
         listBox1.Items.Add("------------------------------");
      }



	}
}
