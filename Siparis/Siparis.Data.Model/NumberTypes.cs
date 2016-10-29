namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NumberTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NumberTypes()
        {
            Numbers = new HashSet<Numbers>();
        }

        [Key]
        public int NumberTypeId { get; set; }

        [StringLength(100)]
        public string NumberType { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Numbers> Numbers { get; set; }
    }
}
