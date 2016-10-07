using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QueryProcessor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button cmdExecute;
      private System.Windows.Forms.TextBox txtSql;
      private System.Windows.Forms.ListView lvwResult;
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
         this.label1 = new System.Windows.Forms.Label();
         this.cmdExecute = new System.Windows.Forms.Button();
         this.txtSql = new System.Windows.Forms.TextBox();
         this.lvwResult = new System.Windows.Forms.ListView();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(0, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(296, 16);
         this.label1.TabIndex = 0;
         this.label1.Text = "Enter a SQL query or statement and click Execute.";
         // 
         // cmdExecute
         // 
         this.cmdExecute.Location = new System.Drawing.Point(227, 224);
         this.cmdExecute.Name = "cmdExecute";
         this.cmdExecute.TabIndex = 1;
         this.cmdExecute.Text = "Execute";
         this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
         // 
         // txtSql
         // 
         this.txtSql.Location = new System.Drawing.Point(0, 16);
         this.txtSql.Multiline = true;
         this.txtSql.Name = "txtSql";
         this.txtSql.Size = new System.Drawing.Size(528, 200);
         this.txtSql.TabIndex = 2;
         this.txtSql.Text = "";
         // 
         // lvwResult
         // 
         this.lvwResult.GridLines = true;
         this.lvwResult.Location = new System.Drawing.Point(0, 256);
         this.lvwResult.Name = "lvwResult";
         this.lvwResult.Size = new System.Drawing.Size(528, 200);
         this.lvwResult.TabIndex = 3;
         this.lvwResult.View = System.Windows.Forms.View.Details;
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(528, 452);
         this.Controls.Add(this.lvwResult);
         this.Controls.Add(this.txtSql);
         this.Controls.Add(this.cmdExecute);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Query Processor";
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

      private void cmdExecute_Click(object sender, System.EventArgs e)
      {
         //Create connection
         SqlConnection conn = new SqlConnection(@"
     data source = (local)\netsdk; 
     integrated security = sspi;
     database = northwind
  ");

         try 
         {
            //Clear list view column header and items 
            lvwResult.Columns.Clear() ;
            lvwResult.Items.Clear();

            //Open connection
            conn.Open();

            //Create command with SQL entered by user
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = txtSql.Text;

            //Create data reader
            SqlDataReader dr = cmd.ExecuteReader();

            //Get colummn names from the data reader and show in the list view
            for (int i = 0; i< dr.FieldCount; i++)
            {
               ColumnHeader ch = new ColumnHeader();
               ch.Text=dr.GetName(i);
               lvwResult.Columns.Add(ch);
            }

            //Get values of each row in data reader and show in list view
            ListViewItem itmX; 
            while (dr.Read())
            {
               //create list view item
               itmX=new ListViewItem(); 

               //Specify text and subitems of list view
               itmX.Text= dr.GetValue(0).ToString();
               for (int i=1 ; i< dr.FieldCount; i++)
               {
                  itmX.SubItems.Add(dr.GetValue(i).ToString());
               }

               //Add item to list view Items collection
               lvwResult.Items.Add(itmX);
            }

            //close reader
            dr.Close();
         }
         catch ( System.Data.SqlClient.SqlException  ex)
         {
            // Display error Message.
            MessageBox.Show ("There was an error in executing the SQL." +
               "\nError Message:" + ex.Message, "SQL");
         }
         finally
         {
            // Close connection
            conn.Close();
         }

      }
	}
}
