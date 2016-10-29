namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Roles()
        {
            UsersAndUserRoles = new HashSet<UsersAndUserRoles>();
        }

        [Key]
        public int RoleId { get; set; }

        [StringLength(100)]
        public string RoleName { get; set; }

        [StringLength(200)]
        public string RoleDesc { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersAndUserRoles> UsersAndUserRoles { get; set; }
    }
}
