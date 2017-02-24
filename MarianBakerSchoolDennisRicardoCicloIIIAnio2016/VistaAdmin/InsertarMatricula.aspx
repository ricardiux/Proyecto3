<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeFile="InsertarMatricula.aspx.cs" Inherits="VistaAdmin.InsertarMatricula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>

        <br />
        <h1><asp:Label ID="Label1" runat="server" Text="Realizar Matrícula"></asp:Label></h1>
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
        <asp:Label ID="Label4" runat="server" Text="Monto en colones"></asp:Label>
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
    </div>

</asp:Content>
