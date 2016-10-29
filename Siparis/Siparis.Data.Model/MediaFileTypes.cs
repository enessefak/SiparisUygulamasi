namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class MediaFileTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MediaFileTypes()
        {
            PageDetailMediaFiles = new HashSet<PageDetailMediaFiles>();
        }

        [Key]
        public int MediaFileTypeId { get; set; }

        [StringLength(100)]
        public string MediaFileType { get; set; }

        [StringLength(10)]
        public string MediaFileMimeExtension { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public byte IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PageDetailMediaFiles> PageDetailMediaFiles { get; set; }
    }
}
