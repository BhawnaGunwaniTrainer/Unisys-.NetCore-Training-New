using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace coreMvcProject.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Please enter Id.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter age.")]
        [Range(18,100, ErrorMessage = "Age must be between 18 and 100")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please enter email.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter phone number.")]
        [Phone(ErrorMessage = "Invalid Phone Numbeer")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please select birthdate.")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
