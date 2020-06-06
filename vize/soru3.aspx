<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="soru3.aspx.cs" Inherits="vize.soru3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            text-align: center;
            margin: 0 auto;
        }
        body{
            background:#161616;
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
            <asp:Image ID="resim1" runat="server" />
            <asp:Image ID="resim2" runat="server" />
            <asp:Image ID="resim3" runat="server" />
            <br />
            <br />
            <asp:Button ID="btn_degis" runat="server" OnClick="btn_degis_Click" Text="Değiştir" Width="91px" />

            <br />
            <br />
            <h1>görkem acar</h1>
            <p>vize - soru 3</p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>


        </div>
    </form>
</body>
</html>
