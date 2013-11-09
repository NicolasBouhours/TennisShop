Public Class Createcategories
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub BtnAddCat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAddCat.Click
        Dim cat As Categorie

        cat = New Categorie(NomCat.Text)

        If prManager.checkExistCategorie(cat) = True Then

            prManager.AddCategorie(cat)
            LbInfo.Text = "Votre catégorie a été ajoutée avec succès."

        Else
            LbInfo.Text = "Vous avez déja une catégorie ayant ce nom"

        End If

        Response.Redirect("~/ProduitsCat/Createcategories.aspx")

    End Sub

    Private Sub ListCat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListCat.Load
        ListCat.Text = "<ul>"
        For Each cat As Categorie In prManager.ListCat
            ListCat.Text = ListCat.Text & "<li> " & cat.LibCat & "</>"
        Next
        ListCat.Text = ListCat.Text & " </ul>"
    End Sub

    Private Sub dropdownlist_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles dropdownlist.Load
        For Each cat As Categorie In prManager.ListCat
            dropdownlist.Items.Add(cat.LibCat)
        Next
    End Sub



    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim cat As Categorie

        cat = New Categorie(dropdownlist.SelectedItem.Text)
        prManager.DeleteCategorie(cat)
        lbDelete.Text = "Votre catégorie a été supprimé avec succès."

        Response.Redirect("~/ProduitsCat/Createcategories.aspx")

    End Sub
End Class