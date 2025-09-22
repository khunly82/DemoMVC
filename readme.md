# Utiliser EntityFramework en ASP

1. Installer les Packages Nuggets
	- Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.Tools (si on a besoin de faire des migrations)
	- Microsoft.EntityFrameworkCore.SqlServer (en fonction des besoins)
2. Créer les entités (classes qui représente les tables)
3. Ajouter les propriétés de navigation
4. Créer le DbContext
```cs
	public class MyContext(DbContextOptions options): DbContext(options){
		// ajout des DbSets
		public DbSet<Product> Products {get; set;}
        }
````
5. Ajouter les PrimaryKeys et les ForeignKeys
	- Avec des attributs [Key], [ForeignKey]
	- Ou avec des fichiers de configuration
6. Modifier le fichiers Program.cs pour ajouter de DbContext
```cs
	builder.Services.AddDbContext<MyContext>(o => o.UseSqlServer("votre connection string"));
```
Gestion des migrations
Dans outils -> nugget package manager console 

- Créer une migration
	add-migration [nomDeLaMigration]
- Retirer la dernière migration
	remove-migration
- Retirer toutes les migrations jusqu'à ... (comprises)
	remove-migration [nomDeLaMigration]
- Mettre à jour la db
	update-database [nomDeLaMigration(facultatif)]
- Supprimer la db
	drop-database

