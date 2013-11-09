<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="modifierStatut.aspx.vb" Inherits="SiteMarchandFinal.modifierStatut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Modifier le statut d'une commande</h2> <br /> <br />
 <center> 
     <h4> Statut actuel : </h4> <asp:label id="statutLib" runat="server"></asp:label> <br /><br /> <br /> <br />
     <asp:DropDownList ID="dropdowlist" runat="server"></asp:DropDownList><br /><br />
     <asp:Button id="btnChange" class="btn btn-primary" runat="server" text="Modifier le statut"/>
       </center>
</asp:Content>
