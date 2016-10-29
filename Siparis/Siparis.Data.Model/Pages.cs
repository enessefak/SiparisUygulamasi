namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pages()
        {
            Comments = new HashSet<Comments>();
            PageCategories = new HashSet<PageCategories>();
            PageDetails = new HashSet<PageDetails>();
            PageFields = new HashSet<PageFields>();
            Seo = new HashSet<Seo>();
        }

        [Key]
        public int PageId { get; set; }

        [StringLength(100)]
        public string PageName { get; set; }

        [StringLength(200)]
        public string PageTitle { get; set; }

        [StringLength(160)]
        public string PageDescription { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int? UserId { get; set; }

        public int? PageSortOrderId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageCategories> PageCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageDetails> PageDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageFields> PageFields { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seo> Seo { get; set; }
    }
}
