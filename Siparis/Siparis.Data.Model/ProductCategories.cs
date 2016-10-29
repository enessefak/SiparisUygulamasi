namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductCategories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductCategories()
        {
            ProductCategories1 = new HashSet<ProductCategories>();
            Products = new HashSet<Products>();
        }

        [Key]
        public int ProductCategoryId { get; set; }

        [StringLength(200)]
        public string ProductCategoryName { get; set; }

        [StringLength(200)]
        public string ProductCategoryDesc { get; set; }

        [StringLength(200)]
        public string ProductCategoryImg { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public byte IsActive { get; set; }

        public int? ProductCategoryParentId { get; set; }

        [StringLength(300)]
        public string MetaKeyword { get; set; }

        [StringLength(160)]
        public string MetaDesc { get; set; }

        public int? ProductCategorySortOrderId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCategories> ProductCategories1 { get; set; }

        public virtual ProductCategories ProductCategories2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
