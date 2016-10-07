using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AdminHelp
{
	public class QueryForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Panel QueryPanel;
		private System.ComponentModel.Container components = null;

		public QueryForm(SqlCommand sqlCommand)
		{
			InitializeComponent();

			this.sqlCommand = sqlCommand;
			
			if( sqlCommand.Parameters.Count > 0)
			{
				this.Text = String.Format("{0} : {1}={2}", 
					sqlCommand.CommandText,
					sqlCommand.Parameters[0].ParameterName,
					sqlCommand.Parameters[0].Value.ToString());
			}
			else
			{
				this.Text = sqlCommand.CommandText;
			}
			RunQuery();
		}

		protected void RunQuery()
		{
			// remove all controls from our panel
			QueryPanel.Controls.Clear();
		
			SqlDataAdapter sqlAdaptor = new SqlDataAdapter(sqlCommand);
			DataSet dataSet = new DataSet();

			// populate a dataset with all resultsets of the command
			try
			{
				sqlAdaptor.Fill(dataSet);
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
				return;
			}
			
			// controls are added to the panel in an array
			Control [] controls = new Control[dataSet.Tables.Count * 2];

			for(int i = 0; i < dataSet.Tables.Count; i++)
			{	
				// create a grid for current resultset
				DataGrid grid = new DataGrid();
				grid.DataSource = dataSet.Tables[i];
				grid.Dock = DockStyle.Fill;
				grid.ReadOnly = true;
				
				
				// panel to hold the grid and provide scrollbars if nessacary
				Panel panel = new Panel();

				int niceHeight = dataSet.Tables[i].Rows.Count * 25 + 30;
				if(niceHeight < 100)
					niceHeight = 100;
				panel.Height = niceHeight;

				if(i != dataSet.Tables.Count - 1)
				{
					// panel docks to top
					panel.Dock = DockStyle.Top;
					controls[(i*2)] = panel;

					// splitter docks underneath panel
					Splitter splitter = new Splitter();
					splitter.Dock = DockStyle.Top;
					controls[(i*2)+1] = splitter;
				}
				else
				{
					// the last panel is set to fill remaining space
					panel.Dock = DockStyle.Fill;
					controls[(i*2)] = panel;
				}
				
				// add datagrid into panel
				panel.AutoScroll = true;
				SizeColumns(grid);
				panel.Controls.Add(grid);
			}

			// put all these controls on the page
			Array.Reverse(controls);
			QueryPanel.Controls.AddRange(controls);
		}

		protected void SizeColumns(DataGrid grid)
		{
			Graphics g = CreateGraphics();	
			DataTable dataTable = (DataTable)grid.DataSource;
			DataGridTableStyle dataGridTableStyle = new DataGridTableStyle();
			dataGridTableStyle.MappingName = dataTable.TableName;
			
			foreach(DataColumn dataColumn in dataTable.Columns)
			{
				int maxSize = 0;
				SizeF size = g.MeasureString(dataColumn.ColumnName, grid.Font);
				if(size.Width > maxSize)
					maxSize = (int)size.Width;
				foreach(DataRow row in dataTable.Rows)
				{
					size = g.MeasureString(row[dataColumn.ColumnName].ToString(), grid.Font);
					if(size.Width > maxSize)
						maxSize = (int)size.Width;
				}
				
				DataGridColumnStyle dataGridColumnStyle = new DataGridTextBoxColumn();
				dataGridColumnStyle.MappingName = dataColumn.ColumnName;
				dataGridColumnStyle.HeaderText = dataColumn.ColumnName;
				dataGridColumnStyle.Width = maxSize + 5;
				dataGridTableStyle.GridColumnStyles.Add(dataGridColumnStyle);
			}

			grid.TableStyles.Add(dataGridTableStyle);			
			g.Dispose();
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

		
		protected SqlCommand sqlCommand;

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.QueryPanel = new System.Windows.Forms.Panel();
			this.RefreshButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// QueryPanel
			// 
			this.QueryPanel.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.QueryPanel.AutoScroll = true;
			this.QueryPanel.Location = new System.Drawing.Point(8, 8);
			this.QueryPanel.Name = "QueryPanel";
			this.QueryPanel.Size = new System.Drawing.Size(640, 304);
			this.QueryPanel.TabIndex = 0;
			// 
			// RefreshButton
			// 
			this.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.RefreshButton.Location = new System.Drawing.Point(236, 320);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.TabIndex = 1;
			this.RefreshButton.Text = "&Refresh";
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.CloseButton.Location = new System.Drawing.Point(336, 320);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.TabIndex = 2;
			this.CloseButton.Text = "Close";
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// QueryForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 349);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.CloseButton,
																		  this.RefreshButton,
																		  this.QueryPanel});
			this.Name = "QueryForm";
			this.Text = "QueryForm";
			this.ResumeLayout(false);

		}
		#endregion

		private void RefreshButton_Click(object sender, System.EventArgs e)
		{
			RunQuery();
		}

		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
