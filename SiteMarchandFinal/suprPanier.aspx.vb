Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim listPa As New List(Of panierProd)
        listPa = Session.Item("Panier")
        Dim index As Integer = 0
        For Each panierp As panierProd In listPa
            If panierp.ProdId = Request("prodid") Then
                listPa.RemoveAt(index)
                index = index + 1
                Response.Redirect("panier.aspx")
            End If
        Next
    End Sub

End Class