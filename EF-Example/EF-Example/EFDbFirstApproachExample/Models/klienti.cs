namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("klienti")]
    public partial class klienti
    {
        [Key]
        public int idKlienti { get; set; }

        [StringLength(30)]
        public string emer { get; set; }

        public decimal? Borxhi { get; set; }
    }
}
