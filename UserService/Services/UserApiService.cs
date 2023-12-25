using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using UserService.Context;
using UserService.Entities;

namespace UserService.Services;

public class UserApiService:User.UserBase
{
    private ILogger<UserApiService> _logger;
    private MyDbContext _db;
    public UserApiService(ILogger<UserApiService>logger, MyDbContext db)
    {
        _logger = logger;
        _db = db;
    }
    public override Task<UserInfo>? Me(Token request, ServerCallContext context)
    {
        try
        {
            var user = AuthOptions.ReturnUserFromJwt(request.Jwt, _db);
            return Task.FromResult(new UserInfo()
            {
                Age = Convert.ToInt32(user.Age),
                Email = user.Email,
                Name = user.Name,
                Phone = user.Phone,
                Role = _db.Roles.First(x => x.IdRole == user.IdRole).Name
            });
        }
        catch (Exception ex)
        {
            return null;
        }
        
    }

    public override Task<Token> LogOut(Token request, ServerCallContext context)
    {
        return Task.FromResult(new Token() { Jwt = "" });
    }

    public override Task<FullUserInfo>? ChangeFullUserInfo(ChangeInfo request, ServerCallContext context)
    {
        try
        {
            var user = AuthOptions.ReturnUserFromJwt(request.Token.Jwt, _db);
            var loginpassid = AuthOptions.ReturnUserFromJwt(request.Token.Jwt, _db).IdLoginPassword;
            var loginpass = _db.LoginPasswords.First(x => x.IdLoginPassword == loginpassid);
            loginpass.Login = request.UserInfo.LogPasswords.Login;
            loginpass.Password = request.UserInfo.LogPasswords.Password;
            _db.LoginPasswords.Update(loginpass);
            _db.SaveChanges();
            user.Age = request.UserInfo.UserInfo.Age;
            user.Email = request.UserInfo.UserInfo.Email;
            user.Name = request.UserInfo.UserInfo.Name;
            user.Phone = request.UserInfo.UserInfo.Phone;
            _db.Users.Update(user);
            _db.SaveChanges();
            return Task.FromResult(new FullUserInfo());
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}