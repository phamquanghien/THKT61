namespace LTQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        [StringLength(10)]
        public string Unit { get; set; }

        [StringLength(20)]
        public string SupplierID { get; set; }

        public string Image { get; set; }
    }
}
