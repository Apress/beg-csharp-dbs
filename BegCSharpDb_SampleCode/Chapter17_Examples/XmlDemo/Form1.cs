using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;

namespace XmlDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.Button btnReadXml;
      private System.Windows.Forms.Button btnWriteXml;
      private System.Windows.Forms.Button btnConfigXml;
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
         this.btnReadXml = new System.Windows.Forms.Button();
         this.btnWriteXml = new System.Windows.Forms.Button();
         this.btnConfigXml = new System.Windows.Forms.Button();
         this.dataGrid1 = new System.Windows.Forms.DataGrid();
         ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
         this.SuspendLayout();
         // 
         // btnReadXml
         // 
         this.btnReadXml.Location = new System.Drawing.Point(8, 8);
         this.btnReadXml.Name = "btnReadXml";
         this.btnReadXml.TabIndex = 0;
         this.btnReadXml.Text = "Read XML";
         this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
         // 
         // btnWriteXml
         // 
         this.btnWriteXml.Location = new System.Drawing.Point(8, 48);
         this.btnWriteXml.Name = "btnWriteXml";
         this.btnWriteXml.TabIndex = 1;
         this.btnWriteXml.Text = "Write XML";
         this.btnWriteXml.Click += new System.EventHandler(this.btnWriteXml_Click);
         // 
         // btnConfigXml
         // 
         this.btnConfigXml.Location = new System.Drawing.Point(8, 88);
         this.btnConfigXml.Name = "btnConfigXml";
         this.btnConfigXml.TabIndex = 2;
         this.btnConfigXml.Text = "Config";
         this.btnConfigXml.Click += new System.EventHandler(this.btnConfigXml_Click);
         // 
         // dataGrid1
         // 
         this.dataGrid1.DataMember = "";
         this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
         this.dataGrid1.Location = new System.Drawing.Point(104, 8);
         this.dataGrid1.Name = "dataGrid1";
         this.dataGrid1.Size = new System.Drawing.Size(184, 192);
         this.dataGrid1.TabIndex = 3;
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 272);
         this.Controls.Add(this.dataGrid1);
         this.Controls.Add(this.btnConfigXml);
         this.Controls.Add(this.btnWriteXml);
         this.Controls.Add(this.btnReadXml);
         this.Name = "Form1";
         this.Text = "XML Demo";
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

      private void btnReadXml_Click(object sender, System.EventArgs e)
      {
         DataSet ds = new DataSet();
         ds.ReadXml(
            @"c:\BegCSharpDb\Chapter17_Examples\XmlDemo\XMLFile1.xml",
            XmlReadMode.InferSchema
            );
         dataGrid1.SetDataBinding(ds, "book");
      }

      private void btnWriteXml_Click(object sender, System.EventArgs e)
      {
         DataSet ds = (DataSet) dataGrid1.DataSource;
         ds.WriteXml(
            @"c:\BegCSharpDb\Chapter17_Examples\XmlDemo\XMLFileOut.xml",
            XmlWriteMode.IgnoreSchema
            );    
      }

      private void btnConfigXml_Click(object sender, System.EventArgs e)
      {
         // Get connection string from.config file
         string connString = ConfigurationSettings.AppSettings["cnnorthwind"];

         // Create connection
         SqlConnection conn = new SqlConnection(connString);

         // Create command to retrieve all employees in XML format
         SqlCommand cmd = new SqlCommand();
         cmd.Connection = conn;
         cmd.CommandText = @"
            select
               employeeid,
               lastname
            from
               employees
            for xml auto
         ";

         try
         {
            // Open connection
            conn.Open();
        
            // Get XML reader
            XmlReader xmlrdr = cmd.ExecuteXmlReader();

            // Create a data set
            DataSet ds = new DataSet();

            // Read the XmlReader object into the dataset
            ds.ReadXml(xmlrdr,XmlReadMode.InferSchema);

            // Bind dataset to datagrid
            dataGrid1.DataSource=ds;
         }
         catch (SqlException ex)
         {
            MessageBox.Show (ex.Message);
         }
         finally 
         {
            conn.Close();
         }
      }
	}
}
