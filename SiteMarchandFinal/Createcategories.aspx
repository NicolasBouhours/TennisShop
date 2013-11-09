<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Createcategories.aspx.vb" Inherits="SiteMarchandFinal.Createcategories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<center>

<h2>Formulaire d'ajout de catégorie</h2>
</br>
</br>

<fieldset class="listcat">
<center>
</br>
<h3> Liste des catégories actuelles : </h3>
</br>
<asp:Label id="ListCat" runat="server"> 

</asp:Label>
</br>
</br>
</center>
</fieldset>

<fieldset class="AddCat" >

<h2>Formulaire d'ajout de catégorie</h2>

<legend>Ajout d'une catégorie</legend>
</br>
</br>

<asp:Label id="LibCat" runat="server" AssociatedControlID="NomCat" >Nom de la catégorie :</asp:Label>
<asp:TextBox id="NomCat" runat="server"></asp:TextBox>
</br>
</br>
<asp:Button id="BtnAddCat" class="btn btn-danger"  runat="server" Text="Ajouter la catégorie" />
</br>
</br>
<asp:Label id="LbInfo" runat ="server" style="color:Red" ></asp:Label>
</br>
</br>
</fieldset>

<fieldset class="deleteCat">
<legend> Supprimer une catégorie</legend>

</br>
<asp:DropDownList ID="dropdownlist" runat="server"></asp:DropDownList>
</br>
</br>
<asp:Button id="btnDelete" class="btn btn-danger" runat="server" Text="Supprimer la catégorie" />
</br>
</br>
<asp:Label ID="lbDelete" runat="server" style="color:Red" > </asp:Label>
</br>
</br>

</fieldset>
</center>
</asp:Content>
