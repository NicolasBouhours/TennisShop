<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="derniereCommande.aspx.vb" Inherits="SiteMarchandFinal.derniereCommande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="display:inline;margin-right:200px;">Aperçu de mon compte</h2> <a class="btn btn-danger" href="modifiermesinfo.aspx">Modifier mes informations personnelles</a>  <br /> <br />
    <table class="table">
        <thead>
            <tr>
                <th>Id Commande</th>
                <th>Date commande</th>
                <th>Montant total</th>
                <th>Statut commande</th>
                <th> </th>
            </tr>
        </thead>
        <tbody>
            <asp:Label ID="contenTab" runat="server"></asp:Label>
        </tbody>
    </table>
</asp:Content>
