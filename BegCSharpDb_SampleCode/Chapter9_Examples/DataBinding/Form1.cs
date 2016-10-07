using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataBinding
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
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
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(8, 8);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(192, 20);
         this.textBox1.TabIndex = 0;
         this.textBox1.Text = "textBox1";
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(8, 40);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(184, 20);
         this.textBox2.TabIndex = 1;
         this.textBox2.Text = "textBox2";
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(208, 76);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
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
         SqlDataAdapter da = new SqlDataAdapter(sql, conn);
         DataSet ds = new DataSet();
         da.Fill(ds, "employees");

         // Bind to FirstName column of the Employees table 
         textBox1.DataBindings.Add("text", ds, "employees.firstname");
         // Bind to LastName column of the Employees table
         textBox2.DataBindings.Add("text", ds, "employees.lastname");
      }
	}
}
