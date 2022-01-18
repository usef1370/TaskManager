using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cornea.Domain.Entities
{
    public partial class LoginInfo
    {
        [Key]
        public long UserId { get; set; }
        public virtual Roles Role { get; set; }
        public long RoleId { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }
        [Column(TypeName = "date")]
        public DateTime? HireDay { get; set; }
        public string Imagedir { get; set; }
        public string Position { get; set; }
        public string University { get; set; }
        public string DegreeLevel { get; set; }
        public string Company { get; set; }
        public string Specialization { get; set; }
        public string Country { get; set; }
        public string LastjobDescription { get; set; }
        public string StartEducationTime { get; set; }
        public string FinishEducationTime { get; set; }
        public string StartLastjobTime { get; set; }
        public string FinishLastjobTime { get; set; }
        public string AdditionalInfo { get; set; }
        public string Resumedir { get; set; }
    }
}
