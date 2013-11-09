Public Class Categorie

#Region "attributes"

    ''' <summary>
    ''' Stock l'id de la caétégorie
    ''' </summary>
    ''' <remarks></remarks>
    Private _idCat As String

    ''' <summary>
    ''' Stock le libellé de la catégorie
    ''' </summary>
    ''' <remarks></remarks>
    Private _libCat As String

#End Region

#Region "properties"



    ''' <summary>
    ''' accesseur du libellé de la catégorie
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property LibCat() As String
        Get
            Return _libCat
        End Get
        Set(ByVal value As String)
            _libCat = value
        End Set
    End Property

    ''' <summary>
    ''' Accesseur de idCat
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IdCat() As String
        Get
            Return _idCat
        End Get
        Set(ByVal value As String)
            _idCat = value
        End Set
    End Property

#End Region

#Region "constructors"

    ''' <summary>
    ''' Constructeur sans arguments
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        _idCat = ""
        _libCat = ""

    End Sub

    ''' <summary>
    ''' Constructeur avec arguments
    ''' </summary>
    ''' <param name="idCat"></param>
    ''' <param name="libCat"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal libCat As String)

        _idCat = ""
        _libCat = libCat

    End Sub

#End Region

End Class
