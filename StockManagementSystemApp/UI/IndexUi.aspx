<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUi.aspx.cs" Inherits="StockManagementSystemApp.UI.IndexUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="CategorySetuoUiHyperLink" runat="server" NavigateUrl="CategorySetupUi.aspx">Category Setup</asp:HyperLink>
        <br/>
        <asp:HyperLink ID="CompanySetupUiHyperLink" runat="server" NavigateUrl="CompanyUI.aspx">Company Setup</asp:HyperLink>
        <br/>
        <asp:HyperLink ID="ShowAllCategoriesHyperLink" runat="server" NavigateUrl="ShowAllCategories.aspx">Show All Categories</asp:HyperLink>
        <br/>
        
        <asp:HyperLink ID="ShowAllCompaniesHyperLink" runat="server" NavigateUrl="ShowAllCompanies.aspx">Show All Companies</asp:HyperLink>
        <br/>

    <div>
    
    </div>
    </form>
</body>
</html>
