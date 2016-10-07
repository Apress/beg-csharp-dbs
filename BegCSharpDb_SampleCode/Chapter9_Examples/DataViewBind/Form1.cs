using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataViewBind
{
   public class Form1 : System.Windows.Forms.Form
   {
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Data.DataSet dataSet1;
 
      private System.ComponentModel.Container components = null;

      public Form1()
      {
 
         InitializeComponent();

      }

      protected override void Dispose( bool disposing )
      {
         if ( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

      private void InitializeComponent()
      {
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.dataSet1 = new System.Data.DataSet();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
         this.SuspendLayout();
 
         this.textBox1.Location = new System.Drawing.Point(16, 0);
         this.textBox1.Name = "textBox1";
         this.textBox1.TabIndex = 0;
         this.textBox1.Text = "textBox1";
 
         this.textBox2.Location = new System.Drawing.Point(16, 24);
         this.textBox2.Name = "textBox2";
         this.textBox2.TabIndex = 1;
         this.textBox2.Text = "textBox2";
 
         this.dataSet1.DataSetName = "NewDataSet";
         this.dataSet1.Locale = new System.Globalization.CultureInfo("en-GB");
 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(128, 45);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.textBox2,
                                                                      this.textBox1});
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
         this.ResumeLayout(false);

      }

      [STAThread]
      static void Main() 
      {
         Application.Run(new Form1());
      }

      private void Form1_Load(object sender, System.EventArgs e)
      {
         string ConStr = @"server=(local)\NetSDK;" + 
            "Integrated Security=SSPI;" +
            "database=Northwind";
    
         // Get Data from Employees table
         string SQL = @"
            select
               *
           from 
              employees
         ";

         SqlConnection Conn = new SqlConnection(ConStr);
         SqlDataAdapter da = new SqlDataAdapter(SQL, Conn);

         // Fill DataSet with data 
         da.Fill(dataSet1, "Employees");

         DataTable myTable = dataSet1.Tables["Employees"];
         // Create a DataView, set a Filter and a Sort order
         DataView dv = new DataView(myTable, "Country='UK'",
            "FirstName", DataViewRowState.CurrentRows);

         // Bind the Text property to the FirstName
         // column of the Employees table
         textBox1.DataBindings.Add("Text", dv, "FirstName");
         // Bind the Text property to the LastName
         // column of the Employees table 
         textBox2.DataBindings.Add("Text", dv, "LastName");
      }
   }
}
