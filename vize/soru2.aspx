<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="soru2.aspx.cs" Inherits="vize.soru2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table{
            border:1px solid #000;

        }

        .my-btn{
            width:100px;
            height:30px;
            background-color:orange;
            color:#333;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:PlaceHolder ID="PlaceHolder1" runat="server">
    
                
            </asp:PlaceHolder>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>

            <asp:TextBox ID="txtYil" runat="server" placeholder="Yıl"></asp:TextBox>
            <br />
            <br />
            <br /><br />

            <asp:Button ID="btnRun" runat="server" Text="Göster" BorderStyle="Outset" BackColor="Orchid" OnClick="btnRun_Click" CssClass="my-btn"/>
        </div>
    </form>


</body>
</html>
