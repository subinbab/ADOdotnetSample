using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObject
{
    public class UserLoginModel
    {
        [Required,EmailAddress]
        [Display(Name ="Enter your user name")]
        public string userName { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "Enter your password")]
        public string password { get; set; }
    }
}
