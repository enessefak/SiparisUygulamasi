namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PageDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PageDetails()
        {
            PageDetailFields = new HashSet<PageDetailFields>();
            PageDetailMediaFiles = new HashSet<PageDetailMediaFiles>();
            PageDetailsAndTags = new HashSet<PageDetailsAndTags>();
        }

        [Key]
        public int PageDetailId { get; set; }

        [Column(TypeName = "ntext")]
        public string PageDetailText { get; set; }

        [StringLength(100)]
        public string PageDetailTitle { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int? PageId { get; set; }

        public int? UserId { get; set; }

        public int? PageDetailSortOrderId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageDetailFields> PageDetailFields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageDetailMediaFiles> PageDetailMediaFiles { get; set; }

        public virtual Pages Pages { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageDetailsAndTags> PageDetailsAndTags { get; set; }
    }
}
