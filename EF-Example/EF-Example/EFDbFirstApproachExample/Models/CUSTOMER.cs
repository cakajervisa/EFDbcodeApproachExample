namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTOMER")]
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            ORDERS = new HashSet<ORDER>();
        }

        [Key]
        public int CUS_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string CUS_FIRST_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string CUS_LAST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string ADDRESS_1 { get; set; }

        [Required]
        [StringLength(20)]
        public string CITY { get; set; }

        public int POST_CODE { get; set; }

        public int PHONE { get; set; }

        [Required]
        [StringLength(20)]
        public string PASWORD { get; set; }

        [Required]
        [StringLength(10)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDERS { get; set; }
    }
}
