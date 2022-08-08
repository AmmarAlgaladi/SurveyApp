using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        Task<UserDTO> GetUserAsync(string username);
        Task<AppUser> GetUserByUsernameAsync(string username);
    }
}