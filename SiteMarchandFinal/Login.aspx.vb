Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        acManager = New AccountManager

        Dim userLogin As String = userName.Text
        Dim userPassword As String = userPaassword.Text

        If acManager.checkConnectUsers(userLogin, userPassword) = False Then
            Session.Item("connect") = 1
            lbError.Text = "Vous êtes maintenant connecté"
            Session.Item("SiConnect") = 1
            Session.Item("Loginpers") = userLogin
            If acManager.checkAdminUsers(userLogin) = True Then
                Session.Item("admin") = 1
            End If
            Response.Redirect("Default.aspx")

        Else
            lbError.Text = "Vous avez entré de mauvais identifiants"
        End If
    End Sub
End Class