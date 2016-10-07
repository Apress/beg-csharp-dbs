using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SqlTool
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.RichTextBox rtfSql;
      private System.Windows.Forms.Splitter splitter1;
      private System.Windows.Forms.ListView listViewResult;
      private System.Windows.Forms.MainMenu mainMenu1;
      private System.Windows.Forms.MenuItem menuItem1;
      private System.Windows.Forms.MenuItem menuItemExecute;
      private System.Windows.Forms.MenuItem menuItemFormat;
      private System.Windows.Forms.MenuItem menuItem4;
      private System.Windows.Forms.MenuItem menuItemExit;
      private SqlConnection mConnection;
      private SqlCommand mCommand;
      private string[] mSqlKeyWords = new string[] {
                                                      "select", 
                                                      "from",
                                                      "where",
                                                      "in",
                                                      "between",
                                                      "is",
                                                      "null",
                                                      "not",
                                                      "order by",
                                                      "asc",
                                                      "desc",
                                                      "insert",
                                                      "into",
                                                      "values",
                                                      "update", 
                                                      "set",
                                                      "delete",
                                                      "truncate",
                                                      "table",
                                                      "join",
                                                      "on",
                                                      "create",
                                                      "drop"
                                                   };
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

         mConnection = new SqlConnection(@"
            data source=(local)\netsdk;
            database=northwind;
            integrated security=sspi
         ");

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
         this.rtfSql = new System.Windows.Forms.RichTextBox();
         this.splitter1 = new System.Windows.Forms.Splitter();
         this.listViewResult = new System.Windows.Forms.ListView();
         this.mainMenu1 = new System.Windows.Forms.MainMenu();
         this.menuItem1 = new System.Windows.Forms.MenuItem();
         this.menuItemExecute = new System.Windows.Forms.MenuItem();
         this.menuItemFormat = new System.Windows.Forms.MenuItem();
         this.menuItem4 = new System.Windows.Forms.MenuItem();
         this.menuItemExit = new System.Windows.Forms.MenuItem();
         this.SuspendLayout();
         // 
         // rtfSql
         // 
         this.rtfSql.Dock = System.Windows.Forms.DockStyle.Top;
         this.rtfSql.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.rtfSql.Location = new System.Drawing.Point(0, 0);
         this.rtfSql.Name = "rtfSql";
         this.rtfSql.Size = new System.Drawing.Size(292, 96);
         this.rtfSql.TabIndex = 0;
         this.rtfSql.Text = "";
         // 
         // splitter1
         // 
         this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
         this.splitter1.Location = new System.Drawing.Point(0, 96);
         this.splitter1.Name = "splitter1";
         this.splitter1.Size = new System.Drawing.Size(292, 3);
         this.splitter1.TabIndex = 1;
         this.splitter1.TabStop = false;
         // 
         // listViewResult
         // 
         this.listViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listViewResult.GridLines = true;
         this.listViewResult.Location = new System.Drawing.Point(0, 99);
         this.listViewResult.Name = "listViewResult";
         this.listViewResult.Size = new System.Drawing.Size(292, 173);
         this.listViewResult.TabIndex = 2;
         this.listViewResult.View = System.Windows.Forms.View.Details;
         // 
         // mainMenu1
         // 
         this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                  this.menuItem1});
         // 
         // menuItem1
         // 
         this.menuItem1.Index = 0;
         this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                  this.menuItemExecute,
                                                                                  this.menuItemFormat,
                                                                                  this.menuItem4,
                                                                                  this.menuItemExit});
         this.menuItem1.Text = "&Actions";
         // 
         // menuItemExecute
         // 
         this.menuItemExecute.Index = 0;
         this.menuItemExecute.Shortcut = System.Windows.Forms.Shortcut.F5;
         this.menuItemExecute.Text = "&Execute";
         this.menuItemExecute.Click += new System.EventHandler(this.menuItemExecute_Click);
         // 
         // menuItemFormat
         // 
         this.menuItemFormat.Index = 1;
         this.menuItemFormat.Shortcut = System.Windows.Forms.Shortcut.F12;
         this.menuItemFormat.Text = "&Format statements";
         this.menuItemFormat.Click += new System.EventHandler(this.menuItemFormat_Click);
         // 
         // menuItem4
         // 
         this.menuItem4.Index = 2;
         this.menuItem4.Text = "-";
         // 
         // menuItemExit
         // 
         this.menuItemExit.Index = 3;
         this.menuItemExit.Text = "E&xit";
         this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
         // 
         // frmSql
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(8, 15);
         this.ClientSize = new System.Drawing.Size(292, 272);
         this.Controls.Add(this.listViewResult);
         this.Controls.Add(this.splitter1);
         this.Controls.Add(this.rtfSql);
         this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.Menu = this.mainMenu1;
         this.Name = "frmSql";
         this.Text = "SQL Tool";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

      private void menuItemExecute_Click(object sender, System.EventArgs e)
      {
         string selectedText = rtfSql.SelectedText;

         // First get the text to use. If the user has selected part of the text, 
         // we use only the selection
         if (selectedText.Length == 0)
            selectedText = rtfSql.Text;

         // Check to see if the SELECT keyword exists in the text. If it does we 
         // treat the text as a query.
         if (selectedText.ToLower().IndexOf("select", 0) >= 0)
            ExecuteSelect(selectedText);
         else
            ExecuteNonQuery(selectedText);
    
      }
      private void ExecuteSelect(string pText)
      {
         try 
         {
            bool first = true;
            ListViewItem lvi = null;

            // create a command object. Pass to its constructor the
            // SQL (pText) and the connection (mConnection)
            mCommand = new SqlCommand(pText, mConnection);

            // Open the connection
            mConnection.Open();

            // Execute the query and get a SqlDataReader returned
            SqlDataReader dr = mCommand.ExecuteReader();

            // Check to see if the DataReader was returned
            if (dr == null) 
               return;

            // We've got a valid DataReader, use it
            while (dr.Read()) 
            {
               // If this is the first loop, create column headers 
               // in the list view.
               if (first) 
               {
                  listViewResult.Items.Clear();
                  listViewResult.Columns.Clear();
                  for (int i = 0; i < dr.FieldCount; i++)
                     listViewResult.Columns.Add(
                        dr.GetName(i).ToString(),
                        100, 
                        HorizontalAlignment.Left
                        );
                  first = false;
               }
               // Add the row to the list view
               for (int i = 0; i < dr.FieldCount; i++) 
               {
                  if (i == 0)
                     lvi = listViewResult.Items.Add(dr.GetValue(i).ToString());
                  else
                     lvi.SubItems.Add(dr.GetValue(i).ToString());
               }
            }
         }
         catch (System.Exception err) 
         {
            // If an error is caught, display it to the user
            MessageBox.Show(err.Message);
         }
         finally 
         {
            // Ensure that the connection is always closed when we 
            // leave this method.
            mConnection.Close();
         }
      }

      private void ExecuteNonQuery(string pText)
      {
         try 
         {
            int rowsAffected = 0;

            // Create the command. pText is the text to use and mConnection is the 
            // connection object.
            mCommand = new SqlCommand(pText, mConnection);

            // Open the connection
            mConnection.Open();

            // Execute the statement
            rowsAffected = mCommand.ExecuteNonQuery();

            // Clear the list view
            listViewResult.Columns.Clear();
            listViewResult.Items.Clear();

            // Display the number of rows affected.
            MessageBox.Show(rowsAffected + " row(s) affected");
         }
         catch (System.Exception err) 
         {
            // If an error is caught, display it to the user.
            MessageBox.Show(err.Message);
         }
         finally 
         {
            // Ensures the connection is closed when we leave this method
            mConnection.Close();
         }
      }

      private void menuItemFormat_Click(object sender, System.EventArgs e)
      {
         for (int i = 0; i < 23; i++) 
         {
            int index = 0;
            while (
               (index = rtfSql.Find(
               mSqlKeyWords[i],
               index,
               RichTextBoxFinds.WholeWord
               )
               ) >= 0
               ) 
            {
               index++;
               rtfSql.SelectionColor = Color.Blue;
               rtfSql.SelectedText = mSqlKeyWords[i].ToUpper();
            }
         }

      }

      private void menuItemExit_Click(object sender, System.EventArgs e)
      {
         Application.Exit(); 
      }

	}
}
