namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PageDetailFields
    {
        [Key]
        public int PageDetailFieldId { get; set; }

        [StringLength(100)]
        public string PageDetailFieldName { get; set; }

        [StringLength(200)]
        public string PageDetailFieldDesc { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int? PageDetailId { get; set; }

        public int? PageDetailSortOrderId { get; set; }

        public virtual PageDetails PageDetails { get; set; }
    }
}
