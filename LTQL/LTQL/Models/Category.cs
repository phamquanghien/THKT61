namespace LTQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        public string CategoryID { get; set; }

        public string CategoryName { get; set; }

        public bool IsActive { get; set; }
    }
}
