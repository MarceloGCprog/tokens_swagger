using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using jwt_token.Models;

namespace jwt_token.Gerenciamento_acesso
{
    public class AcessManager
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _sigInManager;

        private SigningConfigurations _SiginConfigurations;

        private TokenConfigurations _tokenConfigurations;        

    }
}