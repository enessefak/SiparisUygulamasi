namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Companies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Companies()
        {
            CompaniesAndAdresses = new HashSet<CompaniesAndAdresses>();
            CompaniesAndNumbers = new HashSet<CompaniesAndNumbers>();
            CompaniesAndSocials = new HashSet<CompaniesAndSocials>();
        }

        [Key]
        public int CompanyId { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(100)]
        public string CompanyDesc { get; set; }

        public int? CompanyParentId { get; set; }

        [StringLength(100)]
        public string CompanyLogo { get; set; }

        [StringLength(100)]
        public string ComponyLogo2 { get; set; }

        public int? CompanyTypeId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public byte IsActive { get; set; }

        public int? CompanySortOrderId { get; set; }

        public virtual CompanyTypes CompanyTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompaniesAndAdresses> CompaniesAndAdresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompaniesAndNumbers> CompaniesAndNumbers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompaniesAndSocials> CompaniesAndSocials { get; set; }
    }
}
