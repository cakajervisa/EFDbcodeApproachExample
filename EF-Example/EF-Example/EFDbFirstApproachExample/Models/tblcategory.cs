namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblcategory")]
    public partial class tblcategory
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(20)]
        public string Category { get; set; }

        [StringLength(20)]
        public string CategoryType { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }
    }
}
