using Microsoft.IdentityModel.Tokens;

namespace Exo.WebApi.Controllers
{
    internal class Signingcredentials : SigningCredentials
    {
        public Signingcredentials(SecurityKey key, string algorithm) : base(key, algorithm)
        {
        }
    }
}