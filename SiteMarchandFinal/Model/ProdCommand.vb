Public Class ProdCommand

#Region "attributes"

    Private _numCommande As Integer
    Private _prodId As Integer
    Private _qte As Integer
    Private _prodLib As String
    Private _prodPrix As String

#End Region

#Region "properties"

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

    Public Property Qte() As Integer
        Get
            Return _qte
        End Get
        Set(ByVal value As Integer)
            _qte = value
        End Set
    End Property

    Public Property ProdId() As Integer
        Get
            Return _prodId
        End Get
        Set(ByVal value As Integer)
            _prodId = value
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
        _prodId = 0
        _qte = 0
        _prodLib = ""
        _prodPrix = ""
    End Sub

#End Region

End Class
