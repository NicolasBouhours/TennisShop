Public Class Register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnEnvoie_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnvoie.Click
        dbHelper = New DatabaseHelper
        acManager = New AccountManager

        Dim userLogin As String = userName.Text
        Dim userEmail As String = emailUser.Text
        Dim userNom As String = nomUser.Text
        Dim userPrenom As String = prenomUser.Text
        Dim userAdress As String = adressUser.Text
        Dim userVille As String = villeUser.Text
        Dim userCp As String = cpUser.Text
        Dim userPw As String = pwUser.Text
        Dim userPw2 As String = pwUser2.Text

        Try
            If userLogin.Length = 0 Or userEmail.Length < 5 Or userNom.Length = 0 Or userPrenom.Length = 0 Or userAdress.Length = 0 Or userVille.Length = 0 Or userCp.Length = 0 Or userPw.Length = 0 Or userPw2.Length = 0 Then
                ' If userPw.Equals(userPw2) = False Then
                lbError.Text = "Veuillez remplir tous les champs"
                'lbError.Text = "Veuillez entrer les mêmes mots de passes"
            ElseIf (userPw.Length < 6) Then
                lbError.Text = "Veuillez rentrer des mots de passe faisant aux moins 6 caractères"
            ElseIf acManager.checkExistusers(userLogin) = False Then
                lbError.Text = "Ce nom de compte n'est pas disponible"
            ElseIf userPw.Equals(userPw2) = False Then
                lbError.Text = "Veuillez entrer les mêmes mots de passes"
            Else

                Dim query As String = "INSERT INTO USERS VALUES('" & userLogin & "','" & userEmail & "','" & userNom & "','" & userPrenom & "','" & userAdress & "','" & userCp & "','" & userVille & "','" & userPw & "','0')"

                dbHelper.ExecuteSQLQuery(query)
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class