<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="pageproduits.aspx.vb" Inherits="SiteMarchandFinal.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="span12">
           <center> <asp:label id="titreCad" runat="server"></asp:label> </center>
            <br />
            <br />
            <asp:Label ID="listeProd" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
