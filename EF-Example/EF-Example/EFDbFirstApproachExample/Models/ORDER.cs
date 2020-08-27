namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORDERS")]
    public partial class ORDER
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORDERS_ID { get; set; }

        public int? CUS_ID { get; set; }

        [StringLength(30)]
        public string PRODUCT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ORDER_NUMBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime ORDER_DATE { get; set; }

        [StringLength(200)]
        public string Order_details { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }
    }
}
