namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CompaniesAndNumbers
    {
        public int CompaniesAndNumbersId { get; set; }

        public int? CompanyId { get; set; }

        public int? NumberId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public virtual Companies Companies { get; set; }

        public virtual Numbers Numbers { get; set; }
    }
}
