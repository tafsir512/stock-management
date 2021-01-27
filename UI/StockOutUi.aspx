<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockOutUi.aspx.cs" Inherits="StockManagementSystemApp.UI.StockOutUi" %>

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
            <legend>Stock Out</legend>
            
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Company"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="companyDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="companyDropDownList_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Item"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="itemDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="itemDropDownList_SelectedIndexChanged"></asp:DropDownList>
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
                        <asp:Label ID="Label5" runat="server" Text="Stock Out Quantity"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="stockOutQuantityTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
                <tr align="right">
                    
                    <td></td>
                    <td >
                        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" />
                    </td>
                    
                </tr>
                
                <tr>
                    <td>
                        
                    </td>
                    
                    <td>
                        <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </fieldset>
        
        <asp:GridView ID="itemQuantityGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="SL">
                                        <ItemTemplate>
                                            <%#Container.DataItemIndex +1 %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                
                 
                                 <asp:TemplateField HeaderText="Item">
                                        <ItemTemplate>
                                            <asp:Label ID="ItemNameLabel" runat="server" Text='<% #Eval("ItemName")%>'></asp:Label>
                                            
                                        </ItemTemplate>
                                    </asp:TemplateField>
            

                                    <asp:TemplateField HeaderText="Company">
                                        <ItemTemplate>
                                            <asp:Label ID="companyNameLabel" runat="server" Text='<% #Eval("CompanyName")%>'></asp:Label>
                                            
                                        </ItemTemplate>
                                    </asp:TemplateField>
                
                                <asp:TemplateField HeaderText="Quantity">
                                        <ItemTemplate>
                                            <asp:Label ID="quantityLabel" runat="server" Text='<% #Eval("StockOutQuantity")%>'></asp:Label>
                                            
                                        </ItemTemplate>
                                    </asp:TemplateField>
                

                                </Columns>

                               
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

                               
        </asp:GridView>
        
        <br />
        <asp:Button ID="sellButton" runat="server" Text="Sell" OnClick="sellButton_Click" />
        <asp:Button ID="damageButton" runat="server" Text="Damage" OnClick="damageButton_Click" />
        <asp:Button ID="lostButton" runat="server" Text="Lost" OnClick="lostButton_Click" />
        <br/>

        <asp:Label ID="sellLabel" runat="server" Text=""></asp:Label>
        
        <asp:HyperLink ID="backToIndexUiHyperLink" runat="server" NavigateUrl="IndexUi.aspx" Font-Size="20" ForeColor="white">Go To Index UI</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
