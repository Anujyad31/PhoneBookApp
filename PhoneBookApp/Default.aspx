<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PhoneBookApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                Phone Number:<asp:TextBox ID="txtPhoneNum" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                Address:<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>

        </tr>
        <tr>
            <td>
                <asp:Button ID="BtnAdd" runat="server" Text="ADD" OnClick="BtnAdd_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"  />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"  />
            </td>
        </tr>
    </table>
    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
