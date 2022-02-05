using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cornea.Site.Areas.Admin.Models
{
    public class ProfileViewModel
    {
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? HireDay { get; set; }
        public IFormFile Imagedir { get; set; }
        public string Position { get; set; }
        public string University { get; set; }
        public string DegreeLevel { get; set; }
        public string Company { get; set; }
        public string Specialization { get; set; }
        public string LastjobDescription { get; set; }
        public string StartEducationTime { get; set; }
        public string FinishEducationTime { get; set; }
        public string StartLastjobTime { get; set; }
        public string FinishLastjobTime { get; set; }
        public string AdditionalInfo { get; set; }
        public IFormFile[] Resumedir { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Repeatpassword { get; set; }

    }
}
