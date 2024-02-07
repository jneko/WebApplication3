using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WebApplication3.ViewModels
{
    public class Register
    {
        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string LastName { get; set; }

		[Required]
		[DataType(DataType.CreditCard)]
        [RegularExpression(@"^\d{15,16}$", ErrorMessage ="Please enter a valid credit card number")]
		public string CreditCard { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[89]\d{7}$", ErrorMessage ="Please enter a valid phone number")]

        public string PhoneNumber { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string BillingAddress { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string ShippingAddress { get; set; }

		[Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*!])[A-Za-z\d@#$%^&*!]{12,}$", ErrorMessage = "Your password needs to be at least 12 characters long, have upper and lower case letters, numbers and special characters.")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password and confirmation password does not match")]
        public string ConfirmPassword { get; set; }





	}
}
