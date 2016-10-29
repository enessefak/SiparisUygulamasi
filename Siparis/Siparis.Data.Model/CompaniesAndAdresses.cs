namespace Siparis.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CompaniesAndAdresses
    {
        public int CompaniesAndAdressesId { get; set; }

        public int? CompanyId { get; set; }

        public int? AdressId { get; set; }

        public byte IsActive { get; set; }

        public DateTime CreateDateTime { get; set; }

        public virtual Addresses Addresses { get; set; }

        public virtual Companies Companies { get; set; }
    }
}
