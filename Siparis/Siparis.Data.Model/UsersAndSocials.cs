namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsersAndSocials
    {
        [Key]
        public int UsersAndSocialId { get; set; }

        public int? SocialId { get; set; }

        public int? UserId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public virtual CompaniesAndSocials CompaniesAndSocials { get; set; }

        public virtual Socials Socials { get; set; }

        public virtual Users Users { get; set; }
    }
}
