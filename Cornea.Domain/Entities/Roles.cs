using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cornea.Domain.Entities
{
    public partial class Roles
    {
        [Key]
        public long RoleId { get; set; }
        [StringLength(20)]
        public string RoleName { get; set; }
    }
}
