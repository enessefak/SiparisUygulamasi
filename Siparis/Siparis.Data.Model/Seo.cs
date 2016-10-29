namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seo")]
    public partial class Seo
    {
        public int SeoId { get; set; }

        [StringLength(160)]
        public string SeoDescription { get; set; }

        public int? SeoRobotsStatuId { get; set; }

        [StringLength(200)]
        public string SeoKeyword { get; set; }

        public int? PageId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public virtual Pages Pages { get; set; }

        public virtual PagesRobotsStatus PagesRobotsStatus { get; set; }
    }
}
