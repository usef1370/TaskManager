using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cornea.Site.Models
{
    public class SigninViewModel
    {
        [Required(ErrorMessage = "Please Enter Your Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }
    }
}
