<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="SiteMarchandFinal.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<center>

<h2>Bienvenue dans le formulaire de connexion</h2> 
</br> </br> 

<h3> Pas encore de compte ?<a href="Register.aspx" style="color:#666666">Créez en un !</a> </h3>
</br> </br>
<fieldset class="connectUser">
<legend>Connexion</legend>

<asp:Label id="usernameLabel" runat="server" AssociatedControlID="userName">Nom de compte :</asp:Label>
<asp:TextBox id="userName" runat="server"></asp:TextBox>
</br> </br> 
<asp:Label id="passwordNamelabel" runat="server" AssociatedControlID="userPaassword"> Mot de passe :</asp:Label>
<asp:TextBox id="userPaassword" runat="server"></asp:TextBox>
 </br> </br> 

 <asp:Label id="lbError" runat="server" style="color:Red"> </asp:Label>

  </br> </br> 
<asp:Button id="btnSubmit" runat="server" Text="Se connecter" />

</fieldset>
</center>
</asp:Content>

