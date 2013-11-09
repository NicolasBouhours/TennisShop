Public Class derniereCommandeAdmin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("admin") = 0 Then
            Response.Redirect("Default.aspx")
        End If

    End Sub

    Private Sub contenTab_Load(sender As Object, e As EventArgs) Handles contenTab.Load
        Dim listCommande As New List(Of Commands)
        listCommande = prManager.getListCommandAdmin(Session.Item("Loginpers"))

        For Each com As Commands In listCommande
            contenTab.Text = contenTab.Text & "<tr>"
            contenTab.Text = contenTab.Text & "<td> #" & com.NumCommande & "</td>"
            contenTab.Text = contenTab.Text & "<td>" & com.UserLogin & "</td>"
            contenTab.Text = contenTab.Text & "<td> " & com.DateCommande & "</td>"
            contenTab.Text = contenTab.Text & "<td> " & com.MntCommande & "</td>"
            contenTab.Text = contenTab.Text & "<td><i> " & com.StatutLib & "</i></td>"
            contenTab.Text = contenTab.Text & "<td> <a href='detailcommande.aspx?com=" & com.NumCommande & "'> voir le détail </a>"
            contenTab.Text = contenTab.Text & "<td> <a href='modifierstatut.aspx?com=" & com.NumCommande & "' >Modifier le statut </a>"
            contenTab.Text = contenTab.Text & "</tr>"
        Next

    End Sub

End Class