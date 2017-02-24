<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarCurso.aspx.cs" Inherits="AdministracionView.InsertarCurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Insertar Curso"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Código"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxCodigo" runat="server" Enabled="False" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Grupo"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ddlGrupos" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Docente"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ddlDocentes" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
        <br />
    
    </div>
    </form>
</body>
</html>
