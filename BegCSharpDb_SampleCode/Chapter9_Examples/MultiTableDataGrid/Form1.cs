using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MultiTableDataGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.DataGrid dataGrid1;
      private System.Data.DataSet dataSet1;
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
         this.dataSet1 = new System.Data.DataSet();
         ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGrid1
         // 
         this.dataGrid1.DataMember = "";
         this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
         this.dataGrid1.Location = new System.Drawing.Point(0, 0);
         this.dataGrid1.Name = "dataGrid1";
         this.dataGrid1.Size = new System.Drawing.Size(400, 200);
         this.dataGrid1.TabIndex = 0;
         // 
         // dataSet1
         // 
         this.dataSet1.DataSetName = "NewDataSet";
         this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(400, 196);
         this.Controls.Add(this.dataGrid1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
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

      private void Form1_Load(object sender, System.EventArgs e)
      {
         string connString = @"
          server = (local)\netsdk; 
          integrated security = sspi; 
          database = northwind
       ";
  
         string qry1 = @"
          select
             *
          from
             employees
       ";
  
         string qry2 = @"
          select
             *
          from
             orders
       ";

         string sql = qry1 + qry2;

         SqlConnection conn = new SqlConnection(connString);
         SqlDataAdapter da = new SqlDataAdapter(sql, conn);
    
         // Map default table names to employees and orders 
         da.TableMappings.Add("Table", "employees");
         da.TableMappings.Add("Table1", "orders");
         da.Fill(dataSet1);

         // Create a relation between the two tables
         DataRelation dr = new DataRelation(
            "employeeorders",
            dataSet1.Tables[0].Columns["employeeid"], 
            dataSet1.Tables[1].Columns["employeeid"]
            );
         dataSet1.Relations.Add(dr);

         // Bind the data grid at run time
         dataGrid1.SetDataBinding(dataSet1, "employees");

      }
	}
}
