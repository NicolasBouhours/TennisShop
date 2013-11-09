Public Class voirproduit
    Inherits System.Web.UI.Page

    ''' <summary>
    '''  On va intialisé le titre , image , description et description technique du produit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' on recupère les information du produit
        Dim id_prod As String
        Dim prod As New Product
        id_prod = Request("prod")
        prod = prManager.getInfoProduct(id_prod)


        'on initialise le titre
        titreProduit.Text = "<h2>" & prod.ProdMarque & " " & prod.ProdLib & "</h2>"

        'on ajoute la photo
        photoProduit.Text = "<img src='images/" & prod.ProdLib & ".jpg' alt='" & prod.ProdLib & "'/>"

        ' on ajoute le prix
        prixProduit.Text = prod.ProdPrix & " €"
        ' on ajoute la description 
        descrProduit.Text = " <span style='color:#f18423'>Marque : </span> <span style='color:#b6b7bc'> " & prod.ProdMarque & "</span> </br> " & "<span style='color:#f18423'> Nom : </span> <span style='color:#b6b7bc'>" & prod.ProdLib & " </span> <hr style='width:200px; border:0.5px solid #b6b7bc;'/>  <span style='color:#f18423'> Description : </span> </br><span style='color:#b6b7bc'> " & prod.ProdDescr & "."

        ' on ajoute la description technique
        descrTechProduit.Text = "<span style='color:#f18423; height:20px; text-align:center;'> Caractéristiques techniques : </span></br> <span style='color:#b6b7bc'> </br>" & prod.ProdDescrTech & "</span>"
    End Sub

    Private Sub btnProd_Click(sender As Object, e As EventArgs) Handles btnProd.Click
        Dim listPa As List(Of panierProd) = New List(Of panierProd)
        Dim listCheck As List(Of panierProd) = New List(Of panierProd)
        Dim id_prod As String
        Dim verif As Boolean = False
        Dim produit As Product
        Dim qte As Integer
        id_prod = Request("prod")
        produit = prManager.getInfoProduct(id_prod)
        Integer.TryParse(prixProdTB.Text, qte)
        Dim panier As New panierProd(produit.ProdId, produit.ProdLib, produit.ProdPrix, produit.ProdMarque, Session.Item("Loginpers"), qte)

        listCheck = CType(Session("Panier"), List(Of panierProd))
        For Each pr As panierProd In listCheck
            If pr.ProdLib = produit.ProdLib Then
                pr.Qte = pr.Qte + qte
                verif = True
            End If
        Next

        If Session.Item("Siconnect") = 1 Then
                If prixProdTB.Text <> "" And prixProdTB.Text <> "0" And verif = False Then
                    listPa = CType(Session("Panier"), List(Of panierProd))
                    listPa.Add(panier)
                validPanier.Text = " Votre produit a été ajouté au panier"
                End If
        Else
            Response.Redirect("Login.aspx")
        End If

    End Sub
End Class