Public Class ProductManager

#Region "attributes"

    Private _listCat As List(Of Categorie)
    Private _listprod As List(Of Product)

#End Region

#Region "properties"

    Public Property ListCat() As List(Of Categorie)
        Get
            Return _listCat
        End Get
        Set(ByVal value As List(Of Categorie))
            _listCat = value
        End Set
    End Property

    Public Property ListProd() As List(Of Product)
        Get
            Return _listprod
        End Get
        Set(ByVal value As List(Of Product))
            _listprod = value
        End Set
    End Property

#End Region

#Region "constructors"

    Public Sub New()

        _listCat = New List(Of Categorie)
        _listprod = New List(Of Product)

    End Sub

#End Region

#Region "methods"

#Region "Gestion des catégories"

    ''' <summary>
    ''' Fonction d'ajout de catégories
    ''' </summary>
    ''' <param name="nomCat"></param>
    ''' <remarks></remarks>
    Public Sub AddCategorie(ByVal cat As Categorie)
        Dim query As String = "INSERT INTO CATEGORIE(LIB_CAT) VALUES('" & cat.LibCat & "')"

        dbHelper.ExecuteSQLQuery(query)

    End Sub

    ''' <summary>
    ''' Verifie si la categorie a ajouté existe
    ''' </summary>
    ''' <param name="cat"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function checkExistCategorie(ByVal cat As Categorie)
        Dim verif As Boolean = True
        Dim queryIsCatExists As String = "SELECT COUNT(*) FROM CATEGORIE WHERE LIB_CAT = '" & cat.LibCat & "'"
        Dim table As New DataTable

        Try

            table = dbHelper.ExecuteSQLQuery(queryIsCatExists)
            If table(0)(0) = 1 Then
                verif = False
            End If

        Catch ex As Exception

        End Try

        Return verif

    End Function

    Public Sub DeleteCategorie(ByVal cat As Categorie)

        Dim query As String = "DELETE FROM CATEGORIE WHERE LIB_CAT ='" & cat.LibCat & "'"
        dbHelper.ExecuteSQLQuery(query)

    End Sub

    ''' <summary>
    ''' Recuperes les produits et les catégories dans une liste"
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GetProducts()

        Dim queryGroup As String = "SELECT * FROM CATEGORIE"
        Dim queryUser As String = "SELECT * FROM PRODUCTS"

        Dim tableGroups As New DataTable
        Dim tableUsers As New DataTable
        Dim i As Integer = 0

        Try
            Me._listCat.Clear()

            tableGroups = dbHelper.ExecuteSQLQuery(queryGroup)
            tableUsers = dbHelper.ExecuteSQLQuery(queryUser)

            If tableGroups.Rows.Count > 0 AndAlso tableUsers.Rows.Count > 0 Then

                For Each groupRow As DataRow In tableGroups.Select("", "ID_CAT")
                    Dim cat As New Categorie

                    cat.LibCat = groupRow("LIB_CAT")
                    cat.IdCat = groupRow("ID_CAT")

                    For Each proRow As DataRow In tableUsers.Select("ID_CAT = '" & cat.IdCat & "'", "PROD_ID")

                            Dim p As New Product

                            p.ProdId = proRow("PROD_ID")
                            p.ProdLib = proRow("PROD_LIB")
                            p.ProdPrix = proRow("PROD_PRIX")
                            p.ProdDescr = proRow("PROD_DESCRITION")
                            p.ProdDescrTech = proRow("PROD_DESCTECH")
                            p.ProdMarque = proRow("PROD_MARQUE")
                            p.ProdIdCat = proRow("ID_CAT")
                            i = i + 1

                            Me._listprod.Add(p)

                    Next

            Me._listCat.Add(cat)

                Next

            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Gestion des produits"

#End Region

#End Region

End Class
