using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminHelp
{
	public class PickOne : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button Ok;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.ComboBox PickList;
		private System.ComponentModel.Container components = null;

		protected ArrayList list = null;

		public PickOne(string title)
		{
			InitializeComponent();
			this.Text = title;
			list = new ArrayList();
		}

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

		public void AppendListContents(SqlDataReader sqlDataReader, string fieldName)
		{
			while(sqlDataReader.Read())
			{
				list.Add(sqlDataReader[fieldName]);
			}
			PickList.DataSource = list;
		}

		public void AppendListContents(string [] items)
		{
			for(int i = 0; i < items.Length; i++)
			{
				list.Add(items[i]);
			}
		}

		public string Selected
		{
			get { return PickList.SelectedItem.ToString(); }
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Ok = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.PickList = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// Ok
			// 
			this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Ok.Location = new System.Drawing.Point(56, 48);
			this.Ok.Name = "Ok";
			this.Ok.TabIndex = 0;
			this.Ok.Text = "&Ok";
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(152, 48);
			this.Cancel.Name = "Cancel";
			this.Cancel.TabIndex = 1;
			this.Cancel.Text = "&Cancel";
			// 
			// PickList
			// 
			this.PickList.Location = new System.Drawing.Point(16, 8);
			this.PickList.Name = "PickList";
			this.PickList.Size = new System.Drawing.Size(256, 21);
			this.PickList.TabIndex = 2;
			this.PickList.Text = "comboBox1";
			// 
			// PickOne
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 85);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.PickList,
																		  this.Cancel,
																		  this.Ok});
			this.Name = "PickOne";
			this.Text = "PickOne";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
