using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using PlaylistService.Context;

namespace PlaylistService;

public class AuthOptions
{
    public const string ISSUER = "MyAuthServer"; // издатель токена
    public const string AUDIENCE = "MyAuthClient"; // потребитель токена
    const string KEY = "CoffeeLoveCookies123!SuperSecret";   // ключ для шифрации
    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
    }

    public static Entities.User ReturnUserFromJwt(string jwt, MyDbContext _db)
    {
        jwt = jwt.Replace("Bearer ", "");
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.ReadJwtToken(jwt);//считываем токен
        var claim = token.Claims.First(c => c.Type == ClaimTypes.Name).Value;
        var idLoginPassword = _db.LoginPasswords.First(x => x.Login == claim).IdLoginPassword;
        var user = _db.Users.First(x => x.IdLoginPassword == idLoginPassword);
        return user;
    }
}