<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="vize.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Hesapla" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="206px" Width="127px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
