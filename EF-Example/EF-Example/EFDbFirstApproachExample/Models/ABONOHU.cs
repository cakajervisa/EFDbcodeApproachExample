namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ABONOHU")]
    public partial class ABONOHU
    {
        [Key]
        [StringLength(50)]
        public string EMAIL { get; set; }
    }
}
