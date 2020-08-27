namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TEMPLATES")]
    public partial class TEMPLATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TEMPLATE()
        {
            CLIENTs = new HashSet<CLIENT>();
        }

        [Key]
        public int ID_T { get; set; }

        [Required]
        [StringLength(50)]
        public string HOLIDAY { get; set; }

        [Required]
        [StringLength(1000)]
        public string MESSAGES_ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENT> CLIENTs { get; set; }
    }
}
