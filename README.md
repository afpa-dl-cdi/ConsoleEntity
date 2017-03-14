# ConsoleEntity
Applcation console avec Entity Framework 6 en lien avec une BDD sql server.

L'objectif est de générer nos classes à partir des entités/tables de notre modélisation. 


## Merise, MCD et Server SQL
La base de données a été conceptualisée depuis Merise, transformée en script SQL Server et appliquée à une base de données SQL SERVER EXPRESS 2012 (voir commandes.jpg et script_commandes).

## Connexion du projet Visual Studio à SQL Server
Dans l'application VS 2015 menu **Outils > Connexion à la base de données** , renseigner **Nom du serveur** puis **Connexion à la base de données**. La source de données choisit est à **Microsoft SQL Server**

## Création d'un nouveau projet 
Chosir basiquement une application de type console. 

## Ajout d'un nouvel élément de type ADO.Net Entity Framework

Avec le raccourci CTRL+SHIFT+A ajouter un nouvel élément de type **données** et **ADO.NET Entity Data Model** en lui spécifiant un nom (bas de la fenêtre). Dans la fenêtre **Assistant EDM** choisir le contenu du modèle **Code First à partir de la base de données** puis spécifier la connexion en laissant cocher **Enregistrer les paramètres de connexion dans App.Config en tant que :**.
La troisième fenêtre vous permet de séléction quelles objets de la base de données à inclure dans le modèle.  Cocher **Mettre au pluriel ou au singulier...**

## Génération des différentes classes
Si la dernière étape s'est bien déroulée, de nouvelles classes se sont créees reprenant les types et attributs des entités notre base de données. 
