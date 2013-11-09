<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="derniereCommandeAdmin.aspx.vb" Inherits="SiteMarchandFinal.derniereCommandeAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <h2> Liste des dernières commandes</h2> <br /> <br />
    <table class="table">
        <thead>
            <tr>
                <th>Id Commande</th>
                <th>Numero client</th>
                <th>Date commande</th>
                <th>Montant total</th>
                <th>Statut commande</th>
                <th> </th>
                <th> </th>
            </tr>
        </thead>
        <tbody>
            <asp:Label ID="contenTab" runat="server"></asp:Label>
        </tbody>
    </table>
</asp:Content>
