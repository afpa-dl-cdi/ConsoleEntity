namespace ConsoleEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CommandesContext : DbContext
    {
        public CommandesContext()
            : base("name=CommandesContext")
        {
        }

        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<commande> commandes { get; set; }
        public virtual DbSet<comprend> comprends { get; set; }
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

            modelBuilder.Entity<commande>()
                .HasMany(e => e.clients)
                .WithRequired(e => e.commande)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<commande>()
                .HasMany(e => e.comprends)
                .WithRequired(e => e.commande)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.prix)
                .HasPrecision(25, 0);

            modelBuilder.Entity<produit>()
                .HasMany(e => e.comprends)
                .WithRequired(e => e.produit)
                .WillCascadeOnDelete(false);
        }
    }
}
