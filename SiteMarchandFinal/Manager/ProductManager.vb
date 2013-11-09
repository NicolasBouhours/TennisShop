Public Class ProductManager

#Region "attributes"

    Private _listCat As List(Of Categorie)
    Private _listprod As List(Of Product)
    Private _listPanier As List(Of panierProd)

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

    Public Property ListPanier() As List(Of panierProd)
        Get
            Return _listPanier
        End Get
        Set(ByVal value As List(Of panierProd))
            _listPanier = value
        End Set
    End Property

#End Region

#Region "constructors"

    Public Sub New()

        _listCat = New List(Of Categorie)
        _listprod = New List(Of Product)
        _listPanier = New List(Of panierProd)

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

    ''' <summary>
    ''' Permet de supprimer une catégorie
    ''' </summary>
    ''' <param name="cat"></param>
    ''' <remarks></remarks>
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

            If tableGroups.Rows.Count > 0 Or tableUsers.Rows.Count > 0 Then

                For Each groupRow As DataRow In tableGroups.Select("", "ID_CAT")
                    Dim cat As New Categorie

                    cat.LibCat = groupRow("LIB_CAT")
                    cat.IdCat = groupRow("ID_CAT")

                    For Each proRow As DataRow In tableUsers.Select("ID_CAT = '" & cat.IdCat & "'", "PROD_ID")

                        Dim p As New Product

                        p.ProdId = proRow("PROD_ID")
                        p.ProdLib = proRow("PROD_LIB")
                        p.ProdPrix = proRow("PROD_PRIX")
                        p.ProdDescr = proRow("PROD_DECRITION")
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

    ''' <summary>
    ''' recupère les informations des produits
    ''' </summary>
    ''' <param name="idProd"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getInfoProduct(ByVal idProd As String) As Product
        Dim prod As New Product()
        Dim data As New DataTable
        Dim query As String = "SELECT * FROM PRODUCTS WHERE PROD_ID='" & idProd & "'"

        data = dbHelper.ExecuteSQLQuery(query)

        For Each dataRow As DataRow In data.Select()
            prod.ProdId = idProd
            prod.ProdLib = dataRow("PROD_LIB")
            prod.ProdPrix = dataRow("PROD_PRIX")
            prod.ProdDescr = dataRow("PROD_DECRITION")
            prod.ProdDescrTech = dataRow("PROD_DESCTECH")
            prod.ProdMarque = dataRow("PROD_MARQUE")
            prod.ProdIdCat = dataRow("ID_CAT")
        Next

        Return prod
    End Function

    ''' <summary>
    ''' Ajoute un produit au panier
    ''' </summary>
    ''' <param name="panierProd"></param>
    ''' <remarks></remarks>
    Public Sub addProductPanier(ByVal panierProd As panierProd)

        Me._listPanier.Add(panierProd)

    End Sub

    ''' <summary>
    ''' Ajout d'une commande
    ''' </summary>
    ''' <param name="prPanier"></param>
    ''' <param name="qte"></param>
    ''' <param name="login_user"></param>
    ''' <remarks></remarks>
    Public Function ajoutCommande(ByVal prixTotal As String, ByVal userLogin As String) As Integer
        Dim year As Integer = Date.Now.Year
        Dim month As Integer = Date.Now.Month
        Dim day As Integer = Date.Now.Day
        Dim dt As New Date(year, month, day)
        Dim table As DataTable
        Dim nbMax As Integer

        Try
            Dim query As String = "INSERT INTO COMMANDS(date_commande,mnt_commande,statut_id,user_login) VALUES('" & dt.Year & "/" & dt.Month & "/" & dt.Day & "','" & prixTotal & "',1,'" & userLogin & "')"
            dbHelper.ExecuteSQLQuery(query)
            Dim queryMax As String = "SELECT MAX(num_commande) as REP FROM COMMANDS"
            table = dbHelper.ExecuteSQLQuery(queryMax)

            For Each row As DataRow In table.Select()
                nbMax = row("REP")
            Next

        Catch ex As Exception

        End Try

        Return nbMax
    End Function

    ''' <summary>
    ''' Ajout d'une commande 2
    ''' </summary>
    ''' <param name="prod"></param>
    ''' <param name="userLogin"></param>
    ''' <param name="qte"></param>
    ''' <remarks></remarks>
    Public Sub ajoutCommandeProd(ByVal prod As panierProd, ByVal idCommand As Integer, ByVal qte As Integer, ByVal userLogin As String)
        Try
            Dim query As String = " INSERT INTO PRODCOMMAND(NUM_COMMANDE,PROD_ID,QTE,PROD_LIB,PROX_PRIX) VALUES(" & idCommand & "," & prod.ProdId & "," & qte & ",'" & prod.ProdLib & "','" & prod.ProdPrix & "' )"
            dbHelper.ExecuteSQLQuery(Query)
        Catch ex As Exception

        End Try


    End Sub

