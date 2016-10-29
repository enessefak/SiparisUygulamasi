namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            Comments = new HashSet<Comments>();
            PageCategories = new HashSet<PageCategories>();
            PageDetailMediaFiles = new HashSet<PageDetailMediaFiles>();
            PageDetails = new HashSet<PageDetails>();
            Pages = new HashSet<Pages>();
            UserAndNumbers = new HashSet<UserAndNumbers>();
            UserDetails = new HashSet<UserDetails>();
            UsersAndAdresses = new HashSet<UsersAndAdresses>();
            UsersAndSocials = new HashSet<UsersAndSocials>();
            UsersAndUserRoles = new HashSet<UsersAndUserRoles>();
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string UserPassword { get; set; }

        [StringLength(100)]
        public string UserEmail { get; set; }

        [StringLength(100)]
        public string UserFirstName { get; set; }

        [StringLength(100)]
        public string UserLastName { get; set; }

        [Required]
        [StringLength(10)]
        public string UserImage { get; set; }

        public int UserParentId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageCategories> PageCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageDetailMediaFiles> PageDetailMediaFiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageDetails> PageDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pages> Pages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAndNumbers> UserAndNumbers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDetails> UserDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersAndAdresses> UsersAndAdresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersAndSocials> UsersAndSocials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersAndUserRoles> UsersAndUserRoles { get; set; }
    }
}
