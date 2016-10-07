using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataGridUpdate
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.DataGrid dataGrid1;
      private System.Windows.Forms.Button buttonUpdate;
      private System.Data.DataSet dataSet1;
      private System.Data.SqlClient.SqlCommand sqlCommand1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

      private SqlCommandBuilder cb;
      private SqlDataAdapter da;

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
         this.buttonUpdate = new System.Windows.Forms.Button();
         this.dataSet1 = new System.Data.DataSet();
         this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
         ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGrid1
         // 
         this.dataGrid1.DataMember = "";
         this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
         this.dataGrid1.Location = new System.Drawing.Point(8, 8);
         this.dataGrid1.Name = "dataGrid1";
         this.dataGrid1.Size = new System.Drawing.Size(440, 208);
         this.dataGrid1.TabIndex = 0;
         // 
         // buttonUpdate
         // 
         this.buttonUpdate.Location = new System.Drawing.Point(191, 232);
         this.buttonUpdate.Name = "buttonUpdate";
         this.buttonUpdate.TabIndex = 1;
         this.buttonUpdate.Text = "Update";
         this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
         // 
         // dataSet1
         // 
         this.dataSet1.DataSetName = "NewDataSet";
         this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(456, 272);
         this.Controls.Add(this.buttonUpdate);
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
  
         string sql = @"
          select
             *
          from
             employees
       ";

         SqlConnection conn = new SqlConnection(connString);

         // Create a command 
         sqlCommand1 = new SqlCommand(sql, conn);

         // Create a data adapter 
         da = new SqlDataAdapter();
         da.SelectCommand = sqlCommand1;

         // Create a SqlCommandBuilder object 
         cb = new SqlCommandBuilder(da);

         // Fill dataset 
         da.Fill(dataSet1, "employees");

         // Bind the data grid at run time
         dataGrid1.SetDataBinding(dataSet1, "employees");

      }

      private void buttonUpdate_Click(object sender, System.EventArgs e)
      {
         da.Update(dataSet1, "employees"); 
      }
	}
}
