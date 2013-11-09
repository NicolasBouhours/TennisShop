Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub titreCad_Load(sender As Object, e As EventArgs) Handles titreCad.Load
        titreCad.Text = " <h2> Liste des " & Request("cat") & " </h2>"
    End Sub


    Private Sub listeProd_Load(sender As Object, e As EventArgs) Handles listeProd.Load
        Dim idcat As String = ""
        For Each Cat As Categorie In prManager.ListCat
            If Cat.LibCat = Request("cat") Then
                idcat = Cat.IdCat
            End If
        Next

        For Each pr As Product In prManager.ListProd
            If pr.ProdIdCat = idcat Then
                listeProd.Text = listeProd.Text & "<div class= " & Chr(34) & "blocprod" & Chr(34) & " style='float:left;border-style:solid; border-width:1px; width:200px; height:250px; margin-left:50px;margin-right:50px; margin-bottom:50px; font-family:Arial; background-color:#fff;text-align:center'> <img src='images/" & pr.ProdLib & ".jpg' alt='" & pr.ProdLib & "' height='150' width='150' />  </br> <b>" & " " & pr.ProdMarque & "</b> </br>" & pr.ProdLib & "</br> <span style='color:#f18423; height:20px;'> " & pr.ProdPrix & "€" & "</span> </br>" & "  <a href='voirproduit.aspx?prod=" & pr.ProdId & "'> Voir le produit </a>" & "</div>"
            End If
        Next
    End Sub
End Class