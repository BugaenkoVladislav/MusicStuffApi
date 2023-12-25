using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using UserService;
using UserService.Context;
using UserService.Entities;

namespace AuthService.Services;

public class AuthApiService:Auth.AuthBase
{
    private ILogger<AuthApiService> _logger;
    private MyDbContext _db;
    public AuthApiService(ILogger<AuthApiService> logger, MyDbContext db)
    {
        _logger = logger;
        _db = db;
    }
    public override Task<Token>? SignIn(LogPass request, ServerCallContext context)
    {
        try
        {
            long? loginPassword = _db.LoginPasswords
                .FirstOrDefault(x => x.Login == request.Login && x.Password == request.Password)?.IdLoginPassword;
            if (loginPassword is null)
            {
                return null;
            }
            var user = _db.Users.First(x => x.IdLoginPassword == loginPassword);
            
            var role = user.IdRole == 1 ? "Admin" : "User";
            var claims = new List<Claim> {
                new Claim(ClaimTypes.Name, _db.LoginPasswords.First(x=>x.IdLoginPassword==user.IdLoginPassword).Login),
                new Claim(ClaimTypes.Role, role)};
            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                claims: claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromDays(10)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt); 
            encodedJwt = "Bearer " + encodedJwt;
            return Task.FromResult(new Token() { Jwt = encodedJwt });
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public override Task<FullUserInfo>? SignUp(FullUserInfo request, ServerCallContext context)
    {
        try
        {
            _db.LoginPasswords.Add(new LoginPassword()
            {
                Login = request.LogPasswords.Login,
                Password = request.LogPasswords.Password
            });
            _db.SaveChanges();
            _db.Users.Add(new User()
            {
                IdRole = 2,
                Age = request.Age,
                Email = request.Email,
                IdLoginPassword = _db.LoginPasswords.First(x => x.Login == request.LogPasswords.Login).IdLoginPassword,
                Name = request.Name,
                Phone = request.Phone
            });
            _db.SaveChanges();
        }
        catch (Exception ex)
        {
            return null;
        }
        return Task.FromResult(new FullUserInfo());
    }
}