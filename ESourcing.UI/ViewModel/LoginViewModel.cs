﻿using System.ComponentModel.DataAnnotations;

namespace ESourcing.UI.ViewModel
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage ="Email is required")]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [MinLength(4,ErrorMessage ="Password min 4 must be character")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
}
