<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarGrupo.aspx.cs" Inherits="AdministracionView.InsertarGrupo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Insertar Grupos"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Código de Grupo"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxCodigo" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Grado"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ddlGrado" runat="server">
            <asp:ListItem Value="1"></asp:ListItem>
            <asp:ListItem Value="2"></asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Value="4"></asp:ListItem>
            <asp:ListItem Value="5"></asp:ListItem>
            <asp:ListItem Value="6"></asp:ListItem>
            <asp:ListItem Value="7"></asp:ListItem>
            <asp:ListItem Value="8"></asp:ListItem>
            <asp:ListItem Value="9"></asp:ListItem>
            <asp:ListItem Value="10"></asp:ListItem>
            <asp:ListItem Value="11"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
