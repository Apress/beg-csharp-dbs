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

namespace WebDataGrid
{
   /// <summary>
   /// Summary description for WebForm1.
   /// </summary>
   public class WebForm1 : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.DataGrid DataGrid1;
      protected System.Web.UI.WebControls.Label Label1;
      protected System.Web.UI.WebControls.Panel Panel1;
      protected System.Web.UI.WebControls.Label Label2;
      protected System.Data.SqlClient.SqlConnection sqlConnection1;
   
      private void Page_Load(object sender, System.EventArgs e)
      {
         if (!Page.IsPostBack)
         {
            BindDataGrid(true);
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
         this.DataGrid1.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.DataGrid1_PageIndexChanged);
         this.DataGrid1.CancelCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_CancelCommand);
         this.DataGrid1.EditCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_EditCommand);
         this.DataGrid1.SortCommand += new System.Web.UI.WebControls.DataGridSortCommandEventHandler(this.DataGrid1_SortCommand);
         this.DataGrid1.UpdateCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_UpdateCommand);
         this.DataGrid1.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGrid1_DeleteCommand);
         this.DataGrid1.SelectedIndexChanged += new System.EventHandler(this.DataGrid1_SelectedIndexChanged);
         // 
         // sqlConnection1
         // 
         this.sqlConnection1.ConnectionString = "workstation id=DB54G821;packet size=4096;integrated security=false;data source=\"(" +
            "local)\\netsdk\";persist security info=False;initial catalog=Northwind;uid=\"sa\";pw" +
            "d=\"sa\"";
         this.Load += new System.EventHandler(this.Page_Load);

      }
      #endregion
      private void BindDataGrid()
      {
         BindDataGrid(false, null);
      }

      private void BindDataGrid(bool refresh)
      {
         BindDataGrid(refresh, null);
      }

      private void BindDataGrid(string sortExpression)
      {
         BindDataGrid(false, sortExpression);
      }
    
      private void BindDataGrid(bool refresh, string sortExpression)
      {
         DataSet dataSet = null;
         if(refresh == true || Session["Employees"] == null)
         {
            string sql = @"
             select
                employeeid,
                firstname,
                lastname,
                title,
                extension,
                hiredate
             from
                employees
          ";

            sqlConnection1.Open();
            SqlDataAdapter sqlDataAdapter = 
               new SqlDataAdapter(sql, sqlConnection1);
            dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "employees");

            Session["employees"] = dataSet;
            sqlConnection1.Close();
         }
         else
         {
            dataSet = (DataSet)Session["employees"];
         }

         DataView dataView = dataSet.Tables["employees"].DefaultView;
         if (sortExpression != null)
         {
            dataView.Sort = sortExpression;
         }
         DataGrid1.DataSource = dataView;
         DataGrid1.DataKeyField = "employeeid";
         DataGrid1.DataBind();
      }




      private void DataGrid1_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
      {
         DataGrid1.CurrentPageIndex = e.NewPageIndex;
         DataGrid1.SelectedIndex = -1;
         DataGrid1.EditItemIndex = -1;
         Panel1.Visible = false;
         BindDataGrid();
      }

      private void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
      {
         string key = DataGrid1.DataKeys[DataGrid1.SelectedIndex].ToString();
         string sql = @"
         select
            Notes
         from
           Employees
         where
            EmployeeID = @EmployeeID
      ";
         sqlConnection1.Open();
         SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection1);
         sqlCommand.Parameters.Add("@EmployeeID", key);
         SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

         if(sqlDataReader.Read())
         {
            Label1.Text = sqlDataReader["Notes"].ToString();
            Panel1.Visible = true;
         }
         sqlDataReader.Close();
         sqlConnection1.Close();

      }

      private void DataGrid1_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
      {
         DataGrid1.EditItemIndex = e.Item.ItemIndex;
         BindDataGrid();
      }

      private void DataGrid1_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
      {
         DataGrid1.EditItemIndex = -1;
         BindDataGrid();
      }

      private void DataGrid1_UpdateCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
      {
         string key = DataGrid1.DataKeys[DataGrid1.EditItemIndex].ToString();
         string sql =  @"
       update employees
       set
          firstname = @firstname,
          lastname = @lastname,
          title = @title,
          extension = @extension,
          hiredate = @hiredate
       where
          employeeid = @employeeid
    ";
                              
         sqlConnection1.Open();
         SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection1);
         sqlCommand.Parameters.Add("@employeeid", key);
         sqlCommand.Parameters.Add("@firstname",
            ((TextBox)(e.Item.Cells[1].Controls[0])).Text);
         sqlCommand.Parameters.Add("@lastname",
            ((TextBox)(e.Item.Cells[2].Controls[0])).Text);
         sqlCommand.Parameters.Add("@title", 
            ((TextBox)(e.Item.Cells[3].Controls[0])).Text);
         sqlCommand.Parameters.Add("@extension",
            ((TextBox)(e.Item.Cells[4].Controls[0])).Text);
         sqlCommand.Parameters.Add("@hiredate",
            ((Calendar)
            (e.Item.Cells[5].FindControl("Calendar1"))).                                                                             
            SelectedDate.ToString());

         sqlCommand.ExecuteNonQuery();
         sqlConnection1.Close();

         DataGrid1.EditItemIndex = -1;
         BindDataGrid(true);
      }

      private void DataGrid1_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
      {
         DataGrid1.SelectedIndex = -1;
         Panel1.Visible = false;
         DataGrid1.EditItemIndex = -1;

         string key = DataGrid1.DataKeys[e.Item.ItemIndex].ToString();
         string sql = @"
         delete from employees
         where
            employeeid = @employeeid
      ";
  
         sqlConnection1.Open();

         SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection1);
         sqlCommand.Parameters.Add("@employeeid", key);
         sqlCommand.ExecuteNonQuery();

         sqlConnection1.Close();

         BindDataGrid(true); 
      }

      private void DataGrid1_SortCommand(object source, System.Web.UI.WebControls.DataGridSortCommandEventArgs e)
      {
         DataGrid1.SelectedIndex = -1;
         Panel1.Visible = false;
         DataGrid1.EditItemIndex = -1;
         BindDataGrid(e.SortExpression); 
      }
   }
}
