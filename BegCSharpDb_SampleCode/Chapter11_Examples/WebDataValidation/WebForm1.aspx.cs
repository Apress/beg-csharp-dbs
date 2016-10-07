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

namespace WebDataValidation
{
   /// <summary>
   /// Summary description for WebForm1.
   /// </summary>
   public class WebForm1 : System.Web.UI.Page
   {
      protected System.Web.UI.WebControls.Button SubmitButton;
      protected System.Web.UI.WebControls.Button CancelButton;
      protected System.Web.UI.WebControls.TextBox FirstNameTextBox;
      protected System.Web.UI.WebControls.TextBox HireDateTextBox;
      protected System.Web.UI.WebControls.RangeValidator HireDateValidator;
      protected System.Web.UI.WebControls.RequiredFieldValidator HireDateRequiredFieldValidator;
      protected System.Web.UI.WebControls.TextBox PasswordTextBox1;
      protected System.Web.UI.WebControls.TextBox PasswordTextBox2;
      protected System.Web.UI.WebControls.CompareValidator PasswordCompareValidator;
      protected System.Web.UI.WebControls.TextBox PhotoURLTextBox;
      protected System.Web.UI.WebControls.RegularExpressionValidator PhotoURLRegularExpressionValidator;
      protected System.Web.UI.WebControls.CustomValidator PhotoURLCustomValidator;
      protected System.Web.UI.WebControls.RequiredFieldValidator FirstNameRequiredFieldValidator;
	
      private void Page_Load(object sender, System.EventArgs e)
      {
         DateTime nextWeek = DateTime.Today + TimeSpan.FromDays(7);
         DateTime lastWeek = DateTime.Today - TimeSpan.FromDays(7);
         HireDateValidator.MaximumValue = nextWeek.ToShortDateString();
         HireDateValidator.MinimumValue = lastWeek.ToShortDateString();
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
         this.PhotoURLCustomValidator.ServerValidate += new System.Web.UI.WebControls.ServerValidateEventHandler(this.PhotoURLCustomValidator_ServerValidate);
         this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
         this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
         this.Load += new System.EventHandler(this.Page_Load);

      }
      #endregion

      private void SubmitButton_Click(object sender, System.EventArgs e)
      {
         if(Page.IsValid)
         {
         }
      }

      private void CancelButton_Click(object sender, System.EventArgs e)
      {
         FirstNameTextBox.Text="";
         HireDateTextBox.Text="";
      }

      private void PhotoURLCustomValidator_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
      {
         args.IsValid = false;
         if(args.Value != null)
         {
            int length = args.Value.Length;
            string endsWidth = args.Value.Substring(length - 3);
            if(endsWidth == "jpg")
            {
               args.IsValid = true;
            }
         }
      }
   }
}
