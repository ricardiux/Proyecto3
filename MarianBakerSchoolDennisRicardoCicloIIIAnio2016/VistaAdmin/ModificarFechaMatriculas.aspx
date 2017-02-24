<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeFile="ModificarFechaMatriculas.aspx.cs" Inherits="VistaAdmin.ModificarFechaMatriculas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
        <h1>
            <asp:Label ID="Label1" runat="server" Text="Modificar Fecha de Pago de Matr&iacute;cula"></asp:Label></h1>
        <br />
        <br />
        <br />
        <h3>Elegir Matr&iacute;cula</h3>
        <asp:DropDownList ID="ddlListaMatriculas" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxNombre" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Primer Apellido"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxPrimerApellido" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Segundo Apellido"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxSegundoApellido" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Fecha de Pago"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxFechaPago" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
    </div>

</asp:Content>
