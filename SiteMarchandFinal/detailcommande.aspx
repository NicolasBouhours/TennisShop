<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="detailcommande.aspx.vb" Inherits="SiteMarchandFinal.detailcommande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3><asp:Label ID="titrePage" runat="server"></asp:Label> </h3> <br /> <br />

    <table class="table">
        <thead>
            <tr>
                <th>Numéro de la commande</th>
                <th>Libellé du produit</th>
                <th>Photo du produit</th>
                <th>Quantité</th>
                <th>Prix du produit</th>
            </tr>
        </thead>
        <tbody>
            <asp:Label id="tabContent" runat="server"></asp:Label>
        </tbody>
    </table> 
    
    <div class="row">
        <div class="span4">
           <asp:Label id="nomPers" runat="server"></asp:Label>
            <asp:Label ID="adrPers" runat="server"></asp:Label>
        </div>
        <div class="span4"></div>
        <div class="span4">
            <h4> <asp:Label ID="lbprixHorsLivraison" runat="server"></asp:Label></h4>
            <h4> <asp:Label ID="lbPrixLivraison" runat="server"></asp:Label></h4>
            <h4> <asp:Label ID="lbPrixTotal" runat="server"></asp:Label></h4>
        </div>
    </div>



</asp:Content>
