<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="panier.aspx.vb" Inherits="SiteMarchandFinal.panier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2> Mon panier </h2>
    <br />
    <br />
    <asp:label id="tabPanier" runat="server" visible="true">
    <table class="table">
        <thead>
            <tr>
                <th> Id </th>
                <th>Marque</th>
                <th>Libellé</th>
                <th>Prix</th>
                <th>Quantitée</th>
                <th>  </th>
            </tr>
        </thead>
        <tbody>
            <asp:Label ID="tabContent" runat="server"> </asp:Label>

        </tbody>
    </table>
    </asp:label>
    <asp:Label ID="prixhorsLivraison" runat="server"><h4>Prix Hors livraison TTC : <asp:Label ID="prixPayer" runat="server"></asp:Label> € </h4> </asp:Label>
    <asp:Label ID="lbprixLivraison" runat="server"> <h4>Frais de livraison ( Gratuit si plus de 80e ) :  <asp:label id="fraisLivraisons" runat="server"></asp:label> € </h4> </asp:Label>
   <asp:Label ID="prixttxvi" runat="server"><h4>Prix total TTC : <asp:Label ID="prixTotal" runat="server"></asp:Label></h4> </asp:Label> <br /> 
    <asp:Button id="validCommand" runat="server" class="btn btn-primary" Text="Valider la commande" style="float:right;margin-right: 100px;"/>
   <center> <h2 style="color:#333333"> <asp:Label id="sipaniervide" runat="server" Visible="false"></asp:Label></h2></center>

</asp:Content>
