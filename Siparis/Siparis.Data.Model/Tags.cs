namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tags
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tags()
        {
            PageDetailsAndTags = new HashSet<PageDetailsAndTags>();
        }

        [Key]
        public int TagId { get; set; }

        [StringLength(200)]
        public string TagName { get; set; }

        [StringLength(300)]
        public string TagDesc { get; set; }

        [StringLength(100)]
        public string TagLink { get; set; }

        public int? TagLinkTargetTypeId { get; set; }

        public int IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int? TagClickedCount { get; set; }

        public int? TagSortOrderId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageDetailsAndTags> PageDetailsAndTags { get; set; }

        public virtual TagLinkTargetTypes TagLinkTargetTypes { get; set; }
    }
}
