namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fatura")]
    public partial class fatura
    {
        [Key]
        public int idfature { get; set; }

        [StringLength(203)]
        public string emer { get; set; }

        public decimal? cmimi { get; set; }

        [StringLength(232)]
        public string barcode { get; set; }

        public int? sasia { get; set; }
    }
}
