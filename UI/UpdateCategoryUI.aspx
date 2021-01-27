<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCategoryUI.aspx.cs" Inherits="StockManagementSystemApp.UI.UpdateCategoryUI" %>

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
            <legend> Update Category</legend>
            <table>
            <tr>
                <td>
                     <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                      <asp:TextBox ID="categoryNameTextBox" runat="server"></asp:TextBox>
                    <asp:HiddenField ID="idHiddenField" runat="server" />
                </td>
            </tr>
                
                <tr>
                    <td>
                        <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
                    </td>
                </tr>
                
                 <tr>
                    <td>
                        <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                </table>
                
                </fieldset>
          <asp:HyperLink ID="backToIndexUiHyperLink" runat="server" NavigateUrl="IndexUi.aspx" Font-Size="20" ForeColor="white">Go To Index UI</asp:HyperLink>
    </div>
    </form>
</body>
</html>
