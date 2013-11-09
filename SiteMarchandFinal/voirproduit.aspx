<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="voirproduit.aspx.vb" Inherits="SiteMarchandFinal.voirproduit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

 <div id="infoProduct" style="font-size:18px; font-family:'Trebuchet MS'; letter-spacing:-0.05em;">
    <asp:Label ID="validPanier" runat="server" style="color:#f18423;"></asp:Label>
     
      <div class="titreProduit">
         <asp:Label ID="titreProduit" runat="server"></asp:Label>
     </div>
     <div class="photoProduit" style="display:inline-block; width:400px; margin-top:40px;">
         <asp:Label ID="photoProduit" runat="server" style="display:inline-block;"></asp:Label>
     </div>
     <div class="nicoLa" style="float:right;">
     <div class="prixProduit" style="width:400px;">
         <asp:Label ID="prixProduit" runat="server" style="font-size:25px; color:#CCC4C7"></asp:Label> </br>
       <span style="color:#CCC4C7">Quantité :</span>  <asp:TextBox ID="prixProdTB" runat="server" style="width:50px;"></asp:TextBox> <asp:Button class="btn btn-danger" ID="btnProd" runat="server" Text="Ajouter au panier" style="margin-bottom:10px;" />
     </div> <br/>
     <div class="descrProduit" style="width:400px;">
         <asp:Label ID="descrProduit" runat="server"></asp:Label>
     </div>
     </div>
     <div class="descrTechProduit" style="text-align:center;">
         <asp:Label ID="descrTechProduit" runat="server"></asp:Label>
     </div>

 </div>
</asp:Content>
