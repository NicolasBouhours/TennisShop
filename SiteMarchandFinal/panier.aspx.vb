Public Class panier
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim listPa As New List(Of panierProd)
        listPa = Session.Item("Panier")
        If listPa.Count = 0 Then
            sipaniervide.Visible = True
            prixPayer.Visible = False
            prixTotal.Visible = False
            fraisLivraisons.Visible = False
            tabPanier.Visible = False
            prixhorsLivraison.Visible = False
            prixttxvi.Visible = False
            lbprixLivraison.Visible = False
            validCommand.Visible = False
            sipaniervide.Text = " Vous n'avez rien dans votre panier"
        End If
    End Sub

    Private Sub tabContent_Load(sender As Object, e As EventArgs) Handles tabContent.Load
        Dim listPa As New List(Of panierProd)
        listPa = Session.Item("Panier")
            For Each panier As panierProd In listPa
                tabContent.Text = tabContent.Text & "<tr>"
            tabContent.Text = tabContent.Text & "<td>" & panier.ProdId & "</td> <td> " & panier.ProdMarque & "</td> <td> " & panier.ProdLib & "</td> <td> " & panier.ProdPrix & "</td> <td>" & panier.Qte & "</td>" & "<td> " & "<a  class='btn btn-danger' href='suprPanier.aspx?prodid=" & panier.ProdId & "'> Supprimer le produit </a>"
                tabContent.Text = tabContent.Text & "</tr>"
        Next

       
    End Sub


    Private Sub prixPayer_Load(sender As Object, e As EventArgs) Handles prixPayer.Load
        Dim listPa As New List(Of panierProd)
        Dim prixPayerr As Double = 0
        Dim prixTemp As Double
        listPa = Session.Item("Panier")
        If listPa.Count <> 0 Then
            For Each panier As panierProd In listPa
                Double.TryParse(panier.ProdPrix, prixTemp)
                If panier.Qte > 1 Then
                    prixPayerr = prixPayerr + (prixTemp * panier.Qte)
                Else
                    prixPayerr = prixPayerr + prixTemp
                End If
            Next
            prixPayer.Text = prixPayerr
        End If
    End Sub


    Private Sub fraisLivraisons_Load(sender As Object, e As EventArgs) Handles fraisLivraisons.Load
        Dim prix As Double
        Double.TryParse(prixPayer.Text, prix)
        If prix > 80 Then
            fraisLivraisons.Text = "0,00 "
        Else
            fraisLivraisons.Text = "7,80"
        End If
    End Sub


    Private Sub prixTotal_Load(sender As Object, e As EventArgs) Handles prixTotal.Load
        Dim prixt As Double
        Dim prixl As Double

        Double.TryParse(fraisLivraisons.Text, prixl)
        Double.TryParse(prixPayer.Text, prixt)

        prixTotal.Text = prixt + prixl & " € "
    End Sub

    Private Sub validCommand_Click(sender As Object, e As EventArgs) Handles validCommand.Click
        Dim listPa As New List(Of panierProd)
        Dim idCommand As Integer
        listPa = Session.Item("Panier")
        idCommand = prManager.ajoutCommande(prixTotal.Text, Session.Item("Loginpers"))
        For Each panier As panierProd In listPa
            prManager.ajoutCommandeProd(panier, idCommand, panier.Qte, Session.Item("Loginpers"))
        Next
        Session.Item("panier") = New List(Of panierProd)
        Response.Redirect("derniereCommande.aspx")

    End Sub
End Class