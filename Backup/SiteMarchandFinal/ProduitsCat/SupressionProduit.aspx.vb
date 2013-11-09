Public Class SupressionProduit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub dropdownlist_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles dropdownlist.Load
        If dropdownlist.Items.Count < prManager.ListCat.Count Then
            For Each cat As Categorie In prManager.ListCat
                dropdownlist.Items.Add(cat.LibCat)
            Next
        End If
    End Sub

    Private Sub dropDownSup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles dropDownSup.Load

    End Sub

    Private Sub btnSupProd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSupProd.Click
        Dim query As String = "DELETE FROM PRODUCTS WHERE PROD_LIB ='" & dropDownSup.SelectedItem.Text & "'"

        dbHelper.ExecuteSQLQuery(query)

        lbError.Text = "Le produit a été supprimé avec succès."

        Response.Redirect("~/ProduitsCat/SupressionProduit.aspx")

    End Sub

    Private Sub triList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles triList.Click

        Dim varId As String = ""

        dropDownSup.Items.Clear()

        For Each cat As Categorie In prManager.ListCat
            If dropdownlist.SelectedItem.Text.Equals(cat.LibCat) Then
                varId = cat.IdCat
            End If
        Next

        If dropDownSup.Items.Count < prManager.ListProd.Count Then
            For Each prod As Product In prManager.ListProd
                If prod.ProdIdCat = varId Then
                    dropDownSup.Items.Add(prod.ProdLib)
                End If
            Next
        End If

    End Sub
End Class