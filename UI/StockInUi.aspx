<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockInUi.aspx.cs" Inherits="StockManagementSystemApp.UI.StockInUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/style.css" rel="stylesheet" />
    <title></title>
</head>
<body style="background-image: url(imanage.jpg);">
    <form id="form1" runat="server">
    <div>
        <fieldset>
        <table>
                    
            <legend>
                Stock In
            </legend>
        
        
            
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Company"></asp:Label>
                   </td>
                 <td>
                    <asp:DropDownList ID="companyDropDownList" runat="server"  DataValueField="CompanyId" DataTextField="CompanyName" OnSelectedIndexChanged="companyDropDownList_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                </td>
            </tr>
            
              <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Item"></asp:Label>
                 </td>
                 <td>
                    <asp:DropDownList ID="itemDropDownList" runat="server" DataValueField="ItemId" DataTextField="ItemName" OnSelectedIndexChanged="itemDropDownList_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                </td>
            </tr>
            
              <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Reorder Level"></asp:Label>
                 </td>
                 <td>
                    <asp:TextBox ID="reorderLevelTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            
              <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Available Quantity"></asp:Label>
                 </td>
                   <td>
                    <asp:TextBox ID="availableQuantityTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Stock In Quantity"></asp:Label>
                 </td>
                 <td>
                    <asp:TextBox ID="stockInQuantityTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                </td>
            </tr>
            
            <tr>
                <td>
                    <asp:Label ID="OutputLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>

                        
        </table>
         </fieldset>
          <asp:HyperLink ID="backToIndexUiHyperLink" runat="server" NavigateUrl="IndexUi.aspx" Font-Size="20" ForeColor="white">Go To Index UI</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
