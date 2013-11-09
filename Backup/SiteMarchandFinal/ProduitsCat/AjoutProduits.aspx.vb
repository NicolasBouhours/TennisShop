Public Class AjoutProduits
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub dropdownlist_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles dropdownlist.Load
        If dropdownlist.Items.Count < prManager.ListCat.Count Then
            For Each cat As Categorie In prManager.ListCat
                dropdownlist.Items.Add(cat.LibCat)
            Next
        End If
    End Sub




    Private Sub addProduct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addProduct.Click

        Dim prodLib As String = ProduitLib.Text
        Dim prodPrix As String = PrixProd.Text
        Dim prodDesc As String = DescrProd.Text
        Dim prodDescrTech As String = DescrTechProd.Text
        Dim prodMarque As String = MarqueProd.Text
        Dim prodIdCat As String = dropdownlist.SelectedItem.Text
        Dim varId As String = ""

        For Each cat As Categorie In prManager.ListCat
            If dropdownlist.SelectedItem.Text.Equals(cat.LibCat) Then
                varId = cat.IdCat
            End If
        Next

        If fileUpload.HasFile Then
            Try
                fileUpload.SaveAs("C:\Users\nbouho\Documents\Visual Studio 2010\Projects\SiteMarchandFinal\SiteMarchandFinal\images\" & prodLib & ".jpg")
            Catch ex As Exception
                lbError.Text = "ERROR: " & ex.Message.ToString()
            End Try
        Else
            lbError.Text = "You have not specified a file."
        End If

        Dim query As String = " INSERT INTO PRODUCTS(PROD_LIB,PROD_PRIX,PROD_DESCRITION,PROD_DESCTECH,PROD_MARQUE,ID_CAT) VALUES('" & prodLib & "','" & prodPrix & "','" & prodDesc & "','" & prodDescrTech & "','" & prodMarque & "','" & varId & "')"

        If ProduitLib.Text.Length <> 0 Or MarqueProd.Text.Length <> 0 Or PrixProd.Text.Length <> 0 Or DescrProd.Text.Length <> 0 Or DescrTechProd.Text.Length <> 0 Then
            dbHelper.ExecuteSQLQuery(query)
            lbError.Text = "Votre produit a été ajouté avec succès"
        Else
            lbError.Text = "Merci de renseigner tous les champs"
        End If

    End Sub
End Class