<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="listmessage.aspx.vb" Inherits="SiteMarchandFinal.listmessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Liste des messages</h4> <br /> <br />

    <table class="table">
        <thead>
            <tr>
                <th>Date</th>
                <th>Auteur</th>
                <th>E-mail</th>
                <th>Sujet</th>
                <th>Statut</th>
                <th>       </th>

            </tr>
        </thead>
        <tbody>
            <asp:Label ID="tableContent" runat="server"></asp:Label>
        </tbody>
    </table>

</asp:Content>
