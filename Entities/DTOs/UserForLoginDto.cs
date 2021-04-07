using Core.Entities;

namespace Entities.DTOs
{
    //Login olmak isteyen bir kişi
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
