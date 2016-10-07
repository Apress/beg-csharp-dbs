using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Employees
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Data.SqlClient.SqlConnection sqlConnectionNorthwind;
      private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
      private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
      private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
      private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
      private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterEmployees;
      private Employees.DataSetEmployees dataSetEmployees1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox textBoxNotes;
      private System.Windows.Forms.TextBox textBoxFirstName;
      private System.Windows.Forms.TextBox textBoxLastName;
      private System.Windows.Forms.TextBox textBoxBirthDate;
      private System.Windows.Forms.TextBox textBoxHomePhone;
      private System.Windows.Forms.ListBox listBoxNames;
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

         sqlDataAdapterEmployees.Fill(dataSetEmployees1);		}

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
         this.sqlConnectionNorthwind = new System.Data.SqlClient.SqlConnection();
         this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
         this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
         this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
         this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
         this.sqlDataAdapterEmployees = new System.Data.SqlClient.SqlDataAdapter();
         this.dataSetEmployees1 = new Employees.DataSetEmployees();
         this.listBoxNames = new System.Windows.Forms.ListBox();
         this.textBoxNotes = new System.Windows.Forms.TextBox();
         this.textBoxFirstName = new System.Windows.Forms.TextBox();
         this.textBoxLastName = new System.Windows.Forms.TextBox();
         this.textBoxBirthDate = new System.Windows.Forms.TextBox();
         this.textBoxHomePhone = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetEmployees1)).BeginInit();
         this.SuspendLayout();
         // 
         // sqlConnectionNorthwind
         // 
         this.sqlConnectionNorthwind.ConnectionString = "workstation id=DB54G821;packet size=4096;integrated security=SSPI;data source=\"(l" +
            "ocal)\\netsdk\";persist security info=False;initial catalog=northwind";
         // 
         // sqlSelectCommand1
         // 
         this.sqlSelectCommand1.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDa" +
            "te, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Not" +
            "es, ReportsTo, PhotoPath FROM Employees";
         this.sqlSelectCommand1.Connection = this.sqlConnectionNorthwind;
         // 
         // sqlInsertCommand1
         // 
         this.sqlInsertCommand1.CommandText = @"INSERT INTO Employees(LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath) VALUES (@LastName, @FirstName, @Title, @TitleOfCourtesy, @BirthDate, @HireDate, @Address, @City, @Region, @PostalCode, @Country, @HomePhone, @Extension, @Photo, @Notes, @ReportsTo, @PhotoPath); SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath FROM Employees WHERE (EmployeeID = @@IDENTITY)";
         this.sqlInsertCommand1.Connection = this.sqlConnectionNorthwind;
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 20, "LastName"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 10, "FirstName"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 30, "Title"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TitleOfCourtesy", System.Data.SqlDbType.NVarChar, 25, "TitleOfCourtesy"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@BirthDate", System.Data.SqlDbType.DateTime, 8, "BirthDate"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HireDate", System.Data.SqlDbType.DateTime, 8, "HireDate"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HomePhone", System.Data.SqlDbType.NVarChar, 24, "HomePhone"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Extension", System.Data.SqlDbType.NVarChar, 4, "Extension"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Photo", System.Data.SqlDbType.VarBinary, 2147483647, "Photo"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 1073741823, "Notes"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportsTo", System.Data.SqlDbType.Int, 4, "ReportsTo"));
         this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PhotoPath", System.Data.SqlDbType.NVarChar, 255, "PhotoPath"));
         // 
         // sqlUpdateCommand1
         // 
         this.sqlUpdateCommand1.CommandText = "UPDATE Employees SET LastName = @LastName, FirstName = @FirstName, Title = @Title" +
            ", TitleOfCourtesy = @TitleOfCourtesy, BirthDate = @BirthDate, HireDate = @HireDa" +
            "te, Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode" +
            ", Country = @Country, HomePhone = @HomePhone, Extension = @Extension, Photo = @P" +
            "hoto, Notes = @Notes, ReportsTo = @ReportsTo, PhotoPath = @PhotoPath WHERE (Empl" +
            "oyeeID = @Original_EmployeeID) AND (Address = @Original_Address OR @Original_Add" +
            "ress IS NULL AND Address IS NULL) AND (BirthDate = @Original_BirthDate OR @Origi" +
            "nal_BirthDate IS NULL AND BirthDate IS NULL) AND (City = @Original_City OR @Orig" +
            "inal_City IS NULL AND City IS NULL) AND (Country = @Original_Country OR @Origina" +
            "l_Country IS NULL AND Country IS NULL) AND (Extension = @Original_Extension OR @" +
            "Original_Extension IS NULL AND Extension IS NULL) AND (FirstName = @Original_Fir" +
            "stName) AND (HireDate = @Original_HireDate OR @Original_HireDate IS NULL AND Hir" +
            "eDate IS NULL) AND (HomePhone = @Original_HomePhone OR @Original_HomePhone IS NU" +
            "LL AND HomePhone IS NULL) AND (LastName = @Original_LastName) AND (PhotoPath = @" +
            "Original_PhotoPath OR @Original_PhotoPath IS NULL AND PhotoPath IS NULL) AND (Po" +
            "stalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode I" +
            "S NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS" +
            " NULL) AND (ReportsTo = @Original_ReportsTo OR @Original_ReportsTo IS NULL AND R" +
            "eportsTo IS NULL) AND (Title = @Original_Title OR @Original_Title IS NULL AND Ti" +
            "tle IS NULL) AND (TitleOfCourtesy = @Original_TitleOfCourtesy OR @Original_Title" +
            "OfCourtesy IS NULL AND TitleOfCourtesy IS NULL); SELECT EmployeeID, LastName, Fi" +
            "rstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, Pos" +
            "talCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath FROM " +
            "Employees WHERE (EmployeeID = @EmployeeID)";
         this.sqlUpdateCommand1.Connection = this.sqlConnectionNorthwind;
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 20, "LastName"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 10, "FirstName"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 30, "Title"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TitleOfCourtesy", System.Data.SqlDbType.NVarChar, 25, "TitleOfCourtesy"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@BirthDate", System.Data.SqlDbType.DateTime, 8, "BirthDate"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HireDate", System.Data.SqlDbType.DateTime, 8, "HireDate"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HomePhone", System.Data.SqlDbType.NVarChar, 24, "HomePhone"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Extension", System.Data.SqlDbType.NVarChar, 4, "Extension"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Photo", System.Data.SqlDbType.VarBinary, 2147483647, "Photo"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 1073741823, "Notes"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportsTo", System.Data.SqlDbType.Int, 4, "ReportsTo"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PhotoPath", System.Data.SqlDbType.NVarChar, 255, "PhotoPath"));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_BirthDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Extension", System.Data.SqlDbType.NVarChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HireDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HomePhone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PhotoPath", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PhotoPath", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ReportsTo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TitleOfCourtesy", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
         this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"));
         // 
         // sqlDeleteCommand1
         // 
         this.sqlDeleteCommand1.CommandText = @"DELETE FROM Employees WHERE (EmployeeID = @Original_EmployeeID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (BirthDate = @Original_BirthDate OR @Original_BirthDate IS NULL AND BirthDate IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Extension = @Original_Extension OR @Original_Extension IS NULL AND Extension IS NULL) AND (FirstName = @Original_FirstName) AND (HireDate = @Original_HireDate OR @Original_HireDate IS NULL AND HireDate IS NULL) AND (HomePhone = @Original_HomePhone OR @Original_HomePhone IS NULL AND HomePhone IS NULL) AND (LastName = @Original_LastName) AND (PhotoPath = @Original_PhotoPath OR @Original_PhotoPath IS NULL AND PhotoPath IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL) AND (ReportsTo = @Original_ReportsTo OR @Original_ReportsTo IS NULL AND ReportsTo IS NULL) AND (Title = @Original_Title OR @Original_Title IS NULL AND Title IS NULL) AND (TitleOfCourtesy = @Original_TitleOfCourtesy OR @Original_TitleOfCourtesy IS NULL AND TitleOfCourtesy IS NULL)";
         this.sqlDeleteCommand1.Connection = this.sqlConnectionNorthwind;
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_BirthDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BirthDate", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Extension", System.Data.SqlDbType.NVarChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Extension", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HireDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_HomePhone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "HomePhone", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PhotoPath", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PhotoPath", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ReportsTo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReportsTo", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Title", System.Data.DataRowVersion.Original, null));
         this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TitleOfCourtesy", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, null));
         // 
         // sqlDataAdapterEmployees
         // 
         this.sqlDataAdapterEmployees.DeleteCommand = this.sqlDeleteCommand1;
         this.sqlDataAdapterEmployees.InsertCommand = this.sqlInsertCommand1;
         this.sqlDataAdapterEmployees.SelectCommand = this.sqlSelectCommand1;
         this.sqlDataAdapterEmployees.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
         this.sqlDataAdapterEmployees.UpdateCommand = this.sqlUpdateCommand1;
         // 
         // dataSetEmployees1
         // 
         this.dataSetEmployees1.DataSetName = "DataSetEmployees";
         this.dataSetEmployees1.Locale = new System.Globalization.CultureInfo("en-US");
         // 
         // listBoxNames
         // 
         this.listBoxNames.DataSource = this.dataSetEmployees1.Employees;
         this.listBoxNames.DisplayMember = "LastName";
         this.listBoxNames.Location = new System.Drawing.Point(8, 16);
         this.listBoxNames.Name = "listBoxNames";
         this.listBoxNames.Size = new System.Drawing.Size(120, 134);
         this.listBoxNames.TabIndex = 0;
         this.listBoxNames.ValueMember = "EmployeeID";
         this.listBoxNames.SelectedValueChanged += new System.EventHandler(this.listBoxNames_SelectedValueChanged);
         this.listBoxNames.SelectedIndexChanged += new System.EventHandler(this.listBoxNames_SelectedIndexChanged);
         // 
         // textBoxNotes
         // 
         this.textBoxNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetEmployees1, "Employees.Notes"));
         this.textBoxNotes.Location = new System.Drawing.Point(8, 208);
         this.textBoxNotes.Multiline = true;
         this.textBoxNotes.Name = "textBoxNotes";
         this.textBoxNotes.Size = new System.Drawing.Size(536, 56);
         this.textBoxNotes.TabIndex = 1;
         this.textBoxNotes.Text = "";
         this.textBoxNotes.Validated += new System.EventHandler(this.TextBox_Validated);
         // 
         // textBoxFirstName
         // 
         this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetEmployees1, "Employees.FirstName"));
         this.textBoxFirstName.Location = new System.Drawing.Point(280, 32);
         this.textBoxFirstName.Name = "textBoxFirstName";
         this.textBoxFirstName.Size = new System.Drawing.Size(264, 20);
         this.textBoxFirstName.TabIndex = 2;
         this.textBoxFirstName.Text = "";
         this.textBoxFirstName.Validated += new System.EventHandler(this.TextBox_Validated);
         // 
         // textBoxLastName
         // 
         this.textBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetEmployees1, "Employees.LastName"));
         this.textBoxLastName.Location = new System.Drawing.Point(280, 72);
         this.textBoxLastName.Name = "textBoxLastName";
         this.textBoxLastName.Size = new System.Drawing.Size(264, 20);
         this.textBoxLastName.TabIndex = 3;
         this.textBoxLastName.Text = "";
         this.textBoxLastName.Validated += new System.EventHandler(this.TextBox_Validated);
         // 
         // textBoxBirthDate
         // 
         this.textBoxBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetEmployees1, "Employees.BirthDate"));
         this.textBoxBirthDate.Location = new System.Drawing.Point(280, 112);
         this.textBoxBirthDate.Name = "textBoxBirthDate";
         this.textBoxBirthDate.Size = new System.Drawing.Size(264, 20);
         this.textBoxBirthDate.TabIndex = 4;
         this.textBoxBirthDate.Text = "";
         this.textBoxBirthDate.Validated += new System.EventHandler(this.TextBox_Validated);
         // 
         // textBoxHomePhone
         // 
         this.textBoxHomePhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetEmployees1, "Employees.HomePhone"));
         this.textBoxHomePhone.Location = new System.Drawing.Point(280, 152);
         this.textBoxHomePhone.Name = "textBoxHomePhone";
         this.textBoxHomePhone.Size = new System.Drawing.Size(264, 20);
         this.textBoxHomePhone.TabIndex = 5;
         this.textBoxHomePhone.Text = "";
         this.textBoxHomePhone.Validated += new System.EventHandler(this.TextBox_Validated);
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(8, 184);
         this.label1.Name = "label1";
         this.label1.TabIndex = 6;
         this.label1.Text = "Notes";
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(176, 32);
         this.label2.Name = "label2";
         this.label2.TabIndex = 7;
         this.label2.Text = "First name:";
         // 
         // label3
         // 
         this.label3.Location = new System.Drawing.Point(176, 72);
         this.label3.Name = "label3";
         this.label3.TabIndex = 8;
         this.label3.Text = "Last name:";
         // 
         // label4
         // 
         this.label4.Location = new System.Drawing.Point(176, 112);
         this.label4.Name = "label4";
         this.label4.TabIndex = 9;
         this.label4.Text = "DOB:";
         // 
         // label5
         // 
         this.label5.Location = new System.Drawing.Point(176, 152);
         this.label5.Name = "label5";
         this.label5.TabIndex = 10;
         this.label5.Text = "Home phone:";
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(552, 272);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBoxHomePhone);
         this.Controls.Add(this.textBoxBirthDate);
         this.Controls.Add(this.textBoxLastName);
         this.Controls.Add(this.textBoxFirstName);
         this.Controls.Add(this.textBoxNotes);
         this.Controls.Add(this.listBoxNames);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.dataSetEmployees1)).EndInit();
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

      private void listBoxNames_SelectedValueChanged(object sender, System.EventArgs e)
      {
      
      }

      private void listBoxNames_SelectedIndexChanged(object sender, System.EventArgs e)
      {
         // Clear the data bindings on the TextBoxes
         textBoxBirthDate.DataBindings.Clear();
         textBoxFirstName.DataBindings.Clear();
         textBoxHomePhone.DataBindings.Clear();
         textBoxLastName.DataBindings.Clear();
         textBoxNotes.DataBindings.Clear();

         // Add a new binding, with a new data source: the selected row.
         textBoxBirthDate.DataBindings.Add(
            "Text", 
            dataSetEmployees1.Employees.Rows[listBoxNames.SelectedIndex], 
            "BirthDate");

         textBoxFirstName.DataBindings.Add(
            "Text", 
            dataSetEmployees1.Employees.Rows[listBoxNames.SelectedIndex], 
            "FirstName");

         textBoxHomePhone.DataBindings.Add(
            "Text", 
            dataSetEmployees1.Employees.Rows[listBoxNames.SelectedIndex], 
            "HomePhone");

         textBoxLastName.DataBindings.Add(
            "Text", 
            dataSetEmployees1.Employees.Rows[listBoxNames.SelectedIndex], 
            "LastName");

         textBoxNotes.DataBindings.Add(
            "Text", 
            dataSetEmployees1.Employees.Rows[listBoxNames.SelectedIndex], 
            "Notes");

      }

      private void TextBox_Validated(object sender, System.EventArgs e)
      {
         // Open the connection
         sqlConnectionNorthwind.Open();

         // Update
         sqlDataAdapterEmployees.Update(dataSetEmployees1, "Employees");
         // Refresh the data in the dataset
         sqlDataAdapterEmployees.Fill(dataSetEmployees1);

         // Close the connection again
         sqlConnectionNorthwind.Close();
      }
	}
}
