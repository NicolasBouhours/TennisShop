<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="nouscontacter.aspx.vb" Inherits="SiteMarchandFinal.nouscontacter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2> Nous contacter</h2><br /> 
    <center>
    <asp:Label ID="infoMsg" runat="server" style="color:red"></asp:Label>
    <br />

        <asp:label id="nomLb" AssociatedControlID="tbNom">Nom :</asp:label> <asp:TextBox ID="TbNom" runat="server" ></asp:TextBox> <br /><br />
        <asp:label id="preLb" AssociatedControlID="tbPre">Prénom :</asp:label> <asp:TextBox ID="tbPre" runat="server" ></asp:TextBox><br /><br />
        <asp:label id="adresseMailLb" AssociatedControlID="tbLMail">Adresse e-mail :</asp:label> <asp:TextBox ID="tbMail" runat="server"></asp:TextBox> <br /><br />
                <asp:label id="titreLb" AssociatedControlID="tbTitre">Titre de votre message :</asp:label> <asp:TextBox ID="tbTitre" runat="server"></asp:TextBox> <br /><br />
        <asp:Label ID="contentLb" AssociatedControlID="tbContent"> Contenu de votre message :</asp:Label> <br /> <asp:TextBox ID="tbContent" runat="server" Width="500px" Height="200px" TextMode="MultiLine"></asp:TextBox><br />
        <asp:Button id="btnSend" runat="server" class="btn btn-primary" Text="Envoyer"/>

   </center>
</asp:Content>
