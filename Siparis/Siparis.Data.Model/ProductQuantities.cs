namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductQuantities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductQuantities()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int ProductQuantityId { get; set; }

        [StringLength(10)]
        public string ProductQuantityName { get; set; }

        [StringLength(10)]
        public string ProductQuantityShortName { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreateDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
