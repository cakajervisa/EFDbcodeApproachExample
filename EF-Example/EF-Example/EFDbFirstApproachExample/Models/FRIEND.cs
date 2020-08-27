namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FRIENDS")]
    public partial class FRIEND
    {
        [Key]
        public int ID_F { get; set; }

        [Required]
        [StringLength(20)]
        public string NAME { get; set; }

        public int NUMBER { get; set; }

        [Required]
        [StringLength(50)]
        public string HOILIDAY { get; set; }

        [Required]
        [StringLength(1000)]
        public string MESSAGE_ { get; set; }

        public int? ID_K { get; set; }

        public virtual CLIENT CLIENT { get; set; }
    }
}
