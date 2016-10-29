namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PageCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PageCategories()
        {
            PageCategories1 = new HashSet<PageCategories>();
        }

        [Key]
        public int PageCategoryId { get; set; }

        [StringLength(200)]
        public string PageCategoryName { get; set; }

        public int? PageCategoryParentId { get; set; }

        public int? PageCategorySortOrderId { get; set; }

        public int? UserId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int? PageId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageCategories> PageCategories1 { get; set; }

        public virtual PageCategories PageCategories2 { get; set; }

        public virtual Pages Pages { get; set; }

        public virtual Users Users { get; set; }
    }
}
