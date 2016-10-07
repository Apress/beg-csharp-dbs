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
      private System.Windows.Forms.Label lblEmployeeID;
      private System.Windows.Forms.Label lblLastName;
      private System.Windows.Forms.Label lblFirstName;
      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.Label lblTitleOfCourtesy;
      private System.Windows.Forms.Label lblBirthDate;
      private System.Windows.Forms.Label lblHireDate;
      private System.Windows.Forms.Label lblAddress;
      private System.Windows.Forms.Label lblCity;
      private System.Windows.Forms.TextBox editEmployeeID;
      private System.Windows.Forms.TextBox editLastName;
      private System.Windows.Forms.TextBox editFirstName;
      private System.Windows.Forms.TextBox editTitle;
      private System.Windows.Forms.TextBox editTitleOfCourtesy;
      private System.Windows.Forms.TextBox editBirthDate;
      private System.Windows.Forms.TextBox editHireDate;
      private System.Windows.Forms.TextBox editAddress;
      private System.Windows.Forms.TextBox editCity;
      private System.Windows.Forms.Label lblRegion;
      private System.Windows.Forms.Label lblPostalCode;
      private System.Windows.Forms.Label lblCountry;
      private System.Windows.Forms.Label lblHomePhone;
      private System.Windows.Forms.Label lblExtension;
      private System.Windows.Forms.Label lblNotes;
      private System.Windows.Forms.Label lblReportsTo;
      private System.Windows.Forms.Label lblPhotoPath;
      private System.Windows.Forms.TextBox editRegion;
      private System.Windows.Forms.TextBox editPostalCode;
      private System.Windows.Forms.TextBox editCountry;
      private System.Windows.Forms.TextBox editHomePhone;
      private System.Windows.Forms.TextBox editExtension;
      private System.Windows.Forms.TextBox editNotes;
      private System.Windows.Forms.TextBox editReportsTo;
      private System.Windows.Forms.TextBox editPhotoPath;
      private System.Windows.Forms.Button btnNavFirst;
      private System.Windows.Forms.Button btnNavPrev;
      private System.Windows.Forms.Label lblNavLocation;
      private System.Windows.Forms.Button btnNavNext;
      private System.Windows.Forms.Button btnLast;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnCancel;
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
         this.lblEmployeeID = new System.Windows.Forms.Label();
         this.lblLastName = new System.Windows.Forms.Label();
         this.lblFirstName = new System.Windows.Forms.Label();
         this.lblTitle = new System.Windows.Forms.Label();
         this.lblTitleOfCourtesy = new System.Windows.Forms.Label();
         this.lblBirthDate = new System.Windows.Forms.Label();
         this.lblHireDate = new System.Windows.Forms.Label();
         this.lblAddress = new System.Windows.Forms.Label();
         this.lblCity = new System.Windows.Forms.Label();
         this.editEmployeeID = new System.Windows.Forms.TextBox();
         this.editLastName = new System.Windows.Forms.TextBox();
         this.editFirstName = new System.Windows.Forms.TextBox();
         this.editTitle = new System.Windows.Forms.TextBox();
         this.editTitleOfCourtesy = new System.Windows.Forms.TextBox();
         this.editBirthDate = new System.Windows.Forms.TextBox();
         this.editHireDate = new System.Windows.Forms.TextBox();
         this.editAddress = new System.Windows.Forms.TextBox();
         this.editCity = new System.Windows.Forms.TextBox();
         this.lblRegion = new System.Windows.Forms.Label();
         this.lblPostalCode = new System.Windows.Forms.Label();
         this.lblCountry = new System.Windows.Forms.Label();
         this.lblHomePhone = new System.Windows.Forms.Label();
         this.lblExtension = new System.Windows.Forms.Label();
         this.lblNotes = new System.Windows.Forms.Label();
         this.lblReportsTo = new System.Windows.Forms.Label();
         this.lblPhotoPath = new System.Windows.Forms.Label();
         this.editRegion = new System.Windows.Forms.TextBox();
         this.editPostalCode = new System.Windows.Forms.TextBox();
         this.editCountry = new System.Windows.Forms.TextBox();
         this.editHomePhone = new System.Windows.Forms.TextBox();
         this.editExtension = new System.Windows.Forms.TextBox();
         this.editNotes = new System.Windows.Forms.TextBox();
         this.editReportsTo = new System.Windows.Forms.TextBox();
         this.editPhotoPath = new System.Windows.Forms.TextBox();
         this.btnNavFirst = new System.Windows.Forms.Button();
         this.btnNavPrev = new System.Windows.Forms.Button();
         this.lblNavLocation = new System.Windows.Forms.Label();
         this.btnNavNext = new System.Windows.Forms.Button();
         this.btnLast = new System.Windows.Forms.Button();
         this.btnAdd = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.objDataSet1)).BeginInit();
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
         this.btnUpdate.Location = new System.Drawing.Point(365, 10);
         this.btnUpdate.Name = "btnUpdate";
         this.btnUpdate.TabIndex = 1;
         this.btnUpdate.Text = "&Update";
         this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
         // 
         // btnCancelAll
         // 
         this.btnCancelAll.Location = new System.Drawing.Point(365, 43);
         this.btnCancelAll.Name = "btnCancelAll";
         this.btnCancelAll.TabIndex = 2;
         this.btnCancelAll.Text = "Ca&ncel All";
         this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
         // 
         // lblEmployeeID
         // 
         this.lblEmployeeID.Location = new System.Drawing.Point(10, 76);
         this.lblEmployeeID.Name = "lblEmployeeID";
         this.lblEmployeeID.TabIndex = 3;
         this.lblEmployeeID.Text = "EmployeeID";
         // 
         // lblLastName
         // 
         this.lblLastName.Location = new System.Drawing.Point(10, 109);
         this.lblLastName.Name = "lblLastName";
         this.lblLastName.TabIndex = 4;
         this.lblLastName.Text = "LastName";
         // 
         // lblFirstName
         // 
         this.lblFirstName.Location = new System.Drawing.Point(10, 142);
         this.lblFirstName.Name = "lblFirstName";
         this.lblFirstName.TabIndex = 5;
         this.lblFirstName.Text = "FirstName";
         // 
         // lblTitle
         // 
         this.lblTitle.Location = new System.Drawing.Point(10, 175);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.TabIndex = 6;
         this.lblTitle.Text = "Title";
         // 
         // lblTitleOfCourtesy
         // 
         this.lblTitleOfCourtesy.Location = new System.Drawing.Point(10, 208);
         this.lblTitleOfCourtesy.Name = "lblTitleOfCourtesy";
         this.lblTitleOfCourtesy.TabIndex = 7;
         this.lblTitleOfCourtesy.Text = "TitleOfCourtesy";
         // 
         // lblBirthDate
         // 
         this.lblBirthDate.Location = new System.Drawing.Point(10, 241);
         this.lblBirthDate.Name = "lblBirthDate";
         this.lblBirthDate.TabIndex = 8;
         this.lblBirthDate.Text = "BirthDate";
         // 
         // lblHireDate
         // 
         this.lblHireDate.Location = new System.Drawing.Point(10, 274);
         this.lblHireDate.Name = "lblHireDate";
         this.lblHireDate.TabIndex = 9;
         this.lblHireDate.Text = "HireDate";
         // 
         // lblAddress
         // 
         this.lblAddress.Location = new System.Drawing.Point(10, 307);
         this.lblAddress.Name = "lblAddress";
         this.lblAddress.TabIndex = 10;
         this.lblAddress.Text = "Address";
         // 
         // lblCity
         // 
         this.lblCity.Location = new System.Drawing.Point(10, 340);
         this.lblCity.Name = "lblCity";
         this.lblCity.TabIndex = 11;
         this.lblCity.Text = "City";
         // 
         // editEmployeeID
         // 
         this.editEmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.EmployeeID"));
         this.editEmployeeID.Location = new System.Drawing.Point(120, 76);
         this.editEmployeeID.Name = "editEmployeeID";
         this.editEmployeeID.TabIndex = 12;
         this.editEmployeeID.Text = "";
         // 
         // editLastName
         // 
         this.editLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.LastName"));
         this.editLastName.Location = new System.Drawing.Point(120, 109);
         this.editLastName.Name = "editLastName";
         this.editLastName.TabIndex = 13;
         this.editLastName.Text = "";
         // 
         // editFirstName
         // 
         this.editFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.FirstName"));
         this.editFirstName.Location = new System.Drawing.Point(120, 142);
         this.editFirstName.Name = "editFirstName";
         this.editFirstName.TabIndex = 14;
         this.editFirstName.Text = "";
         // 
         // editTitle
         // 
         this.editTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.Title"));
         this.editTitle.Location = new System.Drawing.Point(120, 175);
         this.editTitle.Name = "editTitle";
         this.editTitle.TabIndex = 15;
         this.editTitle.Text = "";
         // 
         // editTitleOfCourtesy
         // 
         this.editTitleOfCourtesy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.TitleOfCourtesy"));
         this.editTitleOfCourtesy.Location = new System.Drawing.Point(120, 208);
         this.editTitleOfCourtesy.Name = "editTitleOfCourtesy";
         this.editTitleOfCourtesy.TabIndex = 16;
         this.editTitleOfCourtesy.Text = "";
         // 
         // editBirthDate
         // 
         this.editBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.BirthDate"));
         this.editBirthDate.Location = new System.Drawing.Point(120, 241);
         this.editBirthDate.Name = "editBirthDate";
         this.editBirthDate.TabIndex = 17;
         this.editBirthDate.Text = "";
         // 
         // editHireDate
         // 
         this.editHireDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.HireDate"));
         this.editHireDate.Location = new System.Drawing.Point(120, 274);
         this.editHireDate.Name = "editHireDate";
         this.editHireDate.TabIndex = 18;
         this.editHireDate.Text = "";
         // 
         // editAddress
         // 
         this.editAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.Address"));
         this.editAddress.Location = new System.Drawing.Point(120, 307);
         this.editAddress.Name = "editAddress";
         this.editAddress.TabIndex = 19;
         this.editAddress.Text = "";
         // 
         // editCity
         // 
         this.editCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.City"));
         this.editCity.Location = new System.Drawing.Point(120, 340);
         this.editCity.Name = "editCity";
         this.editCity.TabIndex = 20;
         this.editCity.Text = "";
         // 
         // lblRegion
         // 
         this.lblRegion.Location = new System.Drawing.Point(230, 76);
         this.lblRegion.Name = "lblRegion";
         this.lblRegion.TabIndex = 21;
         this.lblRegion.Text = "Region";
         // 
         // lblPostalCode
         // 
         this.lblPostalCode.Location = new System.Drawing.Point(230, 109);
         this.lblPostalCode.Name = "lblPostalCode";
         this.lblPostalCode.TabIndex = 22;
         this.lblPostalCode.Text = "PostalCode";
         // 
         // lblCountry
         // 
         this.lblCountry.Location = new System.Drawing.Point(230, 142);
         this.lblCountry.Name = "lblCountry";
         this.lblCountry.TabIndex = 23;
         this.lblCountry.Text = "Country";
         // 
         // lblHomePhone
         // 
         this.lblHomePhone.Location = new System.Drawing.Point(230, 175);
         this.lblHomePhone.Name = "lblHomePhone";
         this.lblHomePhone.TabIndex = 24;
         this.lblHomePhone.Text = "HomePhone";
         // 
         // lblExtension
         // 
         this.lblExtension.Location = new System.Drawing.Point(230, 208);
         this.lblExtension.Name = "lblExtension";
         this.lblExtension.TabIndex = 25;
         this.lblExtension.Text = "Extension";
         // 
         // lblNotes
         // 
         this.lblNotes.Location = new System.Drawing.Point(230, 241);
         this.lblNotes.Name = "lblNotes";
         this.lblNotes.TabIndex = 26;
         this.lblNotes.Text = "Notes";
         // 
         // lblReportsTo
         // 
         this.lblReportsTo.Location = new System.Drawing.Point(230, 274);
         this.lblReportsTo.Name = "lblReportsTo";
         this.lblReportsTo.TabIndex = 27;
         this.lblReportsTo.Text = "ReportsTo";
         // 
         // lblPhotoPath
         // 
         this.lblPhotoPath.Location = new System.Drawing.Point(230, 307);
         this.lblPhotoPath.Name = "lblPhotoPath";
         this.lblPhotoPath.TabIndex = 28;
         this.lblPhotoPath.Text = "PhotoPath";
         // 
         // editRegion
         // 
         this.editRegion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.Region"));
         this.editRegion.Location = new System.Drawing.Point(340, 76);
         this.editRegion.Name = "editRegion";
         this.editRegion.TabIndex = 29;
         this.editRegion.Text = "";
         // 
         // editPostalCode
         // 
         this.editPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.PostalCode"));
         this.editPostalCode.Location = new System.Drawing.Point(340, 109);
         this.editPostalCode.Name = "editPostalCode";
         this.editPostalCode.TabIndex = 30;
         this.editPostalCode.Text = "";
         // 
         // editCountry
         // 
         this.editCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.Country"));
         this.editCountry.Location = new System.Drawing.Point(340, 142);
         this.editCountry.Name = "editCountry";
         this.editCountry.TabIndex = 31;
         this.editCountry.Text = "";
         // 
         // editHomePhone
         // 
         this.editHomePhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.HomePhone"));
         this.editHomePhone.Location = new System.Drawing.Point(340, 175);
         this.editHomePhone.Name = "editHomePhone";
         this.editHomePhone.TabIndex = 32;
         this.editHomePhone.Text = "";
         // 
         // editExtension
         // 
         this.editExtension.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.Extension"));
         this.editExtension.Location = new System.Drawing.Point(340, 208);
         this.editExtension.Name = "editExtension";
         this.editExtension.TabIndex = 33;
         this.editExtension.Text = "";
         // 
         // editNotes
         // 
         this.editNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.Notes"));
         this.editNotes.Location = new System.Drawing.Point(340, 241);
         this.editNotes.Name = "editNotes";
         this.editNotes.TabIndex = 34;
         this.editNotes.Text = "";
         // 
         // editReportsTo
         // 
         this.editReportsTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.ReportsTo"));
         this.editReportsTo.Location = new System.Drawing.Point(340, 274);
         this.editReportsTo.Name = "editReportsTo";
         this.editReportsTo.TabIndex = 35;
         this.editReportsTo.Text = "";
         // 
         // editPhotoPath
         // 
         this.editPhotoPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objDataSet1, "Employees.PhotoPath"));
         this.editPhotoPath.Location = new System.Drawing.Point(340, 307);
         this.editPhotoPath.Name = "editPhotoPath";
         this.editPhotoPath.TabIndex = 36;
         this.editPhotoPath.Text = "";
         // 
         // btnNavFirst
         // 
         this.btnNavFirst.Location = new System.Drawing.Point(195, 373);
         this.btnNavFirst.Name = "btnNavFirst";
         this.btnNavFirst.Size = new System.Drawing.Size(40, 23);
         this.btnNavFirst.TabIndex = 37;
         this.btnNavFirst.Text = "<<";
         this.btnNavFirst.Click += new System.EventHandler(this.btnNavFirst_Click);
         // 
         // btnNavPrev
         // 
         this.btnNavPrev.Location = new System.Drawing.Point(235, 373);
         this.btnNavPrev.Name = "btnNavPrev";
         this.btnNavPrev.Size = new System.Drawing.Size(35, 23);
         this.btnNavPrev.TabIndex = 38;
         this.btnNavPrev.Text = "<";
         this.btnNavPrev.Click += new System.EventHandler(this.btnNavPrev_Click);
         // 
         // lblNavLocation
         // 
         this.lblNavLocation.BackColor = System.Drawing.Color.White;
         this.lblNavLocation.Location = new System.Drawing.Point(270, 373);
         this.lblNavLocation.Name = "lblNavLocation";
         this.lblNavLocation.Size = new System.Drawing.Size(95, 23);
         this.lblNavLocation.TabIndex = 39;
         this.lblNavLocation.Text = "No Records";
         this.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnNavNext
         // 
         this.btnNavNext.Location = new System.Drawing.Point(365, 373);
         this.btnNavNext.Name = "btnNavNext";
         this.btnNavNext.Size = new System.Drawing.Size(35, 23);
         this.btnNavNext.TabIndex = 40;
         this.btnNavNext.Text = ">";
         this.btnNavNext.Click += new System.EventHandler(this.btnNavNext_Click);
         // 
         // btnLast
         // 
         this.btnLast.Location = new System.Drawing.Point(400, 373);
         this.btnLast.Name = "btnLast";
         this.btnLast.Size = new System.Drawing.Size(40, 23);
         this.btnLast.TabIndex = 41;
         this.btnLast.Text = ">>";
         this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(195, 406);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.TabIndex = 42;
         this.btnAdd.Text = "&Add";
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(280, 406);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.TabIndex = 43;
         this.btnDelete.Text = "&Delete";
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(365, 406);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.TabIndex = 44;
         this.btnCancel.Text = "&Cancel";
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // DataForm1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(442, 453);
         this.Controls.Add(this.btnLoad);
         this.Controls.Add(this.btnUpdate);
         this.Controls.Add(this.btnCancelAll);
         this.Controls.Add(this.lblEmployeeID);
         this.Controls.Add(this.lblLastName);
         this.Controls.Add(this.lblFirstName);
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this.lblTitleOfCourtesy);
         this.Controls.Add(this.lblBirthDate);
         this.Controls.Add(this.lblHireDate);
         this.Controls.Add(this.lblAddress);
         this.Controls.Add(this.lblCity);
         this.Controls.Add(this.editEmployeeID);
         this.Controls.Add(this.editLastName);
         this.Controls.Add(this.editFirstName);
         this.Controls.Add(this.editTitle);
         this.Controls.Add(this.editTitleOfCourtesy);
         this.Controls.Add(this.editBirthDate);
         this.Controls.Add(this.editHireDate);
         this.Controls.Add(this.editAddress);
         this.Controls.Add(this.editCity);
         this.Controls.Add(this.lblRegion);
         this.Controls.Add(this.lblPostalCode);
         this.Controls.Add(this.lblCountry);
         this.Controls.Add(this.lblHomePhone);
         this.Controls.Add(this.lblExtension);
         this.Controls.Add(this.lblNotes);
         this.Controls.Add(this.lblReportsTo);
         this.Controls.Add(this.lblPhotoPath);
         this.Controls.Add(this.editRegion);
         this.Controls.Add(this.editPostalCode);
         this.Controls.Add(this.editCountry);
         this.Controls.Add(this.editHomePhone);
         this.Controls.Add(this.editExtension);
         this.Controls.Add(this.editNotes);
         this.Controls.Add(this.editReportsTo);
         this.Controls.Add(this.editPhotoPath);
         this.Controls.Add(this.btnNavFirst);
         this.Controls.Add(this.btnNavPrev);
         this.Controls.Add(this.lblNavLocation);
         this.Controls.Add(this.btnNavNext);
         this.Controls.Add(this.btnLast);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnCancel);
         this.Name = "DataForm1";
         this.Text = "DataForm1";
         ((System.ComponentModel.ISupportInitialize)(this.objDataSet1)).EndInit();
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
            // Empty the old records from the dataset.
            objDataSet1.Clear();
            // Merge the records into the main dataset.
            objDataSet1.Merge(objDataSetTemp);
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

      private void objDataSet1_PositionChanged()
      {
         this.lblNavLocation.Text = ((((this.BindingContext[objDataSet1,"Employees"].Position + 1)).ToString() + " of  ") 
            + this.BindingContext[objDataSet1,"Employees"].Count.ToString());

      }

      private void btnNavNext_Click(object sender, System.EventArgs e)
      {
         this.BindingContext[objDataSet1,"Employees"].Position = (this.BindingContext[objDataSet1,"Employees"].Position + 1);
         this.objDataSet1_PositionChanged();

      }

      private void btnNavPrev_Click(object sender, System.EventArgs e)
      {
         this.BindingContext[objDataSet1,"Employees"].Position = (this.BindingContext[objDataSet1,"Employees"].Position - 1);
         this.objDataSet1_PositionChanged();

      }

      private void btnLast_Click(object sender, System.EventArgs e)
      {
         this.BindingContext[objDataSet1,"Employees"].Position = (this.objDataSet1.Tables["Employees"].Rows.Count - 1);
         this.objDataSet1_PositionChanged();

      }

      private void btnNavFirst_Click(object sender, System.EventArgs e)
      {
         this.BindingContext[objDataSet1,"Employees"].Position = 0;
         this.objDataSet1_PositionChanged();

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
         this.objDataSet1_PositionChanged();

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
         this.objDataSet1_PositionChanged();

      }

      private void btnAdd_Click(object sender, System.EventArgs e)
      {
         try 
         {
            // Clear out the current edits
            this.BindingContext[objDataSet1,"Employees"].EndCurrentEdit();
            this.BindingContext[objDataSet1,"Employees"].AddNew();
         }
         catch (System.Exception eEndEdit) 
         {
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message);
         }
         this.objDataSet1_PositionChanged();

      }

      private void btnDelete_Click(object sender, System.EventArgs e)
      {
         if ((this.BindingContext[objDataSet1,"Employees"].Count > 0)) 
         {
            this.BindingContext[objDataSet1,"Employees"].RemoveAt(this.BindingContext[objDataSet1,"Employees"].Position);
            this.objDataSet1_PositionChanged();
         }

      }

      private void btnCancel_Click(object sender, System.EventArgs e)
      {
         this.BindingContext[objDataSet1,"Employees"].CancelCurrentEdit();
         this.objDataSet1_PositionChanged();

      }
	}
}
