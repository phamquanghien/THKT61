namespace LTQL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string PassWord { get; set; }

        [StringLength(20)]
        public string RoleID { get; set; }

        public bool IsActive { get; set; }

        public bool Status { get; set; }
    }
}
