<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategorySetupUi.aspx.cs" Inherits="StockManagementSystemApp.UI.CategorySetuoUi" %>

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
            <legend> Category Setup</legend>
            <table>
            <tr>
                <td>
                     <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="categoryNameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
        
       
      
        <tr>
            <td>
                 <asp:Button ID="Button1" runat="server" Text="Save" OnClick="categorySaveButton_Click" />
            </td>
        </tr>
       
        
        <tr>
            <td>
                  <asp:Label ID="Outputlabel" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        


      </table>

        

     
        
         <asp:GridView ID="categoryGridView" runat="server" CellPadding="4" AutoGenerateColumns="False" ForeColor="#333333" GridLines="None">
             <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
             <Columns>
                 
                 <asp:TemplateField HeaderText="SL">
                     <ItemTemplate>
                       <%#Container.DataItemIndex +1 %>
                     </ItemTemplate>
                 </asp:TemplateField>
                 
                 <asp:TemplateField HeaderText="Name">
                     <ItemTemplate>
                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("CategoryName") %>'>'></asp:Label>

                         <asp:HiddenField ID="idHiddenField" runat="server" Value= '<%#Eval("CategoryId") %>'/>
                     </ItemTemplate>
                 </asp:TemplateField>
                 
                  <asp:TemplateField >
                     <ItemTemplate>
                         <asp:LinkButton ID="updateLinkButton" runat="server" OnClick="updateLinkButton_OnClick">Update</asp:LinkButton>
                     </ItemTemplate>
                 </asp:TemplateField>
             </Columns>
        </asp:GridView>
              </fieldset>
        <asp:HyperLink ID="backToIndexUiHyperLink" runat="server" NavigateUrl="IndexUi.aspx" Font-Size="20" ForeColor="white">Go To Index UI</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
