Public Class messageManager

#Region "attributes"
    Private _listMessage As List(Of Message)
#End Region

#Region "properties"

    Public Property ListMessage() As List(Of Message)
        Get
            Return _listMessage
        End Get
        Set(ByVal value As List(Of Message))
            _listMessage = value
        End Set
    End Property

#End Region

#Region "constructors"

    Public Sub New()
        _listMessage = New List(Of Message)
    End Sub

#End Region

#Region "methods"

    ''' <summary>
    ''' recupère la liste des tous les messages
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub getAllMessage()
        Dim query As String = "SELECT * FROM MESSAGE ORDER BY DATE_MESSAGE DESC"
        Dim datat As DataTable

        Try

            datat = dbHelper.ExecuteSQLQuery(query)
            For Each row As DataRow In datat.Select()
                Dim msg As New Message
                msg.IdMessage = row("ID_MESSAGE")
                msg.PreMessage = row("PRE_MESSAGE")
                msg.NomMessage = row("NOM_MESSAGE")
                msg.TitreMessage = row("TITRE_MESSAGE")
                msg.ContentMessage = row("CONTENU_MESSAGE")
                msg.DateMessage = row("DATE_MESSAGE")
                msg.VuMessage = row("VU_MESSAGE")
                msg.MailMessage = row("MAIL_MESSAGE")
                msgManager._listMessage.Add(msg)
            Next
        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>
    ''' Fonction permettant d'ajouter un message en base de donnée
    ''' </summary>
    ''' <param name="msg"></param>
    ''' <remarks></remarks>
    Public Sub addMessage(ByVal msg As Message)
        Dim query As String = "INSERT INTO MESSAGE(PRE_MESSAGE,NOM_MESSAGE,TITRE_MESSAGE,CONTENU_MESSAGE,DATE_MESSAGE,VU_MESSAGE,MAIL_MESSAGE) VALUES('" & msg.PreMessage & "','" & msg.NomMessage & "','" & msg.TitreMessage & "','" & msg.ContentMessage & "','" & msg.DateMessage & "','" & msg.VuMessage & "','" & msg.MailMessage & "')"

        Try
            dbHelper.ExecuteSQLQuery(query)
            msgManager.ListMessage.Add(msg)
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' Permet de changer la visibilité d'un message
    ''' </summary>
    ''' <param name="idMessage"></param>
    ''' <remarks></remarks>
    Public Sub setReadMsg(ByVal idMessage As Integer)
        Dim query As String = "UPDATE MESSAGE SET VU_MESSAGE ='1' WHERE ID_MESSAGE =" & idMessage & ""

        Try
            dbHelper.ExecuteSQLQuery(query)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
