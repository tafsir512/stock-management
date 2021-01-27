<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSalesUi.aspx.cs" Inherits="StockManagementSystemApp.UI.ViewSalesUi" %>

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
            <legend>
                View Sales Between Two Dates
            </legend>
            
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="From Date"></asp:Label>
                        

                    </td>
                    <td>
                        <asp:TextBox ID="fromDateTextBox" runat="server"></asp:TextBox>
                        <asp:Button ID="searchButton1" runat="server" Text="Select" OnClick="searchButton1_Click" />
                        <asp:Calendar ID="fromDateCalendar" runat="server" OnSelectionChanged="fromDateCalendar_SelectionChanged"></asp:Calendar>
                    </td>
                </tr>
                
                 <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="To Date"></asp:Label>
                         
                    </td>
                    <td>
                        <asp:TextBox ID="toDateTextBox" runat="server"></asp:TextBox>
                         <asp:Button ID="searchButton2" runat="server" Text="Select" OnClick="searchButton2_Click" />
                        <asp:Calendar ID="toDateCalendar" runat="server" OnSelectionChanged="toDateCalendar_SelectionChanged"></asp:Calendar>
                        
                    </td>
                </tr>
                
                <tr>
                    <td>
                        
                    </td>
                    
                    <td align="right">
                        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click"  />
                    </td>
                </tr>
                
                <tr> <td></td> 
                    <td>
                        <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>

            <asp:GridView ID="viewSalesGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            

                                    <asp:TemplateField HeaderText="Sale Quantity">
                                        <ItemTemplate>
                                            <asp:Label ID="stockOutQuantityLabel" runat="server" Text='<% #Eval("StockOutQuantity")%>'></asp:Label>
                                            
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
        </fieldset>
          <asp:HyperLink ID="backToIndexUiHyperLink" runat="server" NavigateUrl="IndexUi.aspx" Font-Size="20" ForeColor="white">Go To Index UI</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
