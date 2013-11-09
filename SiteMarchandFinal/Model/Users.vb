Public Class Users

#Region "attributes"

    Private _userLogin As String
    Private _emailUser As String
    Private _prenomUser As String
    Private _nomuser As String
    Private _adrUser As String
    Private _cpUser As String
    Private _villeUser As String

#End Region

#Region "properites"

    Public Property VilleUser() As String
        Get
            Return _villeUser
        End Get
        Set(ByVal value As String)
            _villeUser = value
        End Set
    End Property

    Public Property CpUser() As String
        Get
            Return _cpUser
        End Get
        Set(ByVal value As String)
            _cpUser = value
        End Set
    End Property

    Public Property AdrUser() As String
        Get
            Return _adrUser
        End Get
        Set(ByVal value As String)
            _adrUser = value
        End Set
    End Property

    Public Property NomUser() As String
        Get
            Return _nomuser
        End Get
        Set(ByVal value As String)
            _nomuser = value
        End Set
    End Property

    Public Property PrenomUser() As String
        Get
            Return _prenomUser
        End Get
        Set(ByVal value As String)
            _prenomUser = value
        End Set
    End Property

    Public Property EmailUser() As String
        Get
            Return _emailUser
        End Get
        Set(ByVal value As String)
            _emailUser = value
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


#End Region

#Region "constructor"

    Public Sub New()

        _userLogin = ""
        _emailUser = ""
        _prenomUser = ""
        _nomuser = ""
        _adrUser = ""
        _cpUser = ""
        _villeUser = ""

    End Sub

#End Region

End Class
