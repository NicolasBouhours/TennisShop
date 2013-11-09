Public Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        prManager = New ProductManager
        dbHelper = New DatabaseHelper
        Dim menuItemContact As New MenuItem
        Dim menuItemAPropos As New MenuItem

        prManager.GetProducts()
        Session.Item("connect") = 0

        For Each cat As Categorie In prManager.ListCat
            Dim menuItem As New MenuItem
            menuItem.NavigateUrl = "~/pageproduits.aspx" & "?cat=" & cat.LibCat
            menuItem.Text = cat.LibCat
            NavigationMenu.Items.Add(menuItem)
        Next

        menuItemContact.NavigateUrl = "~/nouscontacter.aspx"
        menuItemContact.Text = "Nous contacter"
        menuItemAPropos.NavigateUrl = "~/apropos.aspx"
        menuItemAPropos.Text = "A propos"
        NavigationMenu.Items.Add(menuItemContact)
        NavigationMenu.Items.Add(menuItemAPropos)
    End Sub

    Private Sub siconnect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles siconnect.Load
        If Session.Item("SiConnect") = 1 Then
            siconnect.Visible = False
            siDisconnect.Visible = True
            HelloUser.Text = "Bonjour " & Session.Item("Loginpers")
            HelloUser.Visible = True
            register.Visible = False
            panierUser.Visible = True
        End If

    End Sub

    Private Sub headlog_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles headlog.ServerClick
        Session.Item("SiConnect") = 0
        siconnect.Visible = True
        register.Visible = True
        siDisconnect.Visible = False
        HelloUser.Visible = False
        panierUser.Visible = False

    End Sub
End Class