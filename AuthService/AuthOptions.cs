using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using UserService.Context;

namespace UserService;

public class AuthOptions
{
    public const string ISSUER = "MyAuthServer"; // издатель токена
    public const string AUDIENCE = "MyAuthClient"; // потребитель токена
    const string KEY = "CoffeeLoveCookies123!SuperSecret";   // ключ для шифрации
    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
    }
    

}