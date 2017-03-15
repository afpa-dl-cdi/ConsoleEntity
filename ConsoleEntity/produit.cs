namespace ConsoleEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("produit")]
    public partial class produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produit()
        {
            commandes = new HashSet<commande>();
        }

        [Key]
        public int id_produit { get; set; }

        [Required]
        [StringLength(25)]
        public string nom { get; set; }

        [Required]
        [StringLength(400)]
        public string description { get; set; }

        public decimal prix { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commande> commandes { get; set; }
    }
}
