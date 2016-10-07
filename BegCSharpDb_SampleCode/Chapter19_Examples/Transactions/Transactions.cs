using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Transactions
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
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
         this.label1 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(40, 56);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(56, 23);
         this.label1.TabIndex = 0;
         this.label1.Text = "Order ID";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(104, 56);
         this.textBox1.Name = "textBox1";
         this.textBox1.TabIndex = 1;
         this.textBox1.Text = "";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(40, 96);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(80, 40);
         this.button1.TabIndex = 2;
         this.button1.Text = "Delete Order (Roll back)";
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(144, 96);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(80, 40);
         this.button2.TabIndex = 3;
         this.button2.Text = "Delete Order (Commit)";
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 272);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Transactions";
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

      private void button1_Click(object sender, System.EventArgs e)
      {
         // Create connection
         SqlConnection cn = 
            new SqlConnection(@"Data Source=(local)\NETSDK;" + 
            "Integrated Security=SSPI;database=Northwind");

         // Open connection
         cn.Open();

         // Begin transaction
         SqlTransaction objTrans = cn.BeginTransaction();

         try 
         {      
            // Create command 
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Transaction = objTrans;

            // Delete order
            cmd.CommandText = "DELETE Orders WHERE OrderId = " +
               Convert.ToString(textBox1.Text);
            cmd.ExecuteNonQuery();

            // Commit transaction
            objTrans.Commit();
        
            // No exception, transaction committed, give message 
            MessageBox.Show(
               "Transaction Committed\n" 
               + "Order and Order Details have been successfully deleted.",
               "Commit Transaction");
         }
         catch (System.Data.SqlClient.SqlException ex)
         {
            // Roll back transaction
            objTrans.Rollback();

            MessageBox.Show(
               "Error - TRANSACTION ROLLED BACK\n" + ex.Message,
               "Rollback Transaction"
               );
         }
         catch (System.Exception ex)
         {
            MessageBox.Show("System Error\n" + ex.Message, "Error");
         }
         finally
         {
            // Close connection
            cn.Close();
         }
      }

      private void button2_Click(object sender, System.EventArgs e)
      {
         // Create connection
         SqlConnection cn = 
            new SqlConnection(@"Data Source=(local)\NETSDK;" + 
            "Integrated Security=SSPI;database=Northwind");

         // Open connection
         cn.Open();

         // Begin transaction
         SqlTransaction objTrans = cn.BeginTransaction();

         try
         {
            // Create command 
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Transaction = objTrans;

            //Delete order details
            cmd.CommandText = "DELETE [Order Details] WHERE OrderId = " +
               Convert.ToString(textBox1.Text);
            cmd.ExecuteNonQuery();

            //Delete order
            cmd.CommandText="DELETE Orders WHERE OrderId = " +
               Convert.ToString(textBox1.Text);
            cmd.ExecuteNonQuery();

            //Commit transaction
            objTrans.Commit();

            // No exception, transaction committed, give message 
            MessageBox.Show(
               "Transaction Committed\n" 
               + "Order and Order Details have been successfully deleted.",
               "Commit Transaction");
         }
         catch (System.Data.SqlClient.SqlException  ex)
         {
            //Roll back transaction
            objTrans.Rollback();  

            MessageBox.Show(
               "Error - TRANSACTION ROLLED BACK\n" + ex.Message,
               "Rollback Transaction"
               );
         }
         catch (System.Exception ex)
         {
            MessageBox.Show("System Error\n" + ex.Message, "Error");
         }
         finally
         {
            // Close connection
            cn.Close();  
         }
      }
	}
}
