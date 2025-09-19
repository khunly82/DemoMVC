using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        public string Message { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }



    }
}
