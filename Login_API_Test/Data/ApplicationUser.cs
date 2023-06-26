using Microsoft.AspNetCore.Identity;

namespace Login_API_Test.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
