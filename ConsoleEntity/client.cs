namespace ConsoleEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("client")]
    public partial class client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public client()
        {
            commandes = new HashSet<commande>();
        }

        [Required]
        [StringLength(40)]
        public string nom { get; set; }

        [Key]
        public int id_client { get; set; }

        [Required]
        [StringLength(25)]
        public string prenom { get; set; }

        [Required]
        [StringLength(400)]
        public string adresse { get; set; }

        [Required]
        [StringLength(25)]
        public string code_postal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commande> commandes { get; set; }
    }
}
