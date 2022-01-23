using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cornea.Site.Models
{
    public class SigninViewModel
    {
        [Required(ErrorMessage = "نام کاربری را وارد کنید")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "گذرواژه را وارد کنید")]
        public string Password { get; set; }
    }
}
