<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="InsertarEstudiante.aspx.cs" Inherits="VistaAdmin.InsertarEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <h1><asp:Label ID="Label1" runat="server" Text="Insertar Estudiante"></asp:Label></h1>
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
        <asp:DropDownList ID="ddlListaEncargados" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    </div>

</asp:Content>
