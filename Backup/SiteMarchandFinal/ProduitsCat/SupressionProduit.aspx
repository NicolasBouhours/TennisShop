<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="SupressionProduit.aspx.vb" Inherits="SiteMarchandFinal.SupressionProduit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<center>

<h2> Supression d'un produit </h2>

<fieldset class="triCat">
<legend>Trier par catégorie</legend>
</br>
<asp:DropDownList ID="dropdownlist" runat="server"></asp:DropDownList> </br> </br>
<asp:Button ID="triList" runat="server" Text="Trier" /> </br>
</fieldset>

<fieldset class="listProduits">
<legend> Liste des produits pour votre catégorie</legend> 

<asp:Label id="lbSup" runat="server"> Veuillez choisir le produit a supprimer :</asp:Label> </br>
<asp:DropDownList ID="dropDownSup" runat="server"></asp:DropDownList> </br> </br>
<asp:Button ID="btnSupProd" runat="server" text="Supprimer le produit" /> </br> </br>

<asp:Label ID="lbError" runat="server" style="color:Red"></asp:Label> </br> </br>

</fieldset>

</center>
</asp:Content>
