namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PageDetailMediaFiles
    {
        [Key]
        public int PageDetailMediaFileId { get; set; }

        [StringLength(100)]
        public string MediaFileTitle { get; set; }

        [StringLength(400)]
        public string MediaFileDesc { get; set; }

        [StringLength(400)]
        public string MediaFilePath { get; set; }

        public int? MediaFileLike { get; set; }

        public int? MediaFileDisLike { get; set; }

        public int? UserId { get; set; }

        public int? MediaFileTypeId { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public byte IsActive { get; set; }

        public int? PageDetailId { get; set; }

        public virtual MediaFileTypes MediaFileTypes { get; set; }

        public virtual PageDetails PageDetails { get; set; }

        public virtual Users Users { get; set; }
    }
}
