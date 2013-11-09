Public Class Product

#Region "attributes"


    Private _prodId As String
    Private _prodLib As String
    Private _prodPrix As String
    Private _prodDescr As String
    Private _prodDescrTech As String
    Private _prodMarque As String
    Private _prodIdCar As String

#End Region

#Region "properties"

    Public Property ProdIdCat() As String
        Get
            Return _prodIdCar
        End Get
        Set(ByVal value As String)
            _prodIdCar = value
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

    Public Property ProdDescrTech() As String
        Get
            Return _prodDescrTech
        End Get
        Set(ByVal value As String)
            _prodDescrTech = value
        End Set
    End Property

    Public Property ProdDescr() As String
        Get
            Return _prodDescr
        End Get
        Set(ByVal value As String)
            _prodDescr = value
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

    Public Property ProdId() As String
        Get
            Return _prodId
        End Get
        Set(ByVal value As String)
            _prodId = value
        End Set
    End Property

#End Region

#Region "constructors"

    Public Sub New()

        _prodId = ""
        _prodLib = ""
        _prodPrix = ""
        _prodDescr = ""
        _prodDescrTech = ""
        _prodMarque = ""
        _prodIdCar = ""

    End Sub

    Public Sub New(ByVal prodId As String, ByVal prodLib As String, ByVal prodPrix As String, ByVal prodDescr As String, ByVal proddescrTech As String, ByVal prodMarque As String, ByVal prodIdCat As String)

        _prodId = prodId
        _prodLib = prodLib
        _prodPrix = prodPrix
        _prodDescr = prodDescr
        _prodDescrTech = proddescrTech
        _prodMarque = prodMarque
        _prodIdCar = prodIdCat

    End Sub
#End Region

#Region "methods"

#End Region

End Class
