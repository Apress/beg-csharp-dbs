using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataSetBind
{
 
   public class Form1 : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Data.DataSet dataSet1;
 
      private System.ComponentModel.Container components = null;

      public Form1()
      { 
 
         InitializeComponent();
      }

      protected override void Dispose( bool disposing )
      {
         if (disposing)
         {
            if  (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose(disposing);
      }

      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.dataSet1 = new System.Data.DataSet();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
         this.SuspendLayout();
 
         this.label1.Location = new System.Drawing.Point(16, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(72, 16);
         this.label1.TabIndex = 0;
         this.label1.Text = "label1";
 
         this.label2.Location = new System.Drawing.Point(16, 40);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(72, 16);
         this.label2.TabIndex = 1;
         this.label2.Text = "label2";
 
         this.dataSet1.DataSetName = "NewDataSet";
         this.dataSet1.Locale = new System.Globalization.CultureInfo("en-GB");
 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(128, 69);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.label2,
                                                                      this.label1});
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
            products
       ";

         SqlConnection Conn = new SqlConnection(ConStr);
         SqlDataAdapter da = new SqlDataAdapter(SQL, Conn);

         // Fill DataSet with data 
         da.Fill(dataSet1, "Products");

         // Bind the Label's Text property to the ProductID of the Products table
         label1.DataBindings.Add("Text", dataSet1, "Products.ProductName");
         // Bind the second label's Text property to the UnitPrice column
         label2.DataBindings.Add("Text", dataSet1, "Products.UnitPrice");
      }
   }
}
