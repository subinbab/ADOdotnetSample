using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObject
{
    public class UserRegisterModel
    {
        public int id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string firstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string lastName { get; set; }
        [Required]
        [DisplayName("Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        public string email { get; set; }
        [Required]
        [DisplayName("Password")]
        [RegularExpression(@"^([a-zA-Z0-9@*#]{8,15})$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase      Alphabet, 1 Number and 1 Special Character")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [DisplayName("Comnfirm Password")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }

    }
}
