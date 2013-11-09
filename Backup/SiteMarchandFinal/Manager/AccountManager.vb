''' <summary>
''' Classe statique permettant l'ajout d'utilisateur, ect ...
''' </summary>
''' <remarks></remarks>
Public Class AccountManager

#Region "function"

    ''' <summary>
    ''' Permet de regarder si l'utilisateur existe déja
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function checkExistusers(ByVal usersLogin As String)
        Dim verif As Boolean = True
        Dim queryIsUserExists As String = "SELECT COUNT(*) FROM USERS WHERE LOGIN_USER = '" & usersLogin & "'"
        Dim table As New DataTable

        Try

            table = dbHelper.ExecuteSQLQuery(queryIsUserExists)
            If table(0)(0) = 1 Then
                verif = False
            End If

        Catch ex As Exception

        End Try

        Return verif

    End Function

    ''' <summary>
    ''' Permet de connecter l'utilisateur si il existe
    ''' </summary>
    ''' <param name="usersLogin"></param>
    ''' <param name="usersPassword"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function checkConnectUsers(ByVal usersLogin As String, ByVal usersPassword As String)
        Dim verif As Boolean = True
        Dim queryIsUserExists As String = "SELECT COUNT(LOGIN_USER) as REP FROM USERS WHERE LOGIN_USER = '" & usersLogin & "' AND PASSWORD_USER='" & usersPassword & "' GROUP BY LOGIN_USER"
        Dim table As New DataTable
        Dim r As DataRow

        Try

            table = dbHelper.ExecuteSQLQuery(queryIsUserExists)
            r = table.Rows(0)
            If r("REP") = 1 Then
                verif = False
            End If

        Catch ex As Exception

        End Try

        Return verif
    End Function

#End Region

End Class
