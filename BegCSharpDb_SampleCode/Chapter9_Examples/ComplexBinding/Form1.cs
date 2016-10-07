using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace ComplexBinding
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.DataGrid dataGrid1;
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
         this.dataGrid1 = new System.Windows.Forms.DataGrid();
         ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGrid1
         // 
         this.dataGrid1.DataMember = "";
         this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
         this.dataGrid1.Location = new System.Drawing.Point(8, 8);
         this.dataGrid1.Name = "dataGrid1";
         this.dataGrid1.Size = new System.Drawing.Size(608, 256);
         this.dataGrid1.TabIndex = 0;
         this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate);
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(624, 272);
         this.Controls.Add(this.dataGrid1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
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

      private void dataGrid1_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
      {
         string connString = @"
          server = (local)\netsdk; 
          integrated security = sspi; 
          database = northwind
       ";

         string sql = @"
          select
             *
          from
             customers
       ";

         SqlConnection conn = new SqlConnection(connString);
         SqlDataAdapter da = new SqlDataAdapter(sql, conn);
         DataSet ds = new DataSet();
         da.Fill(ds, "customers");

         // Bind the data table to the data grid
         dataGrid1.SetDataBinding(ds, "customers");

      }

      private void Form1_Load(object sender, System.EventArgs e)
      {
         string connString = @"
          server = (local)\netsdk; 
          integrated security = sspi; 
          database = northwind
       ";

         string sql = @"
          select
             *
          from
             customers
       ";

         SqlConnection conn = new SqlConnection(connString);
         SqlDataAdapter da = new SqlDataAdapter(sql, conn);
         DataSet ds = new DataSet();
         da.Fill(ds, "customers");

         // Bind the data table to the data grid
         dataGrid1.SetDataBinding(ds, "customers");
      }
	}
}
