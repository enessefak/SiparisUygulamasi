namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            ProductFields = new HashSet<ProductFields>();
        }

        [Key]
        public int ProductId { get; set; }

        [StringLength(200)]
        public string ProductName { get; set; }

        [StringLength(200)]
        public string ProductDesc { get; set; }

        [Column(TypeName = "money")]
        public decimal? ProductPrice { get; set; }

        [StringLength(10)]
        public string ProductDiscount { get; set; }

        public int? ProductSortOrderId { get; set; }

        public int? ProductQuantityId { get; set; }

        public int? ProductCategoryId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public virtual ProductCategories ProductCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductFields> ProductFields { get; set; }

        public virtual ProductQuantities ProductQuantities { get; set; }
    }
}
