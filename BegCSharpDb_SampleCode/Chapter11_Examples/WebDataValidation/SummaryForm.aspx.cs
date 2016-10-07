using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using System.Data.SqlClient;

namespace WebDataValidation
{
   /// <summary>
   /// Summary description for WebForm7.
   /// </summary>
   public class WebForm7 : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.TextBox FirstNameTextBox;
      protected System.Web.UI.WebControls.TextBox LastNameTextBox;
      protected System.Web.UI.WebControls.TextBox HireDateTextBox;
      protected System.Web.UI.WebControls.TextBox BirthDateTextBox;
      protected System.Web.UI.WebControls.DropDownList ReportsToDropDownList;
      protected System.Web.UI.WebControls.ValidationSummary EmployeeValidationSummary;
      protected System.Web.UI.WebControls.RequiredFieldValidator FirstNameRequiredFieldValidator;
      protected System.Web.UI.WebControls.RequiredFieldValidator LastNameRequiredFieldValidator;
      protected System.Web.UI.WebControls.RequiredFieldValidator HireDateRequiredFieldValidator;
      protected System.Web.UI.WebControls.RangeValidator HireDateRangeValidator;
      protected System.Web.UI.WebControls.RangeValidator BirthDateRangeValidator;
      protected System.Web.UI.WebControls.RegularExpressionValidator PhotoUrlRegularExpressionValidator;
      protected System.Web.UI.WebControls.Button SubmitButton;
      protected System.Data.SqlClient.SqlConnection sqlConnection1;
      protected System.Web.UI.WebControls.Button ClearButton;
      protected System.Web.UI.WebControls.TextBox PhotoURLTextBox;
	
      private void Page_Load(object sender, System.EventArgs e)
      {
         // Put user code to initialize the page here
         if(!Page.IsPostBack)
         {
            BindReportToDropDown();

            DateTime nextWeek = DateTime.Today + TimeSpan.FromDays(7);
            HireDateRangeValidator.MaximumValue = nextWeek.ToShortDateString();

            DateTime lastWeek = DateTime.Today - TimeSpan.FromDays(7);
            HireDateRangeValidator.MinimumValue = lastWeek.ToShortDateString();

            BirthDateRangeValidator.MaximumValue = DateTime.Today.ToShortDateString();
				
            DateTime hundredYears = DateTime.Today - TimeSpan.FromDays(365 * 100);
            BirthDateRangeValidator.MinimumValue = hundredYears.ToShortDateString();
         }
      }

      #region Web Form Designer generated code
      override protected void OnInit(EventArgs e)
      {
         //
         // CODEGEN: This call is required by the ASP.NET Web Form Designer.
         //
         InitializeComponent();
         base.OnInit(e);
      }
		
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {    
         this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
         this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
         this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
         // 
         // sqlConnection1
         // 
         this.sqlConnection1.ConnectionString = "data source=(local)\\NETSdk;initial catalog=Northwind;integrated security=SSPI;per" +
            "sist security info=False;workstation id=LAPTOP;packet size=4096";
         this.Load += new System.EventHandler(this.Page_Load);

      }
      #endregion

      private void BindReportToDropDown()
      {
         SqlCommand sqlCommand = new SqlCommand();
         sqlCommand.CommandText = 
            "SELECT EmployeeId, " +
            "Firstname + ' ' + Lastname As Name " +
            "FROM Employees";

         sqlConnection1.Open();
         sqlCommand.Connection = sqlConnection1;
         SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

         ReportsToDropDownList.DataSource = sqlDataReader;
         ReportsToDropDownList.DataTextField = "Name";
         ReportsToDropDownList.DataValueField = "EmployeeId";
         ReportsToDropDownList.DataBind();
            
         sqlDataReader.Close();
         sqlConnection1.Close();
      }

      private void SubmitButton_Click(object sender, System.EventArgs e)
      {
         if(Page.IsValid)
         {
            SqlCommand sqlCommand  = new SqlCommand();
            sqlCommand.CommandText = 
               "INSERT INTO Employees( " +
               "FirstName, LastName, HireDate, BirthDate, ReportsTo, PhotoPath) " +
               "VALUES(@FirstName, @LastName, @HireDate, @BirthDate, @ReportsTo, @PhotoURL)";

            sqlCommand.Parameters.Add("@FirstName", FirstNameTextBox.Text);
            sqlCommand.Parameters.Add("@LastName", LastNameTextBox.Text);
            sqlCommand.Parameters.Add("@HireDate", HireDateTextBox.Text);
            sqlCommand.Parameters.Add("@BirthDate", BirthDateTextBox.Text);
            sqlCommand.Parameters.Add("@ReportsTo", ReportsToDropDownList.SelectedItem.Value);
            sqlCommand.Parameters.Add("@PhotoURL", PhotoURLTextBox.Text);

            sqlConnection1.Open();
            sqlCommand.Connection = sqlConnection1;
            sqlCommand.ExecuteNonQuery();
            sqlConnection1.Close();

            ClearFields();
         }
      }

      private void ClearButton_Click(object sender, System.EventArgs e)
      {
         ClearFields();	
      }

      private void ClearFields()
      {
         FirstNameTextBox.Text = "";
         LastNameTextBox.Text = "";
         HireDateTextBox.Text = "";
         BirthDateTextBox.Text = "";
         PhotoURLTextBox.Text = "";
         ReportsToDropDownList.SelectedIndex = 0;	
      }
   }
}
