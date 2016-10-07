using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AdminHelp
{
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuNew;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.Button LoginsButton;
		private System.Windows.Forms.Button ValidateLoginsButton;

		private SqlConnection sqlConnection = null;
		private System.Windows.Forms.Button ViewUsers;
		private System.Windows.Forms.Button ServerRoles;
		private System.Windows.Forms.Button ServerRoleMembers;
		private System.Windows.Forms.Button ServerRolePermissions;
		private System.Windows.Forms.Button FixedDbRoles;
		private System.Windows.Forms.Button RoleMembers;
		private System.Windows.Forms.Button FixedRolePermissions;
		private System.Windows.Forms.Button PermissionUser;
		private System.Windows.Forms.Button PermissionObject;
		private System.Windows.Forms.Button AllPermissions;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button ViewRoles;

		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			InitializeComponent();
		}

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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuNew = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.LoginsButton = new System.Windows.Forms.Button();
			this.ValidateLoginsButton = new System.Windows.Forms.Button();
			this.ViewUsers = new System.Windows.Forms.Button();
			this.ServerRoles = new System.Windows.Forms.Button();
			this.ServerRoleMembers = new System.Windows.Forms.Button();
			this.ServerRolePermissions = new System.Windows.Forms.Button();
			this.FixedDbRoles = new System.Windows.Forms.Button();
			this.RoleMembers = new System.Windows.Forms.Button();
			this.FixedRolePermissions = new System.Windows.Forms.Button();
			this.PermissionUser = new System.Windows.Forms.Button();
			this.PermissionObject = new System.Windows.Forms.Button();
			this.AllPermissions = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ViewRoles = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuNew,
																					  this.menuExit});
			this.menuItem1.Text = "&File";
			// 
			// menuNew
			// 
			this.menuNew.Index = 0;
			this.menuNew.Text = "&Connect to Database";
			this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
			// 
			// menuExit
			// 
			this.menuExit.Index = 1;
			this.menuExit.Text = "&Exit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// LoginsButton
			// 
			this.LoginsButton.Location = new System.Drawing.Point(16, 56);
			this.LoginsButton.Name = "LoginsButton";
			this.LoginsButton.Size = new System.Drawing.Size(96, 32);
			this.LoginsButton.TabIndex = 0;
			this.LoginsButton.Text = "View Logins";
			this.LoginsButton.Click += new System.EventHandler(this.LoginsButton_Click);
			// 
			// ValidateLoginsButton
			// 
			this.ValidateLoginsButton.Location = new System.Drawing.Point(16, 104);
			this.ValidateLoginsButton.Name = "ValidateLoginsButton";
			this.ValidateLoginsButton.Size = new System.Drawing.Size(96, 32);
			this.ValidateLoginsButton.TabIndex = 1;
			this.ValidateLoginsButton.Text = "Validate Logins";
			this.ValidateLoginsButton.Click += new System.EventHandler(this.ValidateLoginsButton_Click);
			// 
			// ViewUsers
			// 
			this.ViewUsers.Location = new System.Drawing.Point(152, 56);
			this.ViewUsers.Name = "ViewUsers";
			this.ViewUsers.Size = new System.Drawing.Size(96, 32);
			this.ViewUsers.TabIndex = 2;
			this.ViewUsers.Text = "View Users";
			this.ViewUsers.Click += new System.EventHandler(this.ViewUsers_Click);
			// 
			// ServerRoles
			// 
			this.ServerRoles.Location = new System.Drawing.Point(16, 152);
			this.ServerRoles.Name = "ServerRoles";
			this.ServerRoles.Size = new System.Drawing.Size(96, 32);
			this.ServerRoles.TabIndex = 3;
			this.ServerRoles.Text = "Server Roles";
			this.ServerRoles.Click += new System.EventHandler(this.ServerRoles_Click);
			// 
			// ServerRoleMembers
			// 
			this.ServerRoleMembers.Location = new System.Drawing.Point(16, 200);
			this.ServerRoleMembers.Name = "ServerRoleMembers";
			this.ServerRoleMembers.Size = new System.Drawing.Size(96, 32);
			this.ServerRoleMembers.TabIndex = 4;
			this.ServerRoleMembers.Text = "Server Role Members";
			this.ServerRoleMembers.Click += new System.EventHandler(this.ServerRoleMembers_Click);
			// 
			// ServerRolePermissions
			// 
			this.ServerRolePermissions.Location = new System.Drawing.Point(16, 248);
			this.ServerRolePermissions.Name = "ServerRolePermissions";
			this.ServerRolePermissions.Size = new System.Drawing.Size(96, 32);
			this.ServerRolePermissions.TabIndex = 5;
			this.ServerRolePermissions.Text = "Server Role Permissions";
			this.ServerRolePermissions.Click += new System.EventHandler(this.ServerRolePermissions_Click);
			// 
			// FixedDbRoles
			// 
			this.FixedDbRoles.Location = new System.Drawing.Point(24, 160);
			this.FixedDbRoles.Name = "FixedDbRoles";
			this.FixedDbRoles.Size = new System.Drawing.Size(96, 32);
			this.FixedDbRoles.TabIndex = 6;
			this.FixedDbRoles.Text = "Fixed Roles";
			this.FixedDbRoles.Click += new System.EventHandler(this.FixedDbRoles_Click);
			// 
			// RoleMembers
			// 
			this.RoleMembers.Location = new System.Drawing.Point(24, 112);
			this.RoleMembers.Name = "RoleMembers";
			this.RoleMembers.Size = new System.Drawing.Size(96, 32);
			this.RoleMembers.TabIndex = 7;
			this.RoleMembers.Text = "Role Members";
			this.RoleMembers.Click += new System.EventHandler(this.RoleMembers_Click);
			// 
			// FixedRolePermissions
			// 
			this.FixedRolePermissions.Location = new System.Drawing.Point(24, 208);
			this.FixedRolePermissions.Name = "FixedRolePermissions";
			this.FixedRolePermissions.Size = new System.Drawing.Size(96, 32);
			this.FixedRolePermissions.TabIndex = 8;
			this.FixedRolePermissions.Text = "Fixed Role Permissions";
			this.FixedRolePermissions.Click += new System.EventHandler(this.FixedRolePermissions_Click);
			// 
			// PermissionUser
			// 
			this.PermissionUser.Location = new System.Drawing.Point(272, 104);
			this.PermissionUser.Name = "PermissionUser";
			this.PermissionUser.Size = new System.Drawing.Size(96, 32);
			this.PermissionUser.TabIndex = 9;
			this.PermissionUser.Text = "Permissions By User/Role";
			this.PermissionUser.Click += new System.EventHandler(this.PermissionUser_Click);
			// 
			// PermissionObject
			// 
			this.PermissionObject.Location = new System.Drawing.Point(272, 152);
			this.PermissionObject.Name = "PermissionObject";
			this.PermissionObject.Size = new System.Drawing.Size(96, 32);
			this.PermissionObject.TabIndex = 10;
			this.PermissionObject.Text = "Permissions By Object";
			this.PermissionObject.Click += new System.EventHandler(this.PermissionObject_Click);
			// 
			// AllPermissions
			// 
			this.AllPermissions.Location = new System.Drawing.Point(272, 56);
			this.AllPermissions.Name = "AllPermissions";
			this.AllPermissions.Size = new System.Drawing.Size(96, 32);
			this.AllPermissions.TabIndex = 11;
			this.AllPermissions.Text = "All Permissions";
			this.AllPermissions.Click += new System.EventHandler(this.AllPermissions_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 32);
			this.label1.TabIndex = 12;
			this.label1.Text = "Server Settings";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(224, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 32);
			this.label2.TabIndex = 13;
			this.label2.Text = "Database Settings";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(8, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(112, 248);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.RoleMembers,
																					this.FixedRolePermissions,
																					this.FixedDbRoles,
																					this.ViewRoles});
			this.groupBox2.Location = new System.Drawing.Point(128, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(248, 248);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			// 
			// ViewRoles
			// 
			this.ViewRoles.Location = new System.Drawing.Point(24, 64);
			this.ViewRoles.Name = "ViewRoles";
			this.ViewRoles.Size = new System.Drawing.Size(96, 32);
			this.ViewRoles.TabIndex = 16;
			this.ViewRoles.Text = "View Roles";
			this.ViewRoles.Click += new System.EventHandler(this.ViewRoles_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(384, 297);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.label1,
																		  this.AllPermissions,
																		  this.PermissionObject,
																		  this.PermissionUser,
																		  this.ServerRolePermissions,
																		  this.ServerRoleMembers,
																		  this.ServerRoles,
																		  this.ViewUsers,
																		  this.ValidateLoginsButton,
																		  this.LoginsButton,
																		  this.groupBox1,
																		  this.groupBox2});
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.Text = "Admin Help";
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

      protected void GetNewConnection()
      {
         string connString = @"
            server=(local)\netsdk;
            integrated security = sspi;
            database = northwind
         ";

         sqlConnection = new SqlConnection(connString);
         sqlConnection.Open();
      }


		protected void CheckConnection()
		{
			if(sqlConnection == null)
			{
				GetNewConnection();
			}
		}												  

		private void menuNew_Click(object sender, System.EventArgs e)
		{
			GetNewConnection();				
		}

		private void menuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void LoginsButton_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = GetLoginsCommand();
				QueryForm queryForm = new QueryForm(sqlCommand);
				queryForm.ShowDialog();
			}
		}

		private void ValidateLoginsButton_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = GetValidateLoginsCommand();
				QueryForm queryForm = new QueryForm(sqlCommand);
				queryForm.ShowDialog();
			}
		}

		private void ViewUsers_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = GetUsersCommand();
				QueryForm queryForm = new QueryForm(sqlCommand);
				queryForm.ShowDialog();
			}
		}

		private void ServerRoles_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = GetServerRoleCommand();
				QueryForm queryForm = new QueryForm(sqlCommand);
				queryForm.ShowDialog();
			}		
		}

		private void ServerRoleMembers_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = GetServerRoleMembersCommand();
				QueryForm queryForm = new QueryForm(sqlCommand);
				queryForm.ShowDialog();

			}
		}

		private void ServerRolePermissions_Click(object sender, System.EventArgs e)
		{

			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = GetServerRoleCommand();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

				PickOne pickOne = new PickOne("Select a server role");
				pickOne.AppendListContents(sqlDataReader, "ServerRole");

				sqlDataReader.Close();
				
				if(pickOne.ShowDialog() == DialogResult.OK)
				{
					sqlCommand = GetServerRolePermissionCommand();
					SqlParameter sqlParameter = new SqlParameter("@srvrolename", pickOne.Selected);
					sqlCommand.Parameters.Add(sqlParameter);
					
					QueryForm queryForm = new QueryForm(sqlCommand);
					queryForm.ShowDialog();
				}
			}
		}

		private void FixedDbRoles_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = GetFixedDbRolesCommand();
				QueryForm queryForm = new QueryForm(sqlCommand);
				queryForm.ShowDialog();
			}						
		}

		private void RoleMembers_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = GetRoleMembersCommand();
				QueryForm queryForm = new QueryForm(sqlCommand);
				queryForm.ShowDialog();
			}								
		}

		private void FixedRolePermissions_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = GetFixedDbRolesCommand();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

				PickOne pickOne = new PickOne("Select a server role");
				pickOne.AppendListContents(sqlDataReader, "DbFixedRole");

				sqlDataReader.Close();
				
				if(pickOne.ShowDialog() == DialogResult.OK)
				{
					sqlCommand = GetDbFixedRolePermissionsCommand();
					SqlParameter sqlParameter = new SqlParameter("@rolename", pickOne.Selected);
					sqlCommand.Parameters.Add(sqlParameter);
							
					QueryForm queryForm = new QueryForm(sqlCommand);
					queryForm.ShowDialog();
				}
			}
		}

		private void AllPermissions_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = GetPermissionsCommand();
				QueryForm queryForm = new QueryForm(sqlCommand);
				queryForm.ShowDialog();
			}										
		}

		private void PermissionUser_Click(object sender, System.EventArgs e)
		{
			// need to pick up all roles and all users in the current database
			CheckConnection();
			if(sqlConnection != null)
			{
				PickOne pickOne = new PickOne("Select a user or role");
				
				SqlCommand sqlCommand = GetUsersCommand();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

				pickOne.AppendListContents(sqlDataReader, "UserName");

				sqlDataReader.Close();

				sqlCommand = GetRolesCommand();
				sqlDataReader = sqlCommand.ExecuteReader();
				
				pickOne.AppendListContents(sqlDataReader, "RoleName");

				sqlDataReader.Close();

				if(pickOne.ShowDialog() == DialogResult.OK)
				{
					sqlCommand = GetPermissionsCommand();
					SqlParameter sqlParameter = new SqlParameter("@username", pickOne.Selected);
					sqlCommand.Parameters.Add(sqlParameter);

					QueryForm queryForm = new QueryForm(sqlCommand);
					queryForm.ShowDialog();
				}
				
			}
		}

		private void PermissionObject_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				PickOne pickOne = new PickOne("Select an object or statement");
				
				SqlCommand sqlCommand = GetUserObjectsCommand();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

				pickOne.AppendListContents(sqlDataReader, "name");

				sqlDataReader.Close();

				string [] statementPermissions = 
					{
						"CREATE DATABASE",  "CREATE DEFAULT",  "CREATE FUNCTION", 
						"CREATE PROCEDURE", "CREATE RULE",     "CREATE TABLE",
						"CREATE VIEW",      "BACKUP DATABASE", "BACKUP LOG"
					};
				
				pickOne.AppendListContents(statementPermissions);

				if(pickOne.ShowDialog() == DialogResult.OK)
				{
					sqlCommand = GetPermissionsCommand();
					SqlParameter sqlParameter = new SqlParameter("@name", pickOne.Selected);
					sqlCommand.Parameters.Add(sqlParameter);

					QueryForm queryForm = new QueryForm(sqlCommand);
					queryForm.ShowDialog();
				}
			}
		}

		private void ViewRoles_Click(object sender, System.EventArgs e)
		{
			CheckConnection();
			if(sqlConnection != null)
			{
				SqlCommand sqlCommand = this.GetRolesCommand();
				QueryForm queryForm = new QueryForm(sqlCommand);
				queryForm.ShowDialog();
			}
		}


		#region Command Helpers
		private SqlCommand GetSPCommand()
		{
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandType = CommandType.StoredProcedure;
			return sqlCommand;
		}

		private SqlCommand GetLoginsCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_helplogins";
			return sqlCommand;
		}

		private SqlCommand GetValidateLoginsCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_validatelogins";
			return sqlCommand;
		}

		private SqlCommand GetUsersCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_helpuser";
			return sqlCommand;
		}
	
		private SqlCommand GetServerRoleCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_helpsrvrole";
			return sqlCommand;
		}

		private SqlCommand GetServerRoleMembersCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_helpsrvrolemember";
			return sqlCommand;
		}

		private SqlCommand GetServerRolePermissionCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_srvrolepermission";
			return sqlCommand;
		}
		
		private SqlCommand GetFixedDbRolesCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_helpdbfixedrole";
			return sqlCommand;
		}

		private SqlCommand GetRolesCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_helprole";
			return sqlCommand;
		}
		
		private SqlCommand GetRoleMembersCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_helprolemember";
			return sqlCommand;
		}
		
		private SqlCommand GetDbFixedRolePermissionsCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_dbfixedrolepermission";
			return sqlCommand;
		}
		
		private SqlCommand GetPermissionsCommand()
		{
			SqlCommand sqlCommand = GetSPCommand();
			sqlCommand.CommandText = "sp_helprotect";
			return sqlCommand;
		}

		private SqlCommand GetUserObjectsCommand()
		{
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = sqlConnection;
			
			sqlCommand.CommandText = "SELECT name " +
				"FROM sysobjects " + 
				"WHERE (type='P' OR type='U' OR type='V') and " +
				"NOT objectproperty (id, 'IsMSShipped') > 0 " +
				"ORDER BY name";
			return sqlCommand;
		}

		#endregion
	}
}

