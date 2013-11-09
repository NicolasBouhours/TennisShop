<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Gestionproduits.aspx.vb" Inherits="SiteMarchandFinal.Gestionproduits" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<center>
<h2>Gestion des produits</h2> </br></br>

<fieldset class="choisirProduits">
<legend> Choisir la catégorie</legend>

</br>
<asp:DropDownList ID="dropdownlist" runat="server"></asp:DropDownList> </br> </br>
<asp:Button id="btnVoirList" runat="server" Text="Afficher la liste" /> </br>
</fieldset>

<fieldset class="listProduits">
<legend> Liste des produits pour votre catégorie</legend> 

<asp:Label id="listProduits" runat="server"></asp:Label> </br>


</fieldset>

</center>

</asp:Content>
