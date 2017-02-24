<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarMatricula.aspx.cs" Inherits="AdministracionView.InsertarMatricula" %>

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
        <asp:Label ID="Label1" runat="server" Text="Realizar Matrícula"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Estudiante"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="ddlEstudiante" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        Grupo<br />
        <br />
        <asp:DropDownList ID="ddlGrupo" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Fecha de Pago"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxFechaPago" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Monto"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxMonto" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnMatricula" runat="server" Text="Matricular" OnClick="btnMatricula_Click" />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
