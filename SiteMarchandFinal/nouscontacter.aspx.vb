Imports System.Net.Mail
Imports System.Net

Public Class nouscontacter

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim msg As New Message

        msg.PreMessage = tbPre.Text
        msg.NomMessage = TbNom.Text
        msg.TitreMessage = tbTitre.Text
        msg.ContentMessage = tbContent.Text
        msg.UserLogin = Session.Item("Loginpers")

        msgManager.addMessage(msg)

        infoMsg.Text = "Votre message a été envoyé avec succès."

    End Sub
End Class