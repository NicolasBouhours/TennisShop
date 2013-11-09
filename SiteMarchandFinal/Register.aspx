<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Register.aspx.vb" Inherits="SiteMarchandFinal.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<center>
<h2>Enregistrer un compte</h2>  <br /> <br />
<fieldset class="infoUser">

<legend style="color:#CCC4C7;font-size:20px;"> Information utilisateur</legend>
</br> 
<asp:Label id="usernameLabel" runat="server" AssociatedControlID="userName" style="color:#CCC4C7;display:inline-block;">Nom de compte :</asp:Label>
<asp:TextBox id="userName" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="emailLabel" runat="server" AssociatedControlID="emailUser" style="color:#CCC4C7;display:inline-block;">E-mail :</asp:Label>
<asp:TextBox id="emailUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="prenomLabel" runat="server" AssociatedControlID="prenomUser" style="color:#CCC4C7;display:inline-block;">Prénom :</asp:Label>
<asp:TextBox id="prenomUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="nomLabel" runat="server" AssociatedControlID="nomUser" style="color:#CCC4C7;display:inline-block;">Nom :</asp:Label>
<asp:TextBox id="nomUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="adressLabel" runat="server" AssociatedControlID="adressUser" style="color:#CCC4C7;display:inline-block;">Adresse :</asp:Label>
<asp:TextBox id="adressUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="villeLabel" runat="server" AssociatedControlID="villeUser" style="color:#CCC4C7;display:inline-block;">Ville :</asp:Label>
<asp:TextBox id="villeUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="cpLabel" runat="server" AssociatedControlID="cpUser" style="color:#CCC4C7;display:inline-block;">Code postal :</asp:Label>
<asp:TextBox id="cpUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="pwLabel" runat="server" AssociatedControlID="pwUser" style="color:#CCC4C7;display:inline-block;">Mot de passe :</asp:Label>
<asp:TextBox id="pwUser" runat="server" TextMode="Password"></asp:TextBox>
</br> </br>

<asp:Label id="pw2Label" runat="server" AssociatedControlID="pwUser2" style="color:#CCC4C7;display:inline-block;">Ressaisissez votre mot de passe :</asp:Label>
<asp:TextBox id="pwUser2" runat="server" TextMode="Password"></asp:TextBox>
</br> </br>

<asp:Label id="lbError" runat="server" style="color:#f18423"></asp:Label>

</br> </br>
<asp:Button class="btn btn-primary" id="btnEnvoie" runat="server" Text="Créer le compte" />
</br>
</fieldset>
</center>
</asp:Content>


