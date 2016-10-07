using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Button buttonBack;
      private System.Windows.Forms.Button buttonNext;
      private System.Data.DataSet dataSet1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
      // Declare a BindingManagerBase field 
      private BindingManagerBase bMgr;

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
         this.buttonBack = new System.Windows.Forms.Button();
         this.buttonNext = new System.Windows.Forms.Button();
         this.dataSet1 = new System.Data.DataSet();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(8, 8);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(160, 20);
         this.textBox1.TabIndex = 0;
         this.textBox1.Text = "textBox1";
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(8, 40);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(160, 20);
         this.textBox2.TabIndex = 1;
         this.textBox2.Text = "textBox2";
         // 
         // buttonBack
         // 
         this.buttonBack.Location = new System.Drawing.Point(24, 80);
         this.buttonBack.Name = "buttonBack";
         this.buttonBack.Size = new System.Drawing.Size(56, 23);
         this.buttonBack.TabIndex = 2;
         this.buttonBack.Text = "<< Back";
         this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
         // 
         // buttonNext
         // 
         this.buttonNext.Location = new System.Drawing.Point(96, 80);
         this.buttonNext.Name = "buttonNext";
         this.buttonNext.Size = new System.Drawing.Size(56, 23);
         this.buttonNext.TabIndex = 3;
         this.buttonNext.Text = "Next>>";
         this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
         // 
         // dataSet1
         // 
         this.dataSet1.DataSetName = "NewDataSet";
         this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(176, 108);
         this.Controls.Add(this.buttonNext);
         this.Controls.Add(this.buttonBack);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
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
             *
          from
             employees
       ";

         SqlConnection conn = new SqlConnection(connString);
         SqlDataAdapter da = new SqlDataAdapter(sql, conn);
         da.Fill(dataSet1, "employees");

         // Bind text boxes to data columns
         textBox1.DataBindings.Add("text", dataSet1, "employees.firstname");
         textBox2.DataBindings.Add("text", dataSet1, "employees.lastname");
  
         // Create the binding manager (CurrencyManager)
         bMgr = this.BindingContext[dataSet1, "employees"];
      }

      private void buttonNext_Click(object sender, System.EventArgs e)
      {
         // Point to the next row and refresh the contents of the text box
         bMgr.Position += 1;    
      }

      private void buttonBack_Click(object sender, System.EventArgs e)
      {
         // Point to the previous row and refresh contents of the text box
         bMgr.Position -= 1;
      }
	}
}
