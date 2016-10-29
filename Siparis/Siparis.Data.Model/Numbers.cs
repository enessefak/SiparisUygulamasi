namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Numbers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Numbers()
        {
            CompaniesAndNumbers = new HashSet<CompaniesAndNumbers>();
            UserAndNumbers = new HashSet<UserAndNumbers>();
        }

        [Key]
        public int NumberId { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        public int? NumberTypeId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompaniesAndNumbers> CompaniesAndNumbers { get; set; }

        public virtual NumberTypes NumberTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAndNumbers> UserAndNumbers { get; set; }
    }
}
