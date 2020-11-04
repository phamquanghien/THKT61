namespace LTQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public string CustomerID { get; set; }

        public string CustomerName { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }
    }
}
