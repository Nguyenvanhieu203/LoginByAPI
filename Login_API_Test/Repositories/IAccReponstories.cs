using Login_API_Test.Models;
using Microsoft.AspNetCore.Identity;

namespace Login_API_Test.Repositories
{
    public interface IAccReponstories
    {
        public Task<IdentityResult> SignUpAscync(SignUpModel model);
        public Task<string> SignIpAscync(SignInModel model);
    }
}
