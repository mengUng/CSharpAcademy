### Système de gestion de transactions financières avec règles personnalisées ###

Spécifications :
----------------
Vous êtes chargé de développer une application simplifiée de gestion de transactions financières pour une entreprise. 
Cette application doit permettre d'enregistrer des transactions (crédit/débit) et de valider les transactions selon 
des règles personnalisées.

Mise en oeuvre :
----------------
Ce projet implémente un modèle basé sur le Pattern Stratégie qui permet de définir une famille d'algorithme (règles).
Ce modèle permet d'adapter dynamiquement le comportement d'un objet en choisissant une stratégie spécifique sans modifier le code du client. 

Fonctionnalités :
	- Ajout de transactions : Ajoutez différents types de transactions (Credit, Debit) dans le service.
	- Validation des transactions : Chaque transaction suit ses propres règles de validation.
	- Exécution des transactions : Valide et exécute toutes les transactions ajoutées.
	- Gestion des données : Structure dédiée pour stocker les détails des transactions. 

Principales classes :

    Donnees : 
        Représente les données associées à une transaction.

    ITransaction :
        Interface commune pour tous les types de transactions.

    Credit :
        Transaction de type crédit avec une limite maximale de montant.
        Règle : Le montant doit être inférieur ou égal à 10 000 €.

    Debit :
        Transaction de type débit avec une limite minimale de solde.
		Règle : Le solde ne peut pas être inférieur à -5 000 € après une transaction.
		
	TransactionService :
		Gère l'ajout et l'exécution des transactions.
		Valide toutes les transactions ajoutées.	

Tests unitaires  :
	Classe CreditDebitsTests :
		tests des transactions Credit et Debit
		
	Classe TransactionServiceTests :
		tests du TransactionService
		
Exemple d'utilisation :
	Voir le contenu du fichier Program.cs du projet.
	
