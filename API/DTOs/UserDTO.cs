using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
         public string Username { get; set; }
        public string PhotoUrl { get; set; }
    }
}