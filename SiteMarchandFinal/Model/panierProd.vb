Public Class panierProd

#Region "attributes"

    Private _prodId As String
    Private _prodLib As String
    Private _prodPrix As String
    Private _prodMarque As String
    Private _loginCli As String
    Private _qte As String

#End Region

#Region "properties"

    Public Property ProdId() As String
        Get
            Return _prodId
        End Get
        Set(ByVal value As String)
            _prodId = value
        End Set
    End Property

    Public Property ProdPrix() As String
        Get
            Return _prodPrix
        End Get
        Set(ByVal value As String)
            _prodPrix = value
        End Set
    End Property

    Public Property ProdLib() As String
        Get
            Return _prodLib
        End Get
        Set(ByVal value As String)
            _prodLib = value
        End Set
    End Property

    Public Property LoginCli() As String
        Get
            Return _loginCli
        End Get
        Set(ByVal value As String)
            _loginCli = value
        End Set
    End Property

    Public Property ProdMarque() As String
        Get
            Return _prodMarque
        End Get
        Set(ByVal value As String)
            _prodMarque = value
        End Set
    End Property

    Public Property Qte() As String
        Get
            Return _qte
        End Get
        Set(ByVal value As String)
            _qte = value
        End Set
    End Property


#End Region

#Region "constructors"

    ''' <summary>
    ''' Constructeur sans arguments
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        _prodId = ""
        _prodLib = ""
        _prodPrix = ""
        _prodMarque = ""
        _loginCli = ""
        _qte = 0

    End Sub

    ''' <summary>
    ''' Constructeur avec arguments
    ''' </summary>
    ''' <param name=""></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal prodId As String, ByVal prodLib As String, ByVal prodPrix As String, ByVal prodMarque As String, ByVal loginCli As String, ByVal qte As Integer)

        _prodId = prodId
        _prodLib = prodLib
        _prodPrix = prodPrix
        _prodMarque = prodMarque
        _loginCli = loginCli
        _qte = qte

    End Sub

#End Region

End Class
