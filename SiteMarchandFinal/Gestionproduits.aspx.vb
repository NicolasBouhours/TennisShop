Public Class Gestionproduits
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("admin") = 0 Then
            Response.Redirect("default.aspx")
        End If
    End Sub



    Private Sub btnVoirList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVoirList.Click
        listProduits.Text = ""
        Dim varId As String = ""
        listProduits.Text = "<ul>"
        For Each cat As Categorie In prManager.ListCat
            If dropdownlist.SelectedItem.Text.Equals(cat.LibCat) Then
                varId = cat.IdCat
            End If
        Next
        For Each produit As Product In prManager.ListProd
            If produit.ProdIdCat = varId Then
                listProduits.Text = listProduits.Text & "<li>" & produit.ProdMarque & "   " & produit.ProdLib & "</li>"
            End If
        Next
        listProduits.Text = listProduits.Text & "</li>"
    End Sub

    Private Sub dropdownlist_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles dropdownlist.Load
        If dropdownlist.Items.Count < prManager.ListCat.Count Then
            For Each cat As Categorie In prManager.ListCat
                dropdownlist.Items.Add(cat.LibCat)
            Next
        End If

    End Sub
End Class