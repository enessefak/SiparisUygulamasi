namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Addresses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Addresses()
        {
            Addresses1 = new HashSet<Addresses>();
            CompaniesAndAdresses = new HashSet<CompaniesAndAdresses>();
            UsersAndAdresses = new HashSet<UsersAndAdresses>();
        }

        [Key]
        public int AdressId { get; set; }

        [StringLength(100)]
        public string AdressName { get; set; }

        [StringLength(400)]
        public string AdressDesc { get; set; }

        [StringLength(200)]
        public string AdressMap { get; set; }

        [StringLength(50)]
        public string AdressZipCode { get; set; }

        public int? AdressParentId { get; set; }

        public int? AdressStatuId { get; set; }

        public DateTime CreateDate { get; set; }

        public byte IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Addresses> Addresses1 { get; set; }

        public virtual Addresses Addresses2 { get; set; }

        public virtual AdressStatus AdressStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompaniesAndAdresses> CompaniesAndAdresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersAndAdresses> UsersAndAdresses { get; set; }
    }
}
