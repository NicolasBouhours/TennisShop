Public Class modifiermesinfo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session.Item("SiConnect") = 0 Then
            Response.Redirect("default.aspx")
        End If

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim query As String = "UPDATE USERS SET EMAIL_USER='" & tbemailUser.Text & "', FIRSTNAME_USER='" & tbprenomUser.Text & "', LASTNAME_USER='" & tbnomUser.Text & "', ADR_USER='" & tbadressUser.Text & "', CP_USER='" & tbcpUser.Text & "', VILLE_USER='" & tbvilleUser.Text & "' WHERE LOGIN_USER='" & Session.Item("Loginpers") & "'"
        Try
            If tbprenomUser.Text <> "" And tbnomUser.Text <> "" And tbadressUser.Text <> "" And tbcpUser.Text <> "" And tbemailUser.Text <> "" And tbvilleUser.Text <> "" Then
                dbHelper.ExecuteSQLQuery(query)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub tbprenomUser_Init(sender As Object, e As EventArgs) Handles tbprenomUser.Init
        Dim user As New Users

        user = acManager.getInfoUser(Session.Item("Loginpers"))

        tbprenomUser.Text = user.PrenomUser
    End Sub

    Private Sub tbnomUser_Init(sender As Object, e As EventArgs) Handles tbnomUser.Init
        Dim user As New Users

        user = acManager.getInfoUser(Session.Item("Loginpers"))

        tbnomUser.Text = user.NomUser
    End Sub

    Private Sub tbemailUser_Init(sender As Object, e As EventArgs) Handles tbemailUser.Init
        Dim user As New Users

        user = acManager.getInfoUser(Session.Item("Loginpers"))

        tbemailUser.Text = user.EmailUser
    End Sub

    Private Sub tbadressUser_Init(sender As Object, e As EventArgs) Handles tbadressUser.Init
        Dim user As New Users

        user = acManager.getInfoUser(Session.Item("Loginpers"))

        tbadressUser.Text = user.AdrUser


    End Sub

    Private Sub tbcpUser_Init(sender As Object, e As EventArgs) Handles tbcpUser.Init
        Dim user As New Users

        user = acManager.getInfoUser(Session.Item("Loginpers"))

        tbcpUser.Text = user.CpUser
    End Sub


    Private Sub tbvilleUser_Init(sender As Object, e As EventArgs) Handles tbvilleUser.Init
        Dim user As New Users

        user = acManager.getInfoUser(Session.Item("Loginpers"))

        tbvilleUser.Text = user.VilleUser
    End Sub
End Class