<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="miWeb._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-2"></div>
        <div class="cos-2"></div>
    </div>
    <asp:TextBox ID="txtboxBuscar" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" Text="ingresar" cssClass="btn btn-outline-success" runat="server" OnClick="btnBuscar_Click" />
    <asp:Label ID="lblSaludo" runat="server"></asp:Label>
    <a href="Contacto.aspx?id=3">Contacto</a>
</asp:Content>
