namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PageFields
    {
        [Key]
        public int PageFieldId { get; set; }

        [StringLength(100)]
        public string PageFieldName { get; set; }

        [StringLength(200)]
        public string PageFiledDesc { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int? PageId { get; set; }

        public int? PageFieldSortOrderId { get; set; }

        public virtual Pages Pages { get; set; }
    }
}
