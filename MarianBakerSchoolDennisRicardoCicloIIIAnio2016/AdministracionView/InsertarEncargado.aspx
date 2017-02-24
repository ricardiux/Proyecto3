<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarEncargado.aspx.cs" Inherits="AdministracionView.InsertarEncargado" %>

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
        <asp:Label ID="Label6" runat="server" Text="Insertar Encargado(a)"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Cédula"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxCedulaEncargado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Nombre"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxNombreEncargado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Primer Apellido"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxPrimerApellidoEncargado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Segundo Apellido"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxSegundoApellidoEncargado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Teléfono"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxTelefonoEncargado" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="Correo"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxCorreoEncargado" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="Dirección"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxDireccionEncargado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Nombre de Usuario"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxUsuarioEncargado" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Text="Clave de acceso"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxClaveEncargado" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    
    </div>
    </form>
</body>
</html>
