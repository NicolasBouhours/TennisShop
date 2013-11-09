<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="detailmessage.aspx.vb" Inherits="SiteMarchandFinal.detailmessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Detail du message</h4> <br /> <br />
   <h5> <asp:label id="nomPersonne" runat="server"></asp:label> </h5>
    <h5> <asp:label ID="mailPersonne" runat="server"></asp:label> </h5> <br />
    <h5><asp:Label ID="dateMessage" runat="server"></asp:Label></h5>
    <h5> <asp:Label ID="titreMail" runat="server"></asp:Label></h5> <br />
    <asp:Label ID="contentMessage" runat="server"></asp:Label>

</asp:Content>
