<%@ Page language="c#" Codebehind="WebForm1.aspx.cs" AutoEventWireup="false" Inherits="WebDataGrid.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
   <HEAD>
      <title>WebForm1</title>
      <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
      <meta content="C#" name="CODE_LANGUAGE">
      <meta content="JavaScript" name="vs_defaultClientScript">
      <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
   </HEAD>
   <body>
      <form id="Form1" method="post" runat="server">
         <asp:datagrid id="DataGrid1" runat="server" AllowPaging="True" PageSize="5" GridLines="Horizontal"
            CellPadding="4" BackColor="White" BorderWidth="3px" BorderStyle="Double" BorderColor="#336666"
            AutoGenerateColumns="False" AllowSorting="True">
            <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#339966"></SelectedItemStyle>
            <ItemStyle ForeColor="#333333" BackColor="White"></ItemStyle>
            <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#336666"></HeaderStyle>
            <FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
            <Columns>
               <asp:ButtonColumn Text="&lt;img border=0 src=magnify.gif&gt;" CommandName="Select"></asp:ButtonColumn>
               <asp:BoundColumn DataField="firstname" SortExpression="firstname" HeaderText="First Name"></asp:BoundColumn>
               <asp:BoundColumn DataField="lastname" SortExpression="lastname" HeaderText="Last Name"></asp:BoundColumn>
               <asp:BoundColumn DataField="title" SortExpression="title" HeaderText="Title"></asp:BoundColumn>
               <asp:BoundColumn DataField="extension" SortExpression="extension" HeaderText="Phone"></asp:BoundColumn>
               <asp:TemplateColumn SortExpression="hiredate" HeaderText="Hire Date">
                  <ItemTemplate>
                     <asp:Label runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.hiredate", "{0:d}") %>' ID="Label1" NAME="Label1">
                     </asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:Calendar ID="Calendar1" Runat="server" BorderColor="#336666" ShowGridLines="True" NextPrevFormat="ShortMonth" VisibleDate='<%# DataBinder.Eval(Container, "DataItem.HireDate") %>' SelectedDate='<%# DataBinder.Eval(Container, "DataItem.HireDate") %>'>
                        <TitleStyle ForeColor="White" BackColor="#336666"></TitleStyle>
                     </asp:Calendar>
                  </EditItemTemplate>
               </asp:TemplateColumn>
               <asp:EditCommandColumn ButtonType="PushButton" UpdateText="Update" CancelText="Cancel" EditText="Edit"></asp:EditCommandColumn>
               <asp:ButtonColumn Text="Delete" CommandName="Delete"></asp:ButtonColumn>
            </Columns>
            <PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
         </asp:datagrid><asp:panel id="Panel1" runat="server" Visible="False" Height="50px" Width="260px" HorizontalAlign="Center">
            <TABLE id="Table1" cellSpacing="1" cellPadding="1" width="300" border="1">
               <TR>
                  <TD style="COLOR: white" align="center" bgColor="#336666" colSpan="1" rowSpan="1">Note
                  </TD>
               </TR>
               <TR>
                  <TD align="center">
                     <asp:Label id="Label2" runat="server">
               Label
            </asp:Label></TD>
               </TR>
            </TABLE>
         </asp:panel></form>
   </body>
</HTML>
