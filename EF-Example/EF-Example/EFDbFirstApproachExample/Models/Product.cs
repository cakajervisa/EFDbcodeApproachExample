namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public long ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public decimal? Price { get; set; }

        public DateTime? DateOfPurchase { get; set; }

        [StringLength(50)]
        public string AvailabilityStatus { get; set; }

        public long? CategoryID { get; set; }

        public long? BrandID { get; set; }

        public bool? Active { get; set; }

        [MaxLength(1)]
        public byte[] Photo { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Category Category { get; set; }
    }
}
