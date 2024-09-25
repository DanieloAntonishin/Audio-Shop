using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AudioShop.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Uncorrect Login")]
        public string Login { get; set; }
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Password has wrong lenght (4-10 symbol)")]
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Passwords are not equal")]
        public string ConfirmPassword { get; set; }
        public char Role { get; set; } = 'C';
        public double SpentMoney { get; set; }
        public int Discount { get; set; }
    }
    public class AccountModelSignUp
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Uncorrect Login")]
        public string Login { get; set; }
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Password has wrong lenght (4-10 symbol)")]
        [Required]
        public string Password { get; set; }
        public char Role { get; set; } = 'C';
    }
}
