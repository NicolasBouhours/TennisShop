Public Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        prManager = New ProductManager
        dbHelper = New DatabaseHelper
        msgManager = New messageManager
        acManager = New AccountManager

        Dim menuItemContact As New MenuItem
        Dim menuItemAPropos As New MenuItem

        msgManager.getAllMessage()
        prManager.GetProducts()
        Session.Item("connect") = 0

        ' CHARGEMENT DU MENU DEROULANT
        For Each cat As Categorie In prManager.ListCat
            Dim menuItem As New MenuItem
            menuItem.NavigateUrl = "~/pageproduits.aspx" & "?cat=" & cat.LibCat
            menuItem.Text = cat.LibCat
            NavigationMenu.Items.Add(menuItem)
        Next

        menuItemContact.NavigateUrl = "~/nouscontacter.aspx"
        menuItemContact.Text = " <i class='icon-envelope'> </i> Nous contacter"
        NavigationMenu.Items.Add(menuItemContact)

        ' CHARGEMENT DU MENU POUR ADMIN
        If Session.Item("admin") = 1 Then
            menuAdmin.Visible = True
        End If
    End Sub

    Private Sub siconnect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles siconnect.Load
        If Session.Item("SiConnect") = 1 Then
            siconnect.Visible = False
            HelloUser.Visible = True
            HelloUser.Text = " " & "<i class='icon-user'></i>" & " Bonjour " & Session.Item("Loginpers")
            A3.Visible = True
            A4.Visible = True
            monCompte.Visible = True
        End If

    End Sub



    Private Sub A3_ServerClick(sender As Object, e As EventArgs) Handles A3.ServerClick
        Session.Abandon()
        siconnect.Visible = True
        A3.Visible = False
        A4.Visible = False
        monCompte.Visible = False
        HelloUser.Visible = False
        Response.Redirect("Default.aspx")

    End Sub

    Private Sub listCat_Load(sender As Object, e As EventArgs) Handles listCat.Load
        For Each cat As Categorie In prManager.ListCat
            listCat.Text = listCat.Text & "<li>" & cat.LibCat & "</li>"
        Next
    End Sub
End Class