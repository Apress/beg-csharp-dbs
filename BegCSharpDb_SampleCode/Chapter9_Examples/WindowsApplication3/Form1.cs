using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsApplication3
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.ListBox listBox1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
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
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.dataSet1 = new System.Data.DataSet();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
         this.SuspendLayout();
         // 
         // listBox1
         // 
         this.listBox1.Location = new System.Drawing.Point(8, 8);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(232, 95);
         this.listBox1.TabIndex = 0;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(8, 120);
         this.textBox1.Name = "textBox1";
         this.textBox1.TabIndex = 1;
         this.textBox1.Text = "textBox1";
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(8, 152);
         this.textBox2.Name = "textBox2";
         this.textBox2.TabIndex = 2;
         this.textBox2.Text = "textBox2";
         // 
         // dataSet1
         // 
         this.dataSet1.DataSetName = "NewDataSet";
         this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(256, 188);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.listBox1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
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
             firstname,
             lastname
          from
             employees
       ";

         SqlConnection conn = new SqlConnection(connString);
         SqlDataAdapter da = new SqlDataAdapter(sql, conn);
         da.Fill(dataSet1, "employees");
         DataTable dt = dataSet1.Tables["employees"];

         // Complex-bind a ListBox control at design time to
         // display values from the firstname data column
         listBox1.DataSource = dt;
         listBox1.DisplayMember = "firstname";
         // Bind the Text property to the firstname data column
         textBox1.DataBindings.Add("text", dt, "firstname");
         // Bind the Text property to the firstname data column
         textBox2.DataBindings.Add("text", dt, "lastname");

      }
	}
}
