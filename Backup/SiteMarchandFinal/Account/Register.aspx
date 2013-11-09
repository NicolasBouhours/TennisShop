<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Register.aspx.vb" Inherits="SiteMarchandFinal.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<center>
<h2>Bienvenue dans le formulaire de connexion</h2> 
<fieldset class="infoUser">

<legend> Information utilisateur</legend>
</br> 
<asp:Label id="usernameLabel" runat="server" AssociatedControlID="userName">Nom de compte :</asp:Label>
<asp:TextBox id="userName" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="emailLabel" runat="server" AssociatedControlID="emailUser">E-mail :</asp:Label>
<asp:TextBox id="emailUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="prenomLabel" runat="server" AssociatedControlID="prenomUser">Prénom :</asp:Label>
<asp:TextBox id="prenomUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="nomLabel" runat="server" AssociatedControlID="nomUser">Nom :</asp:Label>
<asp:TextBox id="nomUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="adressLabel" runat="server" AssociatedControlID="adressUser">Adresse :</asp:Label>
<asp:TextBox id="adressUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="villeLabel" runat="server" AssociatedControlID="villeUser">Ville :</asp:Label>
<asp:TextBox id="villeUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="cpLabel" runat="server" AssociatedControlID="cpUser">Code postal :</asp:Label>
<asp:TextBox id="cpUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="pwLabel" runat="server" AssociatedControlID="pwUser">Mot de passe :</asp:Label>
<asp:TextBox id="pwUser" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="pw2Label" runat="server" AssociatedControlID="pwUser2">Ressaisissez votre mot de passe :</asp:Label>
<asp:TextBox id="pwUser2" runat="server"></asp:TextBox>
</br> </br>

<asp:Label id="lbError" runat="server" style="color:red"></asp:Label>

</br> </br>
<asp:Button id="btnEnvoie" runat="server" Text="Créer le compte" />
</br>
</fieldset>
</center>
</asp:Content>


