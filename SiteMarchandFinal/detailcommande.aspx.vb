Public Class detailcommande
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("SiConnect") = 0 Then
            Response.Redirect("default.aspx")
        End If
    End Sub

    Private Sub titrePage_Load(sender As Object, e As EventArgs) Handles titrePage.Load
        titrePage.Text = " Detail de la commande #" & Request("com")
    End Sub


    Private Sub tabContent_Load(sender As Object, e As EventArgs) Handles tabContent.Load
        Dim listProdCom As New List(Of ProdCommand)
        listProdCom = prManager.getListProdCommand(Request("com"))
        Dim prix As Double
        Dim prixTotal As Double = 0
        Dim prixLivraison As Double = 0

        For Each pr As ProdCommand In listProdCom
            Double.TryParse(pr.ProdPrix, prix)
            prixTotal = prixTotal + prix
            tabContent.Text = tabContent.Text & "<tr>"
            tabContent.Text = tabContent.Text & "<td> #" & pr.NumCommande & "</td>"
            tabContent.Text = tabContent.Text & "<td>" & pr.ProdLib & "</td>"
            tabContent.Text = tabContent.Text & "<td> <img src='images/" & pr.ProdLib & ".jpg' alt='" & pr.ProdLib & "' height='70px' width='70px'/> </td>"
            tabContent.Text = tabContent.Text & "<td>" & pr.Qte & "</td>"
            tabContent.Text = tabContent.Text & "<td>" & pr.ProdPrix & " €" & "</td>"
            tabContent.Text = tabContent.Text & "</tr>"

        Next

        lbprixHorsLivraison.Text = " Prix hors frais de port : " & prixTotal & " €"

        If prixTotal > 80 Then
            lbPrixLivraison.Text = " Prix de la livraison : 0,00€"
        Else
            lbPrixLivraison.Text = " Prix de la livraison : 7,80€"
            prixLivraison = 7.8
        End If

        lbPrixTotal.Text = " Prix total : " & (prixTotal + prixLivraison) & " €"

    End Sub

    Private Sub nomPers_Load(sender As Object, e As EventArgs) Handles nomPers.Load
        If Session.Item("admin") = 1 Then

            Dim user As New Users
            Dim loginUser As String

            loginUser = prManager.getLoginUsers(Request("com"))
            user = prManager.getInfoUsers(loginUser)
            nomPers.Text = "<h4>A envoyer a : </h4>" & user.PrenomUser & " " & user.NomUser

        End If
    End Sub

    Private Sub adrPers_Load(sender As Object, e As EventArgs) Handles adrPers.Load
        If Session.Item("admin") = 1 Then

            Dim user As New Users
            Dim loginUser As String

            loginUser = prManager.getLoginUsers(Request("com"))
            user = prManager.getInfoUsers(loginUser)
            adrPers.Text = "<h4> A l'adresse : </h4>" & user.AdrUser & " </br>" & user.CpUser & "  " & user.VilleUser

        End If
    End Sub
End Class