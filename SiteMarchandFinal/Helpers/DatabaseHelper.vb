Imports System.Data.SqlClient

''' <summary>
''' Classe permettant de gérer tout ce qui concerne 
''' la connexion à la base de données
''' </summary>
''' <remarks></remarks>
Public Class DatabaseHelper

#Region "attributes"

    ''' <summary>
    ''' Objet de connexion à la base de données
    ''' </summary>
    ''' <remarks></remarks>
    Private _connection As SqlConnection

#End Region

#Region "properties"

#End Region

#Region "constructors"

    ''' <summary>
    ''' Constructeur par defaut
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me._connection = New SqlConnection(My.Settings.Setting)

        Try
            ' à l'instanciation de m'objet qui est effectuée
            ' dès le démarrage de l'application on test que 
            ' l'on peut se connecter à la base de données
            Me._connection.Open()
            Me._connection.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "methods"

    ''' <summary>
    ''' Exécute une requete SQL passée en argument
    ''' et retourne le résultat dans un DataTable
    ''' </summary>
    ''' <param name="query"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteSQLQuery(query As String) As DataTable
        Dim result As New DataTable
        Dim adapter As SqlDataAdapter

        adapter = New SqlDataAdapter(query, Me._connection)

        Me._connection.Open()

        ' execute la requete SQL
        adapter.Fill(result)

        Me._connection.Close()

        Return result
    End Function

#End Region

End Class
