<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarEspecialidad.aspx.cs" Inherits="AdministracionView.InsertarEspecialidad" %>

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
        <asp:Label ID="Label5" runat="server" Text="Asignar Especialidades a Docentes"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Codigo de Especialidad"></asp:Label>
        <br />
        <br />
    
        <asp:TextBox ID="tbxCodigo" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Docente"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ddlDocentes" runat="server">
        </asp:DropDownList>
    
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    
    </div>
    </form>
</body>
</html>
