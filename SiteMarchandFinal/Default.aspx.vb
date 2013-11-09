Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub contentMenu_Load(sender As Object, e As EventArgs) Handles contentMenu.Load
        For Each cat As Categorie In prManager.ListCat
            contentMenu.Text = contentMenu.Text & " <a class='btn btn-large btn-primary' style='margin-left:40px; margin-top:20px;' id='" & cat.LibCat & "' href='pageproduits.aspx?cat=" & cat.LibCat & "'>" & cat.LibCat & "</a>"
        Next
    End Sub
End Class