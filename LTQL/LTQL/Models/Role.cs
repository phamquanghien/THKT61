namespace LTQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role
    {
        [StringLength(20)]
        public string RoleID { get; set; }

        public string RoleName { get; set; }
    }
}
