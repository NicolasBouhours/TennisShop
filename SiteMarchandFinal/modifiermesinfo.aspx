<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="modifiermesinfo.aspx.vb" Inherits="SiteMarchandFinal.modifiermesinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <center>
<h2>Modifier mes informations</h2>  <br /> <br />
<fieldset class="infoUser">

<legend style="color:#CCC4C7;font-size:20px;"> Information actuelles</legend>
</br> 

<asp:Label id="emailLabel" runat="server" AssociatedControlID="tbemailUser" style="color:#CCC4C7;display:inline-block;">E-mail :</asp:Label>
<asp:TextBox id="tbemailUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="prenomLabel" runat="server" AssociatedControlID="tbprenomUser" style="color:#CCC4C7;display:inline-block;">Prénom :</asp:Label>
<asp:TextBox id="tbprenomUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="nomLabel" runat="server" AssociatedControlID="tbnomUser" style="color:#CCC4C7;display:inline-block;">Nom :</asp:Label>
<asp:TextBox id="tbnomUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="adressLabel" runat="server" AssociatedControlID="tbadressUser" style="color:#CCC4C7;display:inline-block;">Adresse :</asp:Label>
<asp:TextBox id="tbadressUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="villeLabel" runat="server" AssociatedControlID="tbvilleUser" style="color:#CCC4C7;display:inline-block;">Ville :</asp:Label>
<asp:TextBox id="tbvilleUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="cpLabel" runat="server" AssociatedControlID="tbcpUser" style="color:#CCC4C7;display:inline-block;">Code postal :</asp:Label>
<asp:TextBox id="tbcpUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="pwLabel" runat="server" AssociatedControlID="tbpwUser" style="color:#CCC4C7;display:inline-block;">Nouveau Mot de passe (facultatif):</asp:Label>
<asp:TextBox id="tbpwUser" runat="server" TextMode="Password"></asp:TextBox>
</br> </br>

<asp:Label id="pw2Label" runat="server" AssociatedControlID="tbpwUser2" style="color:#CCC4C7;display:inline-block;">Ressaisissez votre mot de passe (facultatif) :</asp:Label>
<asp:TextBox id="tbpwUser2" runat="server" TextMode="Password"></asp:TextBox>
</br> </br>

<asp:Label id="lbError" runat="server" style="color:#f18423"></asp:Label>

</br> </br>
<asp:Button class="btn btn-primary" id="btnModify" runat="server" Text="Modifier mes informations" />
</br>
</fieldset>
</center>

</asp:Content>
