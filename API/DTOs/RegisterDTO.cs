using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }
    }
}