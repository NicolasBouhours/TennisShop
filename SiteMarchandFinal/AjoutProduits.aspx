<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="AjoutProduits.aspx.vb" Inherits="SiteMarchandFinal.AjoutProduits" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<center>

<h2> Ajout d'un produit </h2> </br> </br>
     <asp:Label ID="lbError" runat="server" style="color:Red"></asp:Label> </br>
<fieldset class="ajoutInfoCat">
<legend>Catégorie du produit</legend> </br>

<label id="chooseCat" runat="server"> Veuillez choisir la catégorie :</label> 
<asp:DropDownList ID="dropdownlist" runat="server"></asp:DropDownList> </br> </br>
</fieldset>

<fieldset class="ajoutInfo">
<legend>Informations sur le produit</legend> </br>

<asp:Label id="pLib" runat="server" AssociatedControlID="ProduitLib">Nom du produit :</asp:Label> 
<asp:TextBox ID="ProduitLib" runat="server"></asp:TextBox> </br> </br>

<asp:Label id="mProd" runat="server" AssociatedControlID="MarqueProd">Marque du produit :</asp:Label> 
<asp:TextBox ID="MarqueProd" runat="server"></asp:TextBox> </br> </br>

<asp:Label id="pProd" runat="server" AssociatedControlID="PrixProd">Prix du produit :</asp:Label> 
<asp:TextBox ID="PrixProd" runat="server"></asp:TextBox> </br> </br>

<asp:Label id="dProd" runat="server" AssociatedControlID="DescrProd">Description du produit :</asp:Label> 
    </br>  
<asp:TextBox ID="DescrProd" runat="server" Height="93px" TextMode="MultiLine" 
        Width="450px"></asp:TextBox> </br></br>

<asp:Label id="dtProd" runat="server" AssociatedControlID="DescrTechProd">Description technique du produit :</asp:Label> 
    </br>  
<asp:TextBox lenght="400" ID="DescrTechProd" runat="server" Height="146px" 
        style="margin-top: 1px" TextMode="MultiLine" Width="523px"></asp:TextBox> </br> </br>
         <asp:Label ID="sendImage" runat="server" AssociatedControlID="fileUpload">Ajouter une image</asp:Label>
         <asp:FileUpload id="fileUpload" runat="server"/>
         </br></br>
        <asp:Button ID="addProduct" runat="server" class="btn btn-danger" Text="Ajouter le produit" />

</fieldset>
</center>
</asp:Content>
