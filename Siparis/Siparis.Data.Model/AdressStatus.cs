namespace Siparis.Data.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AdressStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdressStatus()
        {
            Addresses = new HashSet<Addresses>();
        }

        [Key]
        public int StatuId { get; set; }

        [StringLength(100)]
        public string StatuName { get; set; }

        [StringLength(100)]
        public string StatuDesc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}