#End Region

#Region "Gestion des commandes"

    ''' <summary>
    ''' recupère sous forme de liste toutes les commandes pour une personne
    ''' </summary>
    ''' <param name="userLogin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getListCommand(ByVal userLogin As String) As List(Of Commands)
        Dim listCommande As New List(Of Commands)
        Dim query As String = " SELECT * FROM COMMANDS WHERE USER_LOGIN ='" & userLogin & "' ORDER BY NUM_COMMANDE DESC"
        Dim datat As DataTable

        datat = dbHelper.ExecuteSQLQuery(query)

        For Each row As DataRow In datat.Select()
            Dim com As New Commands
            Dim idStatut As Integer = row("STATUT_ID")

            com.NumCommande = row("NUM_COMMANDE")
            com.DateCommande = row("DATE_COMMANDE")
            com.MntCommande = row("MNT_COMMANDE")
            com.StatutLib = prManager.getLibStat(idStatut)
            com.UserLogin = userLogin

            listCommande.Add(com)
        Next

        Return listCommande

    End Function

    ''' <summary>
    ''' recupere la liste de toute les commandes passés
    ''' </summary>
    ''' <param name="userLogin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getListCommandAdmin(ByVal userLogin As String) As List(Of Commands)
        Dim listCommandes As New List(Of Commands)
        Dim query As String = " SELECT * FROM COMMANDS ORDER BY NUM_COMMANDE DESC"
        Dim datat As DataTable

        datat = dbHelper.ExecuteSQLQuery(query)

        For Each row As DataRow In datat.Select()
            Dim com As New Commands
            Dim idStatut As Integer = row("STATUT_ID")
            com.DateCommande = row("DATE_COMMANDE")
            com.NumCommande = row("NUM_COMMANDE")
            com.MntCommande = row("MNT_COMMANDE")
            com.StatutLib = prManager.getLibStat(idStatut)
            com.UserLogin = row("USER_LOGIN")

            listCommandes.Add(com)
        Next

        Return listCommandes
    End Function

    ''' <summary>
    ''' Recupère le libellé d'un statut en fonction de son id
    ''' </summary>
    ''' <param name="idStatut"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLibStat(ByVal idStatut As Integer)
        Dim res As String = ""
        Dim query As String = "SELECT LIB_STATUT FROM STATUT WHERE ID_STATUT ='" & idStatut & "'"
        Dim datat As DataTable

        datat = dbHelper.ExecuteSQLQuery(query)

        For Each row As DataRow In datat.Select
            res = row("LIB_STATUT")
        Next

        Return res

    End Function

    ''' <summary>
    ''' recupère la liste des produits associés a une commande
    ''' </summary>
    ''' <param name="num_commande"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getListProdCommand(ByVal num_commande As Integer)
        Dim prod As New List(Of ProdCommand)
        Dim query As String = "SELECT * FROM PRODCOMMAND WHERE NUM_COMMANDE = " & num_commande & ""
        Dim table As DataTable

        table = dbHelper.ExecuteSQLQuery(query)

        For Each row As DataRow In table.Select()
            Dim prodc As New ProdCommand
            prodc.NumCommande = num_commande
            prodc.ProdId = row("PROD_ID")
            prodc.Qte = row("QTE")
            prodc.ProdLib = row("PROD_LIB")
            prodc.ProdPrix = row("PROX_PRIX")

            prod.Add(prodc)
        Next
        Return prod

    End Function

    ''' <summary>
    ''' Recupere le libellé du statut d'une commande
    ''' </summary>
    ''' <param name="numCommande"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getStatut(ByVal numCommande As Integer) As String
        Dim libStatut As String = ""
        Dim query As String = "SELECT LIB_STATUT FROM STATUT,COMMANDS WHERE COMMANDS.STATUT_ID = STATUT.ID_STATUT AND NUM_COMMANDE =" & numCommande & ""
        Dim datat As DataTable

        datat = dbHelper.ExecuteSQLQuery(query)

        For Each row As DataRow In datat.Select()
            libStatut = row("LIB_STATUT")
        Next

        Return libStatut

    End Function

    ''' <summary>
    ''' Recupere tous les libellés des statuts existant
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAllLibStatut() As List(Of String)
        Dim query As String = "SELECT LIB_STATUT FROM STATUT"
        Dim listLib As New List(Of String)
        Dim datat As DataTable

        datat = dbHelper.ExecuteSQLQuery(query)

        For Each row As DataRow In datat.Select()
            listLib.Add(row("LIB_STATUT"))
        Next

        Return listLib
    End Function

    ''' <summary>
    ''' recupère l'id du statut en fonction de son libellé
    ''' </summary>
    ''' <param name="libStatut"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getIdStatut(ByVal libStatut As String) As Integer
        Dim nb As Integer = 0
        Dim datat As DataTable
        Dim query As String = "SELECT ID_STATUT FROM STATUT WHERE LIB_STATUT ='" & libStatut & "'"

        datat = dbHelper.ExecuteSQLQuery(query)

        For Each row As DataRow In datat.Select()
            nb = row("ID_STATUT")
        Next

        Return nb
    End Function

    ''' <summary>
    ''' Permet de modifier l'avancement d'une commande
    ''' </summary>
    ''' <param name="numCommade"></param>
    ''' <param name="newIdStatut"></param>
    ''' <remarks></remarks>
    Public Sub updateLib(ByVal numCommade As Integer, ByVal newIdStatut As String)
        Dim query As String = "UPDATE COMMANDS SET statut_id ='" & newIdStatut & "' WHERE NUM_COMMANDE =" & numCommade & ""

        dbHelper.ExecuteSQLQuery(query)
    End Sub

    ''' <summary>
    ''' recupere les informations relatif a l'utilisateur
    ''' </summary>
    ''' <param name="userLogin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getInfoUsers(ByVal userLogin As String) As Users
        Dim user As New Users
        Dim query As String = "SELECT * FROM USERS WHERE LOGIN_USER='" & userLogin & "'"
        Dim datat As DataTable

        datat = dbHelper.ExecuteSQLQuery(query)

        For Each row As DataRow In datat.Select()
            user.UserLogin = userLogin
            user.EmailUser = row("EMAIL_USER")
            user.PrenomUser = row("FIRSTNAME_USER")
            user.NomUser = row("LASTNAME_USER")
            user.AdrUser = row("ADR_USER")
            user.CpUser = row("CP_USER")
            user.VilleUser = row("VILLE_USER")
        Next

        Return user

    End Function

    ''' <summary>
    ''' recupere le login de l'utilisateur en fonction de l'id de la commande
    ''' </summary>
    ''' <param name="idCommande"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getLoginUsers(ByVal idCommande As Integer) As String
        Dim res As String = ""
        Dim query As String = "SELECT USER_LOGIN FROM COMMANDS WHERE NUM_COMMANDE =" & idCommande & ""
        Dim datat As DataTable

        datat = dbHelper.ExecuteSQLQuery(query)

        For Each row As DataRow In datat.Select()
            res = row("USER_LOGIN")
        Next

        Return res

    End Function

#End Region

#End Region

End Class
