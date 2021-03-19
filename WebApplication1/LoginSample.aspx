<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginSample.aspx.cs" Inherits="WebApplication1.LoginSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtun"  runat="server"></asp:TextBox>
            <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
            <asp:Button ID="btnsubmit" runat="server" Text="Login" OnClick="btnsubmit_Click" />
        </div>
    </form>
</body>
</html>
