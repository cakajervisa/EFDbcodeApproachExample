namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ndimeBarcode")]
    public partial class ndimeBarcode
    {
        public int? id { get; set; }

        [Key]
        [StringLength(20)]
        public string barcode { get; set; }
    }
}
