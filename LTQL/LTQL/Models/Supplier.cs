namespace LTQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplier
    {
        [StringLength(20)]
        public string SupplierID { get; set; }

        public string SupplierName { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }
    }
}
