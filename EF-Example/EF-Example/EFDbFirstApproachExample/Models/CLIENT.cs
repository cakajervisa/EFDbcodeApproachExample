namespace EFDbFirstApproachExample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENT")]
    public partial class CLIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENT()
        {
            FRIENDS = new HashSet<FRIEND>();
            TEMPLATES = new HashSet<TEMPLATE>();
        }

        [Key]
        public int ID_K { get; set; }

        [Required]
        [StringLength(20)]
        public string NAME { get; set; }

        public int NUMBER { get; set; }

        [Required]
        [StringLength(250)]
        public string PASWORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FRIEND> FRIENDS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEMPLATE> TEMPLATES { get; set; }
    }
}
