namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductFields
    {
        [Key]
        public int ProductFieldId { get; set; }

        [StringLength(100)]
        public string ProductFieldName { get; set; }

        [StringLength(300)]
        public string ProductFieldDesc { get; set; }

        public int? ProductFieldSortOrderId { get; set; }

        public int? ProductId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreateDateTime { get; set; }

        public virtual Products Products { get; set; }
    }
}
