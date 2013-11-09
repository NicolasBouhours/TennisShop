Public Class Message

#Region "attributes"

    Private _idMessage As String
    Private _preMessage As String
    Private _nomMessage As String
    Private _titreMessage As String
    Private _dateMessage As Date
    Private _contentMessage As String
    Private _userLogin As String
    Private _vuMessage As String
    Private _mailMessage As String

#End Region

#Region "properties"

    Public Property MailMessage() As String
        Get
            Return _mailMessage
        End Get
        Set(ByVal value As String)
            _mailMessage = value
        End Set
    End Property

    Public Property DateMessage() As Date
        Get
            Return _dateMessage
        End Get
        Set(ByVal value As Date)
            _dateMessage = value
        End Set
    End Property

    Public Property UserLogin() As String
        Get
            Return _userLogin
        End Get
        Set(ByVal value As String)
            _userLogin = value
        End Set
    End Property

    Public Property ContentMessage() As String
        Get
            Return _contentMessage
        End Get
        Set(ByVal value As String)
            _contentMessage = value
        End Set
    End Property

    Public Property TitreMessage() As String
        Get
            Return _titreMessage
        End Get
        Set(ByVal value As String)
            _titreMessage = value
        End Set
    End Property

    Public Property NomMessage() As String
        Get
            Return _nomMessage
        End Get
        Set(ByVal value As String)
            _nomMessage = value
        End Set
    End Property

    Public Property PreMessage() As String
        Get
            Return _preMessage
        End Get
        Set(ByVal value As String)
            _preMessage = value
        End Set
    End Property

    Public Property IdMessage() As String
        Get
            Return _idMessage
        End Get
        Set(ByVal value As String)
            _idMessage = value
        End Set
    End Property

    Public Property VuMessage() As String
        Get
            Return _vuMessage
        End Get
        Set(ByVal value As String)
            _vuMessage = value
        End Set
    End Property

#End Region

#Region "constructors"

    Public Sub New()

        _idMessage = ""
        _nomMessage = ""
        _preMessage = ""
        _titreMessage = ""
        _userLogin = "Non connecte"
        _contentMessage = ""
        _dateMessage = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
        _vuMessage = "0"
        _mailMessage = ""

    End Sub

#End Region

End Class
