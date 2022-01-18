using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Models.ViewModels.AuthenticationViewModel
{
    public class SignupViewModel
    {
        public string Email { get; set; }
        public string UserName { get; set; } 
        public string Password{ get; set; }
        public string RePassword{ get; set; }
     }
}
