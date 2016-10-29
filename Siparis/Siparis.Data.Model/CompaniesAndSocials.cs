namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CompaniesAndSocials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompaniesAndSocials()
        {
            UsersAndSocials = new HashSet<UsersAndSocials>();
        }

        [Key]
        public int CompaniesAndSocialId { get; set; }

        public int? SocialId { get; set; }

        public int? CompanyId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public virtual Companies Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersAndSocials> UsersAndSocials { get; set; }
    }
}
