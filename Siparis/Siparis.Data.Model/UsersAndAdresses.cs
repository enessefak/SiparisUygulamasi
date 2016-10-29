namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsersAndAdresses
    {
        [Key]
        public int UserAndAdressesId { get; set; }

        public int? UserId { get; set; }

        public int? AdressId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreateDateTime { get; set; }

        public virtual Addresses Addresses { get; set; }

        public virtual Users Users { get; set; }
    }
}
