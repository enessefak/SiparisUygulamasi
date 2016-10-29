namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserAndNumbers
    {
        [Key]
        public int UsersAndNumbersId { get; set; }

        public int? UserId { get; set; }

        public int? NumberId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public virtual Numbers Numbers { get; set; }

        public virtual Users Users { get; set; }
    }
}
