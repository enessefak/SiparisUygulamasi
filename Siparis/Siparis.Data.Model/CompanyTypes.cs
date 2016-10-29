namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class CompanyTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyTypes()
        {
            Companies = new HashSet<Companies>();
        }

        [Key]
        public int CompanyTypeId { get; set; }

        [StringLength(100)]
        public string CompnayTypeName { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public byte IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Companies> Companies { get; set; }
    }
}
