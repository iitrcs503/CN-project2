<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 333px;
        }
        .auto-style4 {
            width: 666px;
        }
        body {
            background-image: url(/NewFolder1/pic12.jpg);
            background-size: 1366px 660px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            width: 134px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Panel ID="Panel1" runat="server">
                        <table class="auto-style1">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#FF6600" Text="Welcome User!!"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Italic="True" ForeColor="#FF6600" Text="Select your Country" Font-Bold="True"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#FF6600">
                        <asp:ListItem> ---  select  --- </asp:ListItem>
                        <asp:ListItem>australia</asp:ListItem>
                        <asp:ListItem>brazil</asp:ListItem>
                        <asp:ListItem>china</asp:ListItem>
                        <asp:ListItem>england</asp:ListItem>
                        <asp:ListItem>france</asp:ListItem>
                        <asp:ListItem>india</asp:ListItem>
                        <asp:ListItem>japan</asp:ListItem>
                        <asp:ListItem>russia</asp:ListItem>
                        <asp:ListItem>south africa</asp:ListItem>
                        <asp:ListItem>usa</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="auto-style3">
                    <asp:Image ID="Image1" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style4">
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" placeholder="Enter File Name"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" BackColor="#CCFFFF" BorderColor="#FF6600" BorderStyle="Outset" BorderWidth="5px" Font-Bold="True" Font-Italic="True" ForeColor="#FF6600" />
                            </td>
                            <td>
                                <asp:Panel ID="Panel2" runat="server" BackColor="#CCFFFF">
                                    <table class="auto-style1">
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style7">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                            </td>
                                            <td class="auto-style7">
                                                <asp:Label ID="Label4" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label5" runat="server" Text="c1 clients country:"></asp:Label>
                                            </td>
                                            <td class="auto-style7">
                                                <asp:Label ID="Label3" runat="server" Text="Label_dlt"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label6" runat="server" Text="c2 &quot;wher&quot; country:"></asp:Label>
                                            </td>
                                            <td class="auto-style7">
                                                <asp:Label ID="Label7" runat="server" Text="Label_dlt2"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="Label10" runat="server" Text="c3 cost of file transfer"></asp:Label>
                                            </td>
                                            <td class="auto-style7">
                                                <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td class="auto-style7">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:RadioButton ID="RadioButton1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#FF6600" Text="Show Benefit" AutoPostBack="True" OnCheckedChanged="RadioButton1_CheckedChanged" />
                                            </td>
                                            <td class="auto-style7">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Panel ID="Panel3" runat="server">
                                                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="LinqDataSource1">
                                                        <Columns>
                                                            
                                                            
                                                            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" />
                                                            <asp:BoundField DataField="c1_name" HeaderText="c1_name" SortExpression="c1_name" />
                                                            <asp:BoundField DataField="c1_num" HeaderText="c1_num" SortExpression="c1_num" />
                                                            <asp:BoundField DataField="c2_name" HeaderText="c2_name" SortExpression="c2_name" />
                                                            <asp:BoundField DataField="c2_num" HeaderText="c2_num" SortExpression="c2_num" />
                                                            <asp:BoundField DataField="c3" HeaderText="c3" SortExpression="c3" />
                                                            <asp:BoundField DataField="c4" HeaderText="c4" SortExpression="c4" />
                                                            <asp:BoundField DataField="benefit" HeaderText="benefit" SortExpression="benefit" />
                                                        </Columns>
                                                    </asp:GridView>
                                                    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataClassesDataContext" EntityTypeName="" OrderBy="Id" TableName="Costs">
                                                    </asp:LinqDataSource>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <br />
                                <br />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <br />
                                <br />
                                <br />
                                <br />
                            </td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/server.aspx" Font-Bold="True" Font-Italic="True" ForeColor="#FF6600">admin page</asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">&nbsp;</td>
                            <td>
                                <br />
                                <br />
&nbsp;<br />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
