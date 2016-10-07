using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QueryApplication
{
	/// <summary>
	/// Summary description for Queries.
	/// </summary>
	public class Queries : System.Windows.Forms.Form
	{
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button cmdExecute;
      private System.Windows.Forms.TextBox txtSql;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Queries()
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
				if(components != null)
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
         this.txtSql = new System.Windows.Forms.TextBox();
         this.txtResult = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.cmdExecute = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtSql
         // 
         this.txtSql.Location = new System.Drawing.Point(0, 32);
         this.txtSql.Multiline = true;
         this.txtSql.Name = "txtSql";
         this.txtSql.Size = new System.Drawing.Size(400, 72);
         this.txtSql.TabIndex = 0;
         this.txtSql.Text = "";
         // 
         // txtResult
         // 
         this.txtResult.Location = new System.Drawing.Point(0, 184);
         this.txtResult.Multiline = true;
         this.txtResult.Name = "txtResult";
         this.txtResult.Size = new System.Drawing.Size(400, 88);
         this.txtResult.TabIndex = 1;
         this.txtResult.Text = "";
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.label1.Location = new System.Drawing.Point(8, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(384, 16);
         this.label1.TabIndex = 2;
         this.label1.Text = "Type a SQL statement in the text box.";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label2
         // 
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.label2.Location = new System.Drawing.Point(0, 160);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(392, 16);
         this.label2.TabIndex = 3;
         this.label2.Text = "Execution Result";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // cmdExecute
         // 
         this.cmdExecute.Location = new System.Drawing.Point(152, 112);
         this.cmdExecute.Name = "cmdExecute";
         this.cmdExecute.Size = new System.Drawing.Size(104, 32);
         this.cmdExecute.TabIndex = 4;
         this.cmdExecute.Text = "Execute Command";
         this.cmdExecute.Click += new System.EventHandler(this.cmdExecute_Click);
         // 
         // Queries
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(400, 275);
         this.Controls.Add(this.cmdExecute);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtResult);
         this.Controls.Add(this.txtSql);
         this.Name = "Queries";
         this.Text = "Tables and Relationships";
         this.ResumeLayout(false);

      }
		#endregion


    private void cmdExecute_Click(object sender, System.EventArgs e)
    {
         try
         {
            //Create connection
            SqlConnection conn = new SqlConnection(@"
               Data Source=(local)\NETSDK; 
               Integrated Security=SSPI;
               database=Northwind
            "); 

            //Open connection
            conn.Open();
            //Get the SQL from the text box
            string strSQL=txtSql.Text;
            // Create command
            SqlCommand cmd= new SqlCommand(strSQL, conn);

            //Execute command   
            cmd.ExecuteNonQuery();
            // Close connection.
            conn.Close();
            // Display result message.
            txtResult.Text = "SQL executed successfully.";
         }
         catch (System.Data.SqlClient.SqlException ex)
         {
            // Display error message.
            txtResult.Text =
               "There was an error in executing the SQL. " +
               "Error Message:" + ex.Message; 
         }

    }
    static void Main() 
    {
      Application.Run(new Queries());
    }
	}
}
