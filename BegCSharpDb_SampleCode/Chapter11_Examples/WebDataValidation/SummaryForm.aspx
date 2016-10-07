<%@ Page language="c#" Codebehind="SummaryForm.aspx.cs" AutoEventWireup="false" Inherits="WebDataValidation.WebForm7" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm7</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="WebForm7" method="post" runat="server">
			<TABLE id="Table1" style="WIDTH: 659px; HEIGHT: 261px" cellSpacing="1" cellPadding="0" width="659" border="0">
				<TR>
					<TD style="BORDER-RIGHT: black thin solid; BORDER-TOP: black thin solid; FONT-WEIGHT: bold; FONT-SIZE: larger; BORDER-LEFT: black thin solid; COLOR: white; BORDER-BOTTOM: black thin solid; FONT-STYLE: italic; BACKGROUND-COLOR: #336666; TEXT-ALIGN: center" colSpan="3">New 
						Employee Form&nbsp;&nbsp;</TD>
				</TR>
				<TR>
					<TD>First Name
						<asp:textbox id="FirstNameTextBox" runat="server"></asp:textbox><asp:requiredfieldvalidator id="FirstNameRequiredFieldValidator" runat="server" ControlToValidate="FirstNameTextBox" ErrorMessage="First Name is required.">*</asp:requiredfieldvalidator></TD>
					<TD>Last Name
						<asp:textbox id="LastNameTextBox" runat="server"></asp:textbox><asp:requiredfieldvalidator id="LastNameRequiredFieldValidator" runat="server" ControlToValidate="LastNameTextBox" ErrorMessage="Last Name is required.">*</asp:requiredfieldvalidator></TD>
					<TD rowSpan="3"><asp:validationsummary id="EmployeeValidationSummary" runat="server" DisplayMode="List"></asp:validationsummary></TD>
				</TR>
				<TR>
					<TD>Hire Date
						<asp:textbox id="HireDateTextBox" runat="server"></asp:textbox><asp:requiredfieldvalidator id="HireDateRequiredFieldValidator" runat="server" ControlToValidate="HireDateTextBox" ErrorMessage="Hire Date is required.">*</asp:requiredfieldvalidator><asp:rangevalidator id="HireDateRangeValidator" runat="server" ControlToValidate="HireDateTextBox" ErrorMessage="Hiring Date must be with a one week range." Type="Date">*</asp:rangevalidator></TD>
					<TD>Birth Date
						<asp:textbox id="BirthDateTextBox" runat="server"></asp:textbox><asp:rangevalidator id="BirthDateRangeValidator" runat="server" ControlToValidate="BirthDateTextBox" ErrorMessage="Birth date cannot be in the future." Type="Date">*</asp:rangevalidator></TD>
				</TR>
				<TR>
					<TD>
						<P>Reports To
							<asp:dropdownlist id="ReportsToDropDownList" runat="server"></asp:dropdownlist></P>
					</TD>
					<TD>Photo URL
						<asp:textbox id="PhotoURLTextBox" runat="server"></asp:textbox><asp:regularexpressionvalidator id="PhotoUrlRegularExpressionValidator" runat="server" ControlToValidate="PhotoURLTextBox" ErrorMessage="Not a valid URL or file format." ValidationExpression="http://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?.jpg">*</asp:regularexpressionvalidator></TD>
				</TR>
				<TR>
					<TD align="middle" colSpan="3"><asp:button id="SubmitButton" runat="server" Text="Submit"></asp:button>&nbsp;&nbsp;
						<asp:Button id="ClearButton" runat="server" Text="Clear" CausesValidation="False"></asp:Button></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
