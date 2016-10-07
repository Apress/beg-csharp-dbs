using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DataFormWizard
{
	/// <summary>
	/// Summary description for DataForm1.
	/// </summary>
	public class DataForm1 : System.Windows.Forms.Form
	{
      private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
      private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
      private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
      private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
      private System.Data.OleDb.OleDbConnection oleDbConnection1;
      private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
      private DataFormWizard.DataSet1 objDataSet1;
      private System.Windows.Forms.Button btnLoad;
      private System.Windows.Forms.Button btnUpdate;
      private System.Windows.Forms.Button btnCancelAll;
      private System.Windows.Forms.DataGrid grdEmployees;
      private System.Windows.Forms.DataGridTableStyle objTableStylegrdEmployeesEmployees;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesEmployeeID;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesLastName;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesFirstName;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesTitle;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesTitleOfCourtesy;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesBirthDate;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesHireDate;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesAddress;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesCity;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesRegion;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesPostalCode;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesCountry;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesHomePhone;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesExtension;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesNotes;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesReportsTo;
      private System.Windows.Forms.DataGridTextBoxColumn objColumnStylegrdEmployeesPhotoPath;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DataForm1()
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
         this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
         this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
         this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
         this.objDataSet1 = new DataFormWizard.DataSet1();
         this.btnLoad = new System.Windows.Forms.Button();
         this.btnUpdate = new System.Windows.Forms.Button();
         this.btnCancelAll = new System.Windows.Forms.Button();
         this.grdEmployees = new System.Windows.Forms.DataGrid();
         this.objTableStylegrdEmployeesEmployees = new System.Windows.Forms.DataGridTableStyle();
         this.objColumnStylegrdEmployeesEmployeeID = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesLastName = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesFirstName = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesTitle = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesTitleOfCourtesy = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesBirthDate = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesHireDate = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesAddress = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesCity = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesRegion = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesPostalCode = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesCountry = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesHomePhone = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesExtension = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesNotes = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesReportsTo = new System.Windows.Forms.DataGridTextBoxColumn();
         this.objColumnStylegrdEmployeesPhotoPath = new System.Windows.Forms.DataGridTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.objDataSet1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
         this.SuspendLayout();
         // 
         // oleDbSelectCommand1
         // 
         this.oleDbSelectCommand1.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDa" +
            "te, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Not" +
            "es, ReportsTo, PhotoPath FROM Employees";
         this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
         // 
         // oleDbInsertCommand1
         // 
         this.oleDbInsertCommand1.CommandText = @"INSERT INTO Employees(LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?); SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath FROM Employees WHERE (EmployeeID = @@IDENTITY)";
         this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, "TitleOfCourtesy"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "BirthDate"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "HireDate"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "HomePhone"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Extension", System.Data.OleDb.OleDbType.VarWChar, 4, "Extension"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Photo", System.Data.OleDb.OleDbType.VarBinary, 2147483647, "Photo"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 1073741823, "Notes"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ReportsTo", System.Data.OleDb.OleDbType.Integer, 4, "ReportsTo"));
         this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PhotoPath", System.Data.OleDb.OleDbType.VarWChar, 255, "PhotoPath"));
         // 
         // oleDbUpdateCommand1
         // 
         this.oleDbUpdateCommand1.CommandText = @"UPDATE Employees SET LastName = ?, FirstName = ?, Title = ?, TitleOfCourtesy = ?, BirthDate = ?, HireDate = ?, Address = ?, City = ?, Region = ?, PostalCode = ?, Country = ?, HomePhone = ?, Extension = ?, Photo = ?, Notes = ?, ReportsTo = ?, PhotoPath = ? WHERE (EmployeeID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (BirthDate = ? OR ? IS NULL AND BirthDate IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Extension = ? OR ? IS NULL AND Extension IS NULL) AND (FirstName = ?) AND (HireDate = ? OR ? IS NULL AND HireDate IS NULL) AND (HomePhone = ? OR ? IS NULL AND HomePhone IS NULL) AND (LastName = ?) AND (PhotoPath = ? OR ? IS NULL AND PhotoPath IS NULL) AND (PostalCode = ? OR ? IS NULL AND PostalCode IS NULL) AND (Region = ? OR ? IS NULL AND Region IS NULL) AND (ReportsTo = ? OR ? IS NULL AND ReportsTo IS NULL) AND (Title = ? OR ? IS NULL AND Title IS NULL) AND (TitleOfCourtesy = ? OR ? IS NULL AND TitleOfCourtesy IS NULL); SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath FROM Employees WHERE (EmployeeID = ?)";
         this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, "TitleOfCourtesy"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "BirthDate"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "HireDate"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "HomePhone"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Extension", System.Data.OleDb.OleDbType.VarWChar, 4, "Extension"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Photo", System.Data.OleDb.OleDbType.VarBinary, 2147483647, "Photo"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 1073741823, "Notes"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ReportsTo", System.Data.OleDb.OleDbType.Integer, 4, "ReportsTo"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PhotoPath", System.Data.OleDb.OleDbType.VarWChar, 255, "PhotoPath"));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PhotoPath", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PhotoPath", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PhotoPath1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PhotoPath", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReportsTo", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReportsTo1", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
         this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Select_EmployeeID", System.Data.OleDb.OleDbType.Integer, 4, "EmployeeID"));
         // 
         // oleDbDeleteCommand1
         // 
         this.oleDbDeleteCommand1.CommandText = @"DELETE FROM Employees WHERE (EmployeeID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (BirthDate = ? OR ? IS NULL AND BirthDate IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (Extension = ? OR ? IS NULL AND Extension IS NULL) AND (FirstName = ?) AND (HireDate = ? OR ? IS NULL AND HireDate IS NULL) AND (HomePhone = ? OR ? IS NULL AND HomePhone IS NULL) AND (LastName = ?) AND (PhotoPath = ? OR ? IS NULL AND PhotoPath IS NULL) AND (PostalCode = ? OR ? IS NULL AND PostalCode IS NULL) AND (Region = ? OR ? IS NULL AND Region IS NULL) AND (ReportsTo = ? OR ? IS NULL AND ReportsTo IS NULL) AND (Title = ? OR ? IS NULL AND Title IS NULL) AND (TitleOfCourtesy = ? OR ? IS NULL AND TitleOfCourtesy IS NULL)";
         this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_BirthDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Extension1", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PhotoPath", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PhotoPath", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PhotoPath1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PhotoPath", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReportsTo", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ReportsTo1", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
         this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TitleOfCourtesy1", System.Data.OleDb.OleDbType.VarWChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
         // 
         // oleDbConnection1
         // 
         this.oleDbConnection1.ConnectionString = @"Integrated Security=SSPI;Packet Size=4096;Data Source=""(local)\netsdk"";Tag with column collation when possible=False;Initial Catalog=northwind;Use Procedure for Prepare=1;Auto Translate=True;Persist Security Info=False;Provider=""SQLOLEDB.1"";Workstation ID=DB54G821;Use Encryption for Data=False";
         // 
         // oleDbDataAdapter1
         // 
         this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
         this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
         this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
         this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                    new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Title", "Title"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("TitleOfCourtesy", "TitleOfCourtesy"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Address", "Address"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("City", "City"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Region", "Region"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Country", "Country"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Extension", "Extension"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Photo", "Photo"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Notes", "Notes"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ReportsTo", "ReportsTo"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("PhotoPath", "PhotoPath")})});
         this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
         // 
         // objDataSet1
         // 
         this.objDataSet1.DataSetName = "DataSet1";
         this.objDataSet1.Locale = new System.Globalization.CultureInfo("en-US");
         // 
         // btnLoad
         // 
         this.btnLoad.Location = new System.Drawing.Point(10, 10);
         this.btnLoad.Name = "btnLoad";
         this.btnLoad.TabIndex = 0;
         this.btnLoad.Text = "&Load";
         this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
         // 
         // btnUpdate
         // 
         this.btnUpdate.Location = new System.Drawing.Point(315, 10);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.TabIndex = 1;
         this.btnUpdate.Text = "&Update";
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // btnCancelAll
         // 
         this.btnCancelAll.Location = new System.Drawing.Point(315, 43);
         this.btnCancelAll.Name = "btnCancelAll";
         this.btnCancelAll.TabIndex = 2;
         this.btnCancelAll.Text = "Ca&ncel All";
         this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
         // 
         // grdEmployees
         // 
         this.grdEmployees.DataMember = "Employees";
         this.grdEmployees.DataSource = this.objDataSet1;
         this.grdEmployees.HeaderForeColor = System.Drawing.SystemColors.ControlText;
         this.grdEmployees.Location = new System.Drawing.Point(10, 76);
         this.grdEmployees.Name = "grdEmployees";
         this.grdEmployees.Size = new System.Drawing.Size(380, 164);
         this.grdEmployees.TabIndex = 3;
         this.grdEmployees.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
                                                                                                 this.objTableStylegrdEmployeesEmployees});
         // 
         // objTableStylegrdEmployeesEmployees
         // 
         this.objTableStylegrdEmployeesEmployees.DataGrid = this.grdEmployees;
         this.objTableStylegrdEmployeesEmployees.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
                                                                                                                             this.objColumnStylegrdEmployeesEmployeeID,
                                                                                                                             this.objColumnStylegrdEmployeesLastName,
                                                                                                                             this.objColumnStylegrdEmployeesFirstName,
                                                                                                                             this.objColumnStylegrdEmployeesTitle,
                                                                                                                             this.objColumnStylegrdEmployeesTitleOfCourtesy,
                                                                                                                             this.objColumnStylegrdEmployeesBirthDate,
                                                                                                                             this.objColumnStylegrdEmployeesHireDate,
                                                                                                                             this.objColumnStylegrdEmployeesAddress,
                                                                                                                             this.objColumnStylegrdEmployeesCity,
                                                                                                                             this.objColumnStylegrdEmployeesRegion,
                                                                                                                             this.objColumnStylegrdEmployeesPostalCode,
                                                                                                                             this.objColumnStylegrdEmployeesCountry,
                                                                                                                             this.objColumnStylegrdEmployeesHomePhone,
                                                                                                                             this.objColumnStylegrdEmployeesExtension,
                                                                                                                             this.objColumnStylegrdEmployeesNotes,
                                                                                                                             this.objColumnStylegrdEmployeesReportsTo,
                                                                                                                             this.objColumnStylegrdEmployeesPhotoPath});
         this.objTableStylegrdEmployeesEmployees.HeaderForeColor = System.Drawing.SystemColors.ControlText;
         this.objTableStylegrdEmployeesEmployees.MappingName = "Employees";
         // 
         // objColumnStylegrdEmployeesEmployeeID
         // 
         this.objColumnStylegrdEmployeesEmployeeID.Format = "";
         this.objColumnStylegrdEmployeesEmployeeID.FormatInfo = null;
         this.objColumnStylegrdEmployeesEmployeeID.HeaderText = "EmployeeID";
         this.objColumnStylegrdEmployeesEmployeeID.MappingName = "EmployeeID";
         this.objColumnStylegrdEmployeesEmployeeID.Width = 75;
         // 
         // objColumnStylegrdEmployeesLastName
         // 
         this.objColumnStylegrdEmployeesLastName.Format = "";
         this.objColumnStylegrdEmployeesLastName.FormatInfo = null;
         this.objColumnStylegrdEmployeesLastName.HeaderText = "LastName";
         this.objColumnStylegrdEmployeesLastName.MappingName = "LastName";
         this.objColumnStylegrdEmployeesLastName.Width = 75;
         // 
         // objColumnStylegrdEmployeesFirstName
         // 
         this.objColumnStylegrdEmployeesFirstName.Format = "";
         this.objColumnStylegrdEmployeesFirstName.FormatInfo = null;
         this.objColumnStylegrdEmployeesFirstName.HeaderText = "FirstName";
         this.objColumnStylegrdEmployeesFirstName.MappingName = "FirstName";
         this.objColumnStylegrdEmployeesFirstName.Width = 75;
         // 
         // objColumnStylegrdEmployeesTitle
         // 
         this.objColumnStylegrdEmployeesTitle.Format = "";
         this.objColumnStylegrdEmployeesTitle.FormatInfo = null;
         this.objColumnStylegrdEmployeesTitle.HeaderText = "Title";
         this.objColumnStylegrdEmployeesTitle.MappingName = "Title";
         this.objColumnStylegrdEmployeesTitle.Width = 75;
         // 
         // objColumnStylegrdEmployeesTitleOfCourtesy
         // 
         this.objColumnStylegrdEmployeesTitleOfCourtesy.Format = "";
         this.objColumnStylegrdEmployeesTitleOfCourtesy.FormatInfo = null;
         this.objColumnStylegrdEmployeesTitleOfCourtesy.HeaderText = "TitleOfCourtesy";
         this.objColumnStylegrdEmployeesTitleOfCourtesy.MappingName = "TitleOfCourtesy";
         this.objColumnStylegrdEmployeesTitleOfCourtesy.Width = 75;
         // 
         // objColumnStylegrdEmployeesBirthDate
         // 
         this.objColumnStylegrdEmployeesBirthDate.Format = "";
         this.objColumnStylegrdEmployeesBirthDate.FormatInfo = null;
         this.objColumnStylegrdEmployeesBirthDate.HeaderText = "BirthDate";
         this.objColumnStylegrdEmployeesBirthDate.MappingName = "BirthDate";
         this.objColumnStylegrdEmployeesBirthDate.Width = 75;
         // 
         // objColumnStylegrdEmployeesHireDate
         // 
         this.objColumnStylegrdEmployeesHireDate.Format = "";
         this.objColumnStylegrdEmployeesHireDate.FormatInfo = null;
         this.objColumnStylegrdEmployeesHireDate.HeaderText = "HireDate";
         this.objColumnStylegrdEmployeesHireDate.MappingName = "HireDate";
         this.objColumnStylegrdEmployeesHireDate.Width = 75;
         // 
         // objColumnStylegrdEmployeesAddress
         // 
         this.objColumnStylegrdEmployeesAddress.Format = "";
         this.objColumnStylegrdEmployeesAddress.FormatInfo = null;
         this.objColumnStylegrdEmployeesAddress.HeaderText = "Address";
         this.objColumnStylegrdEmployeesAddress.MappingName = "Address";
         this.objColumnStylegrdEmployeesAddress.Width = 75;
         // 
         // objColumnStylegrdEmployeesCity
         // 
         this.objColumnStylegrdEmployeesCity.Format = "";
         this.objColumnStylegrdEmployeesCity.FormatInfo = null;
         this.objColumnStylegrdEmployeesCity.HeaderText = "City";
         this.objColumnStylegrdEmployeesCity.MappingName = "City";
         this.objColumnStylegrdEmployeesCity.Width = 75;
         // 
         // objColumnStylegrdEmployeesRegion
         // 
         this.objColumnStylegrdEmployeesRegion.Format = "";
         this.objColumnStylegrdEmployeesRegion.FormatInfo = null;
         this.objColumnStylegrdEmployeesRegion.HeaderText = "Region";
         this.objColumnStylegrdEmployeesRegion.MappingName = "Region";
         this.objColumnStylegrdEmployeesRegion.Width = 75;
         // 
         // objColumnStylegrdEmployeesPostalCode
         // 
         this.objColumnStylegrdEmployeesPostalCode.Format = "";
         this.objColumnStylegrdEmployeesPostalCode.FormatInfo = null;
         this.objColumnStylegrdEmployeesPostalCode.HeaderText = "PostalCode";
         this.objColumnStylegrdEmployeesPostalCode.MappingName = "PostalCode";
         this.objColumnStylegrdEmployeesPostalCode.Width = 75;
         // 
         // objColumnStylegrdEmployeesCountry
         // 
         this.objColumnStylegrdEmployeesCountry.Format = "";
         this.objColumnStylegrdEmployeesCountry.FormatInfo = null;
         this.objColumnStylegrdEmployeesCountry.HeaderText = "Country";
         this.objColumnStylegrdEmployeesCountry.MappingName = "Country";
         this.objColumnStylegrdEmployeesCountry.Width = 75;
         // 
         // objColumnStylegrdEmployeesHomePhone
         // 
         this.objColumnStylegrdEmployeesHomePhone.Format = "";
         this.objColumnStylegrdEmployeesHomePhone.FormatInfo = null;
         this.objColumnStylegrdEmployeesHomePhone.HeaderText = "HomePhone";
         this.objColumnStylegrdEmployeesHomePhone.MappingName = "HomePhone";
         this.objColumnStylegrdEmployeesHomePhone.Width = 75;
         // 
         // objColumnStylegrdEmployeesExtension
         // 
         this.objColumnStylegrdEmployeesExtension.Format = "";
         this.objColumnStylegrdEmployeesExtension.FormatInfo = null;
         this.objColumnStylegrdEmployeesExtension.HeaderText = "Extension";
         this.objColumnStylegrdEmployeesExtension.MappingName = "Extension";
         this.objColumnStylegrdEmployeesExtension.Width = 75;
         // 
         // objColumnStylegrdEmployeesNotes
         // 
         this.objColumnStylegrdEmployeesNotes.Format = "";
         this.objColumnStylegrdEmployeesNotes.FormatInfo = null;
         this.objColumnStylegrdEmployeesNotes.HeaderText = "Notes";
         this.objColumnStylegrdEmployeesNotes.MappingName = "Notes";
         this.objColumnStylegrdEmployeesNotes.Width = 75;
         // 
         // objColumnStylegrdEmployeesReportsTo
         // 
         this.objColumnStylegrdEmployeesReportsTo.Format = "";
         this.objColumnStylegrdEmployeesReportsTo.FormatInfo = null;
         this.objColumnStylegrdEmployeesReportsTo.HeaderText = "ReportsTo";
         this.objColumnStylegrdEmployeesReportsTo.MappingName = "ReportsTo";
         this.objColumnStylegrdEmployeesReportsTo.Width = 75;
         // 
         // objColumnStylegrdEmployeesPhotoPath
         // 
         this.objColumnStylegrdEmployeesPhotoPath.Format = "";
         this.objColumnStylegrdEmployeesPhotoPath.FormatInfo = null;
         this.objColumnStylegrdEmployeesPhotoPath.HeaderText = "PhotoPath";
         this.objColumnStylegrdEmployeesPhotoPath.MappingName = "PhotoPath";
         this.objColumnStylegrdEmployeesPhotoPath.Width = 75;
         // 
         // DataForm1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(392, 222);
         this.Controls.Add(this.btnLoad);
         this.Controls.Add(this.btnUpdate);
         this.Controls.Add(this.btnCancelAll);
         this.Controls.Add(this.grdEmployees);
         this.Name = "DataForm1";
         this.Text = "DataForm1";
         ((System.ComponentModel.ISupportInitialize)(this.objDataSet1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
         this.ResumeLayout(false);

      }
		#endregion

      public void FillDataSet(DataFormWizard.DataSet1 dataSet)
      {
         // Turn off constraint checking before the dataset is filled.
         // This allows the adapters to fill the dataset without concern
         // for dependencies between the tables.
         dataSet.EnforceConstraints = false;
         try 
         {
            // Open the connection.
            this.oleDbConnection1.Open();
            // Attempt to fill the dataset through the OleDbDataAdapter1.
            this.oleDbDataAdapter1.Fill(dataSet);
         }
         catch (System.Exception fillException) 
         {
            // Add your error handling code here.
            throw fillException;
         }
         finally 
         {
            // Turn constraint checking back on.
            dataSet.EnforceConstraints = true;
            // Close the connection whether or not the exception was thrown.
            this.oleDbConnection1.Close();
         }

      }

      public void UpdateDataSource(DataFormWizard.DataSet1 ChangedRows)
      {
         try 
         {
            // The data source only needs to be updated if there are changes pending.
            if ((ChangedRows != null)) 
            {
               // Open the connection.
               this.oleDbConnection1.Open();
               // Attempt to update the data source.
               oleDbDataAdapter1.Update(ChangedRows);
            }
         }
         catch (System.Exception updateException) 
         {
            // Add your error handling code here.
            throw updateException;
         }
         finally 
         {
            // Close the connection whether or not the exception was thrown.
            this.oleDbConnection1.Close();
         }

      }

      public void LoadDataSet()
      {
         // Create a new dataset to hold the records returned from the call to FillDataSet.
         // A temporary dataset is used because filling the existing dataset would
         // require the databindings to be rebound.
         DataFormWizard.DataSet1 objDataSetTemp;
         objDataSetTemp = new DataFormWizard.DataSet1();
         try 
         {
            // Attempt to fill the temporary dataset.
            this.FillDataSet(objDataSetTemp);
         }
         catch (System.Exception eFillDataSet) 
         {
            // Add your error handling code here.
            throw eFillDataSet;
         }
         try 
         {
            grdEmployees.DataSource = null;
            // Empty the old records from the dataset.
            objDataSet1.Clear();
            // Merge the records into the main dataset.
            objDataSet1.Merge(objDataSetTemp);
            grdEmployees.SetDataBinding(objDataSet1, "Employees");
         }
         catch (System.Exception eLoadMerge) 
         {
            // Add your error handling code here.
            throw eLoadMerge;
         }

      }

      public void UpdateDataSet()
      {
         // Create a new dataset to hold the changes that have been made to the main dataset.
         DataFormWizard.DataSet1 objDataSetChanges = new DataFormWizard.DataSet1();
         // Stop any current edits.
         this.BindingContext[objDataSet1,"Employees"].EndCurrentEdit();
         // Get the changes that have been made to the main dataset.
         objDataSetChanges = ((DataFormWizard.DataSet1)(objDataSet1.GetChanges()));
         // Check to see if any changes have been made.
         if ((objDataSetChanges != null)) 
         {
            try 
            {
               // There are changes that need to be made, so attempt to update the datasource by
               // calling the update method and passing the dataset and any parameters.
               this.UpdateDataSource(objDataSetChanges);
               objDataSet1.Merge(objDataSetChanges);
               objDataSet1.AcceptChanges();
            }
            catch (System.Exception eUpdate) 
            {
               // Add your error handling code here.
               throw eUpdate;
            }
            // Add your code to check the returned dataset for any errors that may have been
            // pushed into the row object's error.
         }

      }

      private void btnCancelAll_Click(object sender, System.EventArgs e)
      {
         this.objDataSet1.RejectChanges();

      }

      private void btnLoad_Click(object sender, System.EventArgs e)
      {
         try 
         {
            // Attempt to load the dataset.
            this.LoadDataSet();
         }
         catch (System.Exception eLoad) 
         {
            // Add your error handling code here.
            // Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message);
         }

      }

      private void btnUpdate_Click(object sender, System.EventArgs e)
      {
         try 
         {
            // Attempt to update the datasource.
            this.UpdateDataSet();
         }
         catch (System.Exception eUpdate) 
         {
            // Add your error handling code here.
            // Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message);
         }

      }
	}
}
