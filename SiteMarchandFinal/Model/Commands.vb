Public Class Commands

#Region "attributes"

    Private _numCommande As Integer
    Private _dateCommande As Date
    Private _mntCommande As String
    Private _statutLib As String
    Private _userLogin As String

#End Region

#Region "properties"

    Public Property UserLogin() As String
        Get
            Return _userLogin
        End Get
        Set(ByVal value As String)
            _userLogin = value
        End Set
    End Property

    Public Property StatutLib() As String
        Get
            Return _statutLib
        End Get
        Set(ByVal value As String)
            _statutLib = value
        End Set
    End Property

    Public Property MntCommande() As String
        Get
            Return _mntCommande
        End Get
        Set(ByVal value As String)
            _mntCommande = value
        End Set
    End Property

    Public Property DateCommande() As Date
        Get
            Return _dateCommande
        End Get
        Set(ByVal value As Date)
            _dateCommande = value
        End Set
    End Property

    Public Property NumCommande() As Integer
        Get
            Return _numCommande
        End Get
        Set(ByVal value As Integer)
            _numCommande = value
        End Set
    End Property


#End Region

#Region "constructors"

    Public Sub New()
        _numCommande = 0
        _dateCommande = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
        _mntCommande = ""
        _statutLib = ""
        _userLogin = ""
    End Sub

#End Region

End Class
