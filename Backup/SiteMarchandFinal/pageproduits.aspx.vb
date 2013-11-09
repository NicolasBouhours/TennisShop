Public Class pageproduits
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub titre_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles titre.Load
        Dim varTitre As String = Request("cat")
        titre.Text = "<h2> Liste des " & varTitre & " </h2>"
    End Sub

    Private Sub contenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles contenu.Load
        ' on recupère l'id de la catégorie
        Dim catIid As String = ""
        Dim i As Integer
        For Each cat As Categorie In prManager.ListCat
            If cat.LibCat = Request("cat") Then
                catIid = cat.IdCat
            End If
        Next
        ' on affiche les produits ayant la catégorie de la page
        For Each pr As Product In prManager.ListProd
            If pr.ProdIdCat = catIid Then
                contenu.Text = contenu.Text & "<div class= " & Chr(34) & "blocprod" & Chr(34) & " style='float:left; border-style:solid; border-width:1px; width:200px; height:250px; margin-right:100px; margin-bottom:50px; font-weight:bold;'> <img src='images/YouTek Graphene Speed S.jpg' alt='Photo de montagne' height='150' width='150' />  </br>" & " " & pr.ProdMarque & " </br>" & pr.ProdLib & "</br> " & pr.ProdPrix & "€" & "</br>" & " </br> <a href='salut.html'> Voir le produit </a>" & "</div>"
                '  If i Mod 3 = 0 Then
                '  contenu.Text = contenu.Text & "style:"
                'End If

            End If

        Next
    End Sub
End Class