Public Class modifierStatut
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session.Item("admin") = 0 Then
            Response.Redirect("Default.aspx")
        End If

    End Sub

    Private Sub statutLib_Load(sender As Object, e As EventArgs) Handles statutLib.Load
        statutLib.Text = prManager.getStatut(Request("COM"))

    End Sub

    Private Sub dropdowlist_Load(sender As Object, e As EventArgs) Handles dropdowlist.Load
        Dim listLib As New List(Of String)

        listLib = prManager.getAllLibStatut()
        For Each libelle As String In listLib
            dropdowlist.Items.Add(libelle)
        Next
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim idStatut As Integer = 0
        idStatut = prManager.getIdStatut(dropdowlist.SelectedItem.Text)

        prManager.updateLib(Request("com"), idStatut)

        Response.Redirect("derniereCommandeAdmin.aspx")
    End Sub
End Class