<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="vize.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        INPUT[type="text"] {
            width: 20px;
        }

        * {
            text-align: center;
            margin: 0 auto;
        }

        body {
            background: #161616;
        }

        h1 {
            color: greenyellow;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 25px;
        }

        p {
            color: #ccc;
            font-size: 12px;
        }

        .lbl{
            padding:2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br /><br />
            <asp:TextBox ID="TextBox1" runat="server" MaxLength="1"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" MaxLength="1"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" MaxLength="1"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" MaxLength="1"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" MaxLength="1"></asp:TextBox>
            <asp:TextBox ID="TextBox6" runat="server" MaxLength="1"></asp:TextBox>
            <asp:TextBox ID="TextBox7" runat="server" MaxLength="1"></asp:TextBox>
            <asp:TextBox ID="TextBox8" runat="server" MaxLength="1"></asp:TextBox>
            <asp:TextBox ID="TextBox9" runat="server" MaxLength="1"></asp:TextBox>
            <asp:TextBox ID="TextBox10" runat="server" MaxLength="1"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Yazdır" OnClick="Button1_Click" />
            <br /><br />
            <asp:Label ID="Label1" runat="server" CssClass="lbl" ></asp:Label>

            <br />
            <br />
            <h1>görkem acar</h1>
            <p>vize - soru 1</p>
        </div>
    </form>
</body>
</html>
