Public Class listmessage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session.Item("admin") = 0 Then
            Response.Redirect("default.aspx")
        End If

    End Sub


    Private Sub tableContent_Load(sender As Object, e As EventArgs) Handles tableContent.Load
        Dim statut As String
        For Each msg As Message In msgManager.ListMessage
            tableContent.Text = tableContent.Text & "<tr>"
            tableContent.Text = tableContent.Text & "<td>" & msg.DateMessage & "</td>"
            tableContent.Text = tableContent.Text & "<td>" & msg.PreMessage & " " & msg.NomMessage & "</td>"
            tableContent.Text = tableContent.Text & "<td>" & msg.MailMessage & "</td>"
            tableContent.Text = tableContent.Text & "<td>" & msg.TitreMessage & "</td>"
            If msg.VuMessage = "0" Then
                statut = "<i>Non lu</i>"
            Else
                statut = "<i>Lu</i>"
            End If
            tableContent.Text = tableContent.Text & "<td>" & statut & "</td>"
            tableContent.Text = tableContent.Text & "<td> <a href='detailmessage.aspx?mes=" & msg.IdMessage & "'> Voir le détail </a>"
            tableContent.Text = tableContent.Text & "</tr>"
        Next
    End Sub
End Class