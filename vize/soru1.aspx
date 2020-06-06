<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="soru1.aspx.cs" Inherits="vize.soru1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .bg{
            background:pink;
        }

        

        

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_yazdir" runat="server" OnClick="btn_yazdir_Click" Text="Yazdır" Width="129px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>

</body>
</html>
