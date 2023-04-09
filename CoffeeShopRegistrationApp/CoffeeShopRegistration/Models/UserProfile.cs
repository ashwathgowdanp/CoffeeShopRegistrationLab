using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CoffeeShopRegistration.Models
{
    public class UserProfile
    {
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a valid password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(16)]
        public string Password { get; set; }
    }
}
