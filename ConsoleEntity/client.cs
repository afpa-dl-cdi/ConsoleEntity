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
        [Required]
        [StringLength(40)]
        public string nom { get; set; }

        [Key]
        public int id_client { get; set; }

        [Required]
        [StringLength(25)]
        public string prenom { get; set; }

        [StringLength(400)]
        public string adresse { get; set; }

        [Required]
        [StringLength(25)]
        public string code_postal { get; set; }

        public int id_commande { get; set; }

        public virtual commande commande { get; set; }
    }
}
