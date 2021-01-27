<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUi.aspx.cs" Inherits="StockManagementSystemApp.UI.IndexUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/style.css" rel="stylesheet" />
    <title></title>
</head>
<body  style="background-image: url(imanage.jpg);" >
    <form id="form1" runat="server" >
        
        <h1 align="center">Stock Management System</h1>
        <asp:HyperLink ID="CategorySetuoUiHyperLink" runat="server" NavigateUrl="CategorySetupUi.aspx" Font-Size="30" ForeColor="white">Category Setup</asp:HyperLink>
        
        <br/>
        <asp:HyperLink ID="CompanySetupUiHyperLink" runat="server" NavigateUrl="CompanyUI.aspx" Font-Size="30" ForeColor="white">Company Setup</asp:HyperLink>
        <br/>
       
        
       

        <asp:HyperLink ID="ItemSetupHyperLink" runat="server" NavigateUrl="ItemSetupUi.aspx" Font-Size="30" ForeColor="white">Item Setup</asp:HyperLink>
        
        <br/>
        
         <asp:HyperLink ID="stockInHyperLink" runat="server" NavigateUrl="StockInUi.aspx" Font-Size="30" ForeColor="white">Stock In</asp:HyperLink>
        <br/>
        
        <asp:HyperLink ID="stockOutHyperLink" runat="server" NavigateUrl="StockOutUi.aspx" Font-Size="30" ForeColor="white">Stock Out</asp:HyperLink>
        <br/>
        
        <asp:HyperLink ID="searchViewHyperLink" runat="server" NavigateUrl="SearchViewUi.aspx" Font-Size="30" ForeColor="white">Search & View Items Summary</asp:HyperLink>
        <br/>
         <asp:HyperLink ID="viewSalesHyperLink" runat="server" NavigateUrl="ViewSalesUi.aspx" Font-Size="30" ForeColor="white">View Sales Between Two Dates</asp:HyperLink>
        <br/>

        <p align="center"><font size="7" > Developed By <br/>
            
                M A Isfar Jubair Chowdhury <br/>
                Tafsir Mahmud
                          </font></p>
    <div>
    
    </div>
    </form>
</body>
</html>
