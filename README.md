# 🚗 Le projet - ExpressVoiture

## ✨ Fonctionnalités principales :
### Vue Administrateur :
- Gestion complète de l’inventaire de voitures.
- Édition des détails de chaque voiture.
- Suivi des voitures vendues ou indisponibles.
### Vue Client :
- Visualisation des voitures disponibles.
- Consultation des détails d'une voiture spécifique.

## 🌟 Contexte du projet :
**ExpressVoiture** est une plateforme web de gestion de la vente de voitures, conçue pour être gérée de manière autonome par un administrateur.

## 🎯 Objectifs d'implémentation :
### 🔧 Pour les administrateurs :
- Ajouter et modifier des voitures dans l’inventaire avec des photos, des caractéristiques, et des descriptions.
- Marquer les voitures comme vendues ou indisponibles.
- Gérer l’inventaire de manière autonome.

### 🛒 Pour les clients :
- Consulter les voitures disponibles.
- Visualiser les détails de chaque voiture.

### 💡 Comprendre pourquoi choisir .NET/MVC :
- **Sécurité robuste** : gestion des utilisateurs, validation d'entrée, authentification sécurisée.
- **Architecture MVC** : séparation des responsabilités entre Modèle, Vue, et Contrôleur.
- **Performances optimales** grâce à .NET et des mises à jour régulières.

# ExpressVoiture - Instructions d'installation

## Prérequis

Avant de commencer, assurez-vous d'avoir installé les éléments suivants :

- [Visual Studio 2019 ou une version plus récente](https://visualstudio.microsoft.com/) avec la charge de travail **Développement ASP.NET et développement web**. Pour installer cette charge de travail :
  1. Lancez l'installateur de Visual Studio.
  2. Sélectionnez **Modifier** pour votre installation actuelle de Visual Studio.
  3. Dans la liste des charges de travail, cochez **Développement ASP.NET et développement web**.
  4. Cliquez sur **Modifier** pour installer la charge de travail sélectionnée.
- [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

## Étapes d'installation

### 1. Cloner le projet

Clonez le projet depuis GitHub en utilisant la commande suivante :

```sh
git clone https://github.com/EveCrystali/P5.git
```

### 2. Ouvrir le projet

Ouvrez le projet **ExpressVoiture** dans Visual Studio.

### 3. Configurer la chaîne de connexion

Dans le projet **ExpressVoiture**, ouvrez le fichier `appsettings.json` à la racine. Vous y trouverez la section `ConnectionStrings` qui définit les chaînes de connexion pour la base de données utilisée dans cette application.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=aspnet-ExpressVoitures-4c232545-f432-4e84-8e78-db4d8bfeaa8b;Trusted_Connection=True;MultipleActiveResultSets=true"

  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```

### 4. Restaurer la base de données

Un backup de la base de données est fourni à la racine du projet `ExpressVoituresDb.bak`. Pour restaurer cette base de données :

1. Ouvrez SQL Server Management Studio (SSMS).
2. Connectez-vous à `(localdb)\mssqllocaldb` avec **l'authentification Windows**.
3. Cliquez droit sur **Bases de données** et sélectionnez **Restaurer la base de données...**.
4. Dans la fenêtre de restauration, sélectionnez **Support**, cliquez sur **...** puis **Ajouter**.
5. Parcourez jusqu'à l'emplacement du fichier de backup (`.bak`) fourni dans le projet et sélectionnez-le.
6. Complétez le processus de restauration en suivant les instructions à l'écran.

### 5. Mettre à jour la chaîne de connexion

Si vous avez utilisé un nom de base de données différent lors de la restauration, mettez à jour la chaîne de connexion dans `appsettings.json` en conséquence. Par exemple :

```json
"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=NomDeVotreBaseDeDonnees;Trusted_Connection=True;MultipleActiveResultSets=true"
```

### 6. Exécuter l'application

Appuyez sur **F5** pour démarrer l'application.

### 7. Connexion en tant qu'administrateur

Pour vous connecter en tant qu'administrateur dans l'application, utilisez les identifiants suivants :

- **Email** : `admin@email.com`
- **Mot de passe** : `9vBZBB.QH83GeE.`

### 8. Résolution des problèmes de connexion

Si vous avez des difficultés à vous connecter, essayez d’abord de vous connecter à l’aide de Microsoft SQL Server Management Studio (assurez-vous que le type d’authentification est « Authentification Windows »), ou consultez le site [What's my SQL Server Name?](https://sqlserver-help.com/2011/06/19/help-whats-my-sql-server-name/).
