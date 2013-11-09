Public Class detailmessage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim idMsg As Integer
        idMsg = Request("mes")
        msgManager.setReadMsg(idMsg)
    End Sub



    Private Sub nomPersonne_Load(sender As Object, e As EventArgs) Handles nomPersonne.Load
        Dim mesg As New Message
        For Each msg As Message In msgManager.ListMessage
            If msg.IdMessage = Request("mes") Then
                mesg = msg
            End If
        Next
        nomPersonne.Text = " De : " & mesg.PreMessage & " " & mesg.NomMessage

    End Sub

    Private Sub mailPersonne_Load(sender As Object, e As EventArgs) Handles mailPersonne.Load
        Dim mesg As New Message
        For Each msg As Message In msgManager.ListMessage
            If msg.IdMessage = Request("mes") Then
                mesg = msg
            End If
        Next
        mailPersonne.Text = " Mail : " & mesg.MailMessage
    End Sub



    Private Sub titreMail_Load(sender As Object, e As EventArgs) Handles titreMail.Load
        Dim mesg As New Message
        For Each msg As Message In msgManager.ListMessage
            If msg.IdMessage = Request("mes") Then
                mesg = msg
            End If
        Next
        titreMail.Text = "Objet : " & mesg.TitreMessage
    End Sub

    Private Sub contentMessage_Load(sender As Object, e As EventArgs) Handles contentMessage.Load
        Dim mesg As New Message
        For Each msg As Message In msgManager.ListMessage
            If msg.IdMessage = Request("mes") Then
                mesg = msg
            End If
        Next
        contentMessage.Text = mesg.ContentMessage
    End Sub

    Private Sub dateMessage_Load(sender As Object, e As EventArgs) Handles dateMessage.Load
        Dim mesg As New Message
        For Each msg As Message In msgManager.ListMessage
            If msg.IdMessage = Request("mes") Then
                mesg = msg
            End If
        Next
        dateMessage.Text = "Date : " & mesg.DateMessage
    End Sub

End Class