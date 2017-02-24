<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeFile="EliminarEstudiante.aspx.cs" Inherits="VistaAdmin.EliminarEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Eliminar Estudiante  </h1>
    <asp:DropDownList ID="ddlListaEstudiantes" runat="server" AutoPostBack="True">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
</asp:Content>
