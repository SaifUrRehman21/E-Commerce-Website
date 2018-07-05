using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Store.Models
{
    public enum Gender
    {
        Male = 1, Female = 2
    }
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Role")]
        public string Role { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public Gender Gender { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [DataType(DataType.Password)]
        public string ConformPassword { get; set; }
    }
}