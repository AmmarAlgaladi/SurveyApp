using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("{username}", Name = "GetUser")]
        public async Task<ActionResult<UserDTO>> GetUser(string username)
        {
            return await _userRepository.GetUserAsync(username);
        }
    }
}