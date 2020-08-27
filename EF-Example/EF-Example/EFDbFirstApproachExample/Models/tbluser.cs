namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbluser")]
    public partial class tbluser
    {
        [Key]
        [Column(Order = 0)]
        public int UserId { get; set; }

        [StringLength(50)]
        public string Fullname { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string User_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(60)]
        public string Pass { get; set; }

        [StringLength(50)]
        public string UserRole { get; set; }

        [StringLength(100)]
        public string Status { get; set; }
    }
}
