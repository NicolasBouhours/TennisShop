
''' <summary>
''' Classe statique qui contient l'ensemble des objets
''' statiques et publiques
''' </summary>
''' <remarks></remarks>
Module StaticDeclarations

    ''' <summary>
    '''  Objet de connexion à la base de données
    ''' </summary>
    ''' <remarks>Permet d'executer des requetes SQL sur la base de données</remarks>
    Public dbHelper As DatabaseHelper
    ''' <summary>
    ''' Objet de gestion des utilisateurs
    ''' </summary>
    ''' <remarks></remarks>
    Public acManager As AccountManager
    ''' <summary>
    ''' Obejt de gestion des produits
    ''' </summary>
    ''' <remarks></remarks>
    Public prManager As ProductManager
End Module
