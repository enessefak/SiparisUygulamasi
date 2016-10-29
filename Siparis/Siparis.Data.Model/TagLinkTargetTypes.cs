namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TagLinkTargetTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TagLinkTargetTypes()
        {
            Tags = new HashSet<Tags>();
        }

        [Key]
        public int TagLinkTargetTypeId { get; set; }

        [StringLength(100)]
        public string LinkTarget { get; set; }

        public byte IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tags> Tags { get; set; }
    }
}
