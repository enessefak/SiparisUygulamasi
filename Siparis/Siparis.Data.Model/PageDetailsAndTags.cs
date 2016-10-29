namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PageDetailsAndTags
    {
        [Key]
        public int PageDetailTagId { get; set; }

        public int? PageDetailId { get; set; }

        public int? PageTagId { get; set; }

        public virtual PageDetails PageDetails { get; set; }

        public virtual Tags Tags { get; set; }
    }
}
