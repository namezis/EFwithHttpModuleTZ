<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EFwithHttpModuleTest1.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:PlaceHolder runat="server" ID="placeShort">
            <asp:Label ID="lblShort" runat="server" Text="Sample of short detail list"></asp:Label>
            <asp:GridView ID="gvEmployeeShort" runat="server" AutoGenerateColumns="true">
            </asp:GridView>
        </asp:PlaceHolder>
        <br />
        <br />
        <br />
        <asp:PlaceHolder runat="server" ID="placeLong">
            <asp:Label ID="lblLong" runat="server" Text="Sample of long detail list"></asp:Label>
            <asp:GridView ID="gvEmployeeLong" runat="server" AutoGenerateColumns="true">
            </asp:GridView>
        </asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
