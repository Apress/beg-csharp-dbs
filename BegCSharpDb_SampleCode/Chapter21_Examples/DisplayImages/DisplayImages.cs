using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DisplayImages
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private Images images;
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

         images = new Images();

         if (images.GetRow()) 
         {
            this.textBox1.Text = images.GetFilename();
            this.pictureBox1.Image = (Image)images.GetImage();
         } 
         else 
         {
            this.textBox1.Text = "DONE";
            this.pictureBox1.Image = null;
         }
      }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
            images.EndImages();			if( disposing )
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
         this.button1 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(200, 8);
         this.button1.Name = "button1";
         this.button1.TabIndex = 0;
         this.button1.Text = "Next";
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(24, 8);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(144, 20);
         this.textBox1.TabIndex = 1;
         this.textBox1.Text = "";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(8, 48);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(280, 208);
         this.pictureBox1.TabIndex = 2;
         this.pictureBox1.TabStop = false;
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 272);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button1);
         this.Name = "Form1";
         this.Text = "Display Images";
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
         if (images.GetRow()) 
         {
            this.textBox1.Text = images.GetFilename();
            this.pictureBox1.Image = (Image)images.GetImage();
         } 
         else 
         {
            this.textBox1.Text = "DONE";
            this.pictureBox1.Image = null;
         }

      }
	}
}
