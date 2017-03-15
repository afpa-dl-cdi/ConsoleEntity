namespace ConsoleEntity
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class CommandeContext : DbContext
	{
		public CommandeContext()
			: base("name=CommandeContext")
		{
		}

		public virtual DbSet<client> clients { get; set; }
		public virtual DbSet<commande> commandes { get; set; }
		public virtual DbSet<produit> produits { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<client>()
				.Property(e => e.nom)
				.IsUnicode(false);

			modelBuilder.Entity<client>()
				.Property(e => e.prenom)
				.IsUnicode(false);

			modelBuilder.Entity<client>()
				.Property(e => e.adresse)
				.IsUnicode(false);

			modelBuilder.Entity<client>()
				.Property(e => e.code_postal)
				.IsUnicode(false);

			modelBuilder.Entity<client>()
				.HasMany(e => e.commandes)
				.WithRequired(e => e.client)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<commande>()
				.HasMany(e => e.produits)
				.WithMany(e => e.commandes)
				.Map(m => m.ToTable("comprend").MapLeftKey("id_commande").MapRightKey("id_produit"));

			modelBuilder.Entity<produit>()
				.Property(e => e.nom)
				.IsUnicode(false);

			modelBuilder.Entity<produit>()
				.Property(e => e.description)
				.IsUnicode(false);

			modelBuilder.Entity<produit>()
				.Property(e => e.prix)
				.HasPrecision(8, 2);
		}
	}
}
