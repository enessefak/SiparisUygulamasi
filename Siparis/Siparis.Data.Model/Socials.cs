namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Socials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Socials()
        {
            UsersAndSocials = new HashSet<UsersAndSocials>();
        }

        [Key]
        public int SocialId { get; set; }

        [StringLength(100)]
        public string SocialMediaName { get; set; }

        [StringLength(100)]
        public string SocialProfileName { get; set; }

        [StringLength(300)]
        public string SocialMediaLink { get; set; }

        [StringLength(100)]
        public string SocialMediaIcon { get; set; }

        public DateTime CreateDate { get; set; }

        public byte IsActive { get; set; }

        public int? SocialSortOrderId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersAndSocials> UsersAndSocials { get; set; }
    }
}
