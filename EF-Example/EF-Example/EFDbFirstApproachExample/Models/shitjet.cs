namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shitjet")]
    public partial class shitjet
    {
        [Key]
        public int idshitje { get; set; }

        public DateTime? ora_e_shtijes { get; set; }

        [StringLength(16)]
        public string barcode { get; set; }

        public int? sasine { get; set; }

        [StringLength(23)]
        public string emerProd { get; set; }

        public decimal? cmimi { get; set; }
    }
}
