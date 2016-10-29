namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserDetails
    {
        [Key]
        public int UserDetailId { get; set; }

        [StringLength(100)]
        public string FieldName { get; set; }

        [StringLength(300)]
        public string FieldDesc { get; set; }

        public int? UserId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public byte IsActive { get; set; }

        public virtual Users Users { get; set; }
    }
}
