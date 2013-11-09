<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="SiteMarchandFinal.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<center>

<h2>Bienvenue dans le formulaire de connexion</h2> </br> </br> 

<h3> Pas encore de compte ?<a href="Register.aspx">   Créez en un !</a> </h3> </br> </br>
 <form class="form-horizontal"> 
<fieldset class="connectUser">
<legend style="color:#f18423;font-size:20px;">Connexion</legend> </br>
<asp:Label id="usernameLabel" runat="server" AssociatedControlID="userName" style="color:#CCC4C7;display:inline-block;">Nom de compte :</asp:Label>
<asp:TextBox id="userName" runat="server"></asp:TextBox> </br> </br> 
<asp:Label id="passwordNamelabel" runat="server" AssociatedControlID="userPaassword" style="color:#CCC4C7;display:inline-block;" > Mot de passe :</asp:Label>
<asp:TextBox id="userPaassword" runat="server" TextMode="Password" ></asp:TextBox> </br> </br> 
   
 <asp:Label id="lbError" runat="server" style="color:#f18423"> </asp:Label> </br> </br> 
<asp:Button class="btn btn-primary" id="btnSubmit" runat="server" Text="Se connecter" />
 
</fieldset>
    </form>
</center>
</asp:Content>

