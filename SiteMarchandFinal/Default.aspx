<%@ Page Title="Page d'accueil" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="SiteMarchandFinal._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <div class="container">
        <div class="hero-unit">
            <h1> Vente d'équipements de tennis</h1>
            <p> Nous vendons toutes sortes d'équipements de tennis a prix cassés.</p>
     
            <asp:Label ID="contentMenu" runat="server"></asp:Label>
        </div>
    </div>

    <hr style="color:#f18423; width:50%; margin-left:240px;"/>

    <div class="row">
        <div class="span4">
            <h2>Nos services</h2>
            <br />
            <p> Nous proposons la vente d'équipements de tennis depuis plus de 10 ans. Profitez de notre expérience et de notre savoir faire. Bénéficiez de prix réduits et attractifs tout au long de l'année.</p>
        </div>

        <div class="span4">
            <h2>Livraison</h2>
            <br />
            <p> Pour toute commande nous vous garantissons la livraison sous 5 jours si le produit est toutefois en stock au moment de l'achat. Pour tous les produits achetés la livraison reste gratuite.</p>
        </div>

        <div class="span4">
            <h2>Qualité</h2>
            <br />
            <p> Tous les produits vendus par notre site sont de qualités et nous proposons a tous nos clients une extension de garanties de 2 ans gratuitement pour tous les produits présents sur le site.</p>
        </div>

    </div>
</asp:Content>
