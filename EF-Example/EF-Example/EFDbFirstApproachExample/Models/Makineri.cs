namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Makineri")]
    public partial class Makineri
    {
        [Key]
        [Column(Order = 0)]
        public int idMakine { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Nr_serie { get; set; }
    }
}
