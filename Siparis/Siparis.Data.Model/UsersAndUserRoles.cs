namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UsersAndUserRoles
    {
        [Key]
        public int UsersAndRolesId { get; set; }

        public int? RoleId { get; set; }

        public int? UserId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public virtual Roles Roles { get; set; }

        public virtual Users Users { get; set; }
    }
}
