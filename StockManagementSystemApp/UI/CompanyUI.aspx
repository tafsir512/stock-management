<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyUI.aspx.cs" Inherits="StockManagementSystemApp.UI.CompanyUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="companyNameTextBox" runat="server"></asp:TextBox>
        <br />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="categorySaveButton" runat="server" Text="Save" OnClick="categorySaveButton_Click" />

        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Label ID="Outputlabel" runat="server" Text=""></asp:Label>
        <br/>

       


    </div>
        
    </form>
</body>
</html>
