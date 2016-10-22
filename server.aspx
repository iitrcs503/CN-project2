<%@ Page Language="C#" AutoEventWireup="true" CodeFile="server.aspx.cs" Inherits="server" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 453px;
        }
         body {
            background-image: url(/NewFolder1/pic12.jpg);
            background-size: 1366px 660px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                                    <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#FF6600" Text="Welcome Admin!!"></asp:Label>
                                <br />
                    <br />
                    <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="17pt" ForeColor="#FF6600" Text="Server Database"></asp:Label>
                </td>
                <td>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/server.aspx" Font-Bold="True" Font-Italic="True" ForeColor="#FF6600">Reload</asp:HyperLink>
                            </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="name,wher,owner" DataSourceID="LinqDataSource1" PageSize="25" BorderStyle="Dotted">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:BoundField DataField="name" HeaderText="name" ReadOnly="True" SortExpression="name" />
                            <asp:BoundField DataField="wher" HeaderText="wher" ReadOnly="True" SortExpression="wher" />
                            <asp:BoundField DataField="owner" HeaderText="owner" ReadOnly="True" SortExpression="owner" />
                            <asp:BoundField DataField="count" HeaderText="count" SortExpression="count" />
                        </Columns>
                    </asp:GridView>
                    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataClassesDataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="Table1s">
                    </asp:LinqDataSource>
                </td>
                <td>
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:CheckBox ID="CheckBox1" runat="server" Text="Insert Data" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="True" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Panel ID="Panel1" runat="server">
                                    <table class="auto-style1">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Text="Enter File Name"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Button ID="Button1" runat="server" Font-Italic="True" ForeColor="#FF6600" Text="Insert" OnClick="Button1_Click" BackColor="#99CCFF" BorderColor="#FF6600" BorderStyle="Outset" BorderWidth="5px" Font-Bold="True" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label2" runat="server"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                                </asp:Panel>
                                <br />
                                
                                <br />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
