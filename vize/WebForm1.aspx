<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="vize.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            text-align: center;
            margin: 0 auto;
        }

        body {
            background: #161616;
        }

        table {
            border: 1px solid #fff;
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Yıl"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Getir" Width="84px" OnClick="Button1_Click" />
            <br />
            <br />
          

            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <br />

            <h1>görkem acar</h1>
            <p>vize - soru 2</p>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
