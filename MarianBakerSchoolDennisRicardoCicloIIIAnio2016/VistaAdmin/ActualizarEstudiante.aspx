<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeFile="ActualizarEstudiante.aspx.cs" Inherits="VistaAdmin.ActualizarEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h1><asp:Label ID="Label1" runat="server" Text="Actualizar Estudiante"></asp:Label></h1>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cédula"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="tbxCedula" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
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
        <br />
        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
    </div>

</asp:Content>
