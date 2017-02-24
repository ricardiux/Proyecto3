<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarDocente.aspx.cs" Inherits="AdministracionView.InsertarDocente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <asp:Label ID="Label6" runat="server" Text="Insertar Docente"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Cédula"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxCedulaDocente" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Nombre"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxNombreDocente" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Primer Apellido"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxPrimerApellidoDocente" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Segundo Apellido"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxSegundoApellidoDocente" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Teléfono"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxTelefonoDocente" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="Correo"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxCorreoDocente" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="Dirección"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxDireccionDocente" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Especialidades"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    
    </div>
    </form>
    
</body>
</html>
