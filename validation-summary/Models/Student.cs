using System.ComponentModel.DataAnnotations;

namespace validation_summary.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name Is Must")]
        //[StringLength(15, MinimumLength =3, ErrorMessage ="Name must be with in 3 to 15 characters")]
        [MinLength(3, ErrorMessage = "Minimum Length must be 3 character")]
        [MaxLength(15)]
        public String Name { get; set; }

        [Required(ErrorMessage = "Email Is Must")]
        [RegularExpression("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Age Is Must")]
        [Range(10, 50, ErrorMessage = "Age must be With in 10 to 50")]
        public int? Age { get; set; }

        /*[Required(ErrorMessage = "Password Is Must")]
        [RegularExpression("(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Uppercase,Lowercase,Numbers,Symbols, Min 8 character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Is Must")]
        [Compare("Password", ErrorMessage = "Both Password must be identical")]
        [Display(Name = "Enter Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Phone Number Is Must")]
        [RegularExpression("^[6-9]\\d{9}$", ErrorMessage = "Invalid Mobile Number")]
        public string PNumber { get; set; }

        [Required(ErrorMessage = "Website Url Is Must")]
        [Url(ErrorMessage = "Invalid URL")]
        public string WebsiteUrl { get; set; }*/
    }
}
