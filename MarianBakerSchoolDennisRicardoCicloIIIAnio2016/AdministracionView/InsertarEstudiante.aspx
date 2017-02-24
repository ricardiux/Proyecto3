<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarEstudiante.aspx.cs" Inherits="AdministracionView.InsertarEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Insertar Estudiante"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cédula"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxCedula" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Primer Apellido"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxPrimerApellido" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Segundo Apellido"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxSegundoApellido" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Encargado(a)"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ddlListaEncargados" runat="server" AutoPostBack="True" >
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    
    </div>
    </form>
</body>
</html>
