

using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string PhotoUrl { get; set; }
        public bool FirstLogin { get; set; } =true;
        public ICollection<AppUserRole> UserRoles { get; set; }
        public ICollection<Survey> Surveys { get; set; }
    }
}