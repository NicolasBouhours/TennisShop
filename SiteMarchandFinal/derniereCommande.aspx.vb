Public Class derniereCommande
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("SiConnect") = 0 Then
            Response.Redirect("default.aspx")
        End If
    End Sub


    Private Sub contenTab_Load(sender As Object, e As EventArgs) Handles contenTab.Load
        Dim listCommande As New List(Of Commands)
        listCommande = prManager.getListCommand(Session.Item("Loginpers"))

        For Each com As Commands In listCommande
            contenTab.Text = contenTab.Text & "<tr>"
            contenTab.Text = contenTab.Text & "<td> #" & com.NumCommande & "</td>"
            contenTab.Text = contenTab.Text & "<td> " & com.DateCommande & "</td>"
            contenTab.Text = contenTab.Text & "<td> " & com.MntCommande & "</td>"
            contenTab.Text = contenTab.Text & "<td> " & com.StatutLib & "</td>"
            contenTab.Text = contenTab.Text & "<td> <a href='detailcommande.aspx?com=" & com.NumCommande & "'> voir le détail </a>"
            contenTab.Text = contenTab.Text & "</tr>"
        Next

    End Sub

End Class