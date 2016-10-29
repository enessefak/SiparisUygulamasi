namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Comments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comments()
        {
            Comments1 = new HashSet<Comments>();
        }

        [Key]
        public int CommentId { get; set; }

        [StringLength(100)]
        public string CommentName { get; set; }

        [StringLength(500)]
        public string CommentDesc { get; set; }

        public int? LikeCount { get; set; }

        public int? DisLikeCount { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int? CommentParentId { get; set; }

        public int? UserId { get; set; }

        public int? PageId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments1 { get; set; }

        public virtual Comments Comments2 { get; set; }

        public virtual Pages Pages { get; set; }

        public virtual Users Users { get; set; }
    }
}
