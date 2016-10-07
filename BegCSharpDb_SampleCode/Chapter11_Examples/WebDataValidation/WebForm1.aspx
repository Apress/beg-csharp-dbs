<%@ Page language="c#" Codebehind="WebForm1.aspx.cs" AutoEventWireup="false" Inherits="WebDataValidation.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
   <HEAD>
      <title>WebForm1</title>
      <meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
      <meta name="CODE_LANGUAGE" Content="C#">
      <meta name="vs_defaultClientScript" content="JavaScript">
      <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
   </HEAD>
   <body>
      <script language="javascript">
  function validate_photoformat(oSrc, args)
  {
    args.IsValid = false;
    if(args.Value)
    {
       var length = args.Value.length;
       var endsWidth = args.Value.substr(length - 3, 3);
       if(endsWidth == "jpg")
       {
         args.IsValid = true;
       }
    }
  }
      </script>
      <form id="Form1" method="post" runat="server">
         <P>First Name</P>
         <P>
            <asp:TextBox id="FirstNameTextBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator id="FirstNameRequiredFieldValidator" runat="server" ErrorMessage="First Name Is Required"
               ControlToValidate="FirstNameTextbox"></asp:RequiredFieldValidator></P>
         <P>Hire Date</P>
         <P>
            <asp:TextBox id="HireDateTextBox" runat="server"></asp:TextBox>
            <asp:RangeValidator id="HireDateValidator" runat="server" ControlToValidate="HireDateTextBox" ErrorMessage="The hire date must be within a week of today's date"
               Type="Date" Display="Dynamic"></asp:RangeValidator>
            <asp:RequiredFieldValidator id="HireDateRequiredFieldValidator" runat="server" ControlToValidate="HireDateTextBox"
               ErrorMessage="Hire date is required"></asp:RequiredFieldValidator></P>
         <P>Password</P>
         <P>
            <asp:TextBox id="PasswordTextBox1" runat="server" TextMode="Password"></asp:TextBox></P>
         <P>Confirm Password</P>
         <P>
            <asp:TextBox id="PasswordTextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator id="PasswordCompareValidator" runat="server" ControlToValidate="PasswordTextBox2"
               ErrorMessage="Passwords do not match" ControlToCompare="PasswordTextBox1"></asp:CompareValidator></P>
         <P>Photo URL</P>
         <P>
            <asp:TextBox id="PhotoURLTextBox" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator id="PhotoURLRegularExpressionValidator" runat="server" ControlToValidate="PhotoURLTextBox"
               ErrorMessage="This is not a valid URL" ValidationExpression="http://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" Display="Dynamic"></asp:RegularExpressionValidator>
            <asp:CustomValidator id="PhotoURLCustomValidator" runat="server" ControlToValidate="PhotoURLTextBox"
               ErrorMessage="Unsupported file format" ClientValidationFunction="validate_photoformat"></asp:CustomValidator></P>
         <P>
            <asp:Button id="SubmitButton" runat="server" Text="Submit"></asp:Button>
            <asp:Button id="CancelButton" runat="server" Text="Cancel" CausesValidation="False"></asp:Button></P>
         <P>&nbsp;</P>
      </form>
   </body>
</HTML>
