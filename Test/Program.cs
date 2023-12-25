using Grpc.Net.Client;
using UserService;
using LogPass = AuthService.LogPass;
using Token = UserService.Token;

var authChannel = GrpcChannel.ForAddress("http://localhost:5264");
var userChannel = GrpcChannel.ForAddress("http://localhost:5117");
var authClient =  new AuthService.Auth.AuthClient(authChannel);
var userClient = new UserService.User.UserClient(userChannel);
try
{
    //test 1
    var logpass = new LogPass()
    {
        Login = "Coff@mail.ru",
        Password = "1234"
    };
    var tokenResponse = await authClient.SignInAsync(logpass);
    
    var token = tokenResponse.Jwt;

    Console.WriteLine(token);
    var t = new Token() { Jwt = token };
    //test2
    Console.WriteLine("-----------------------------------------------------------------");
    var me = await userClient.MeAsync(t);
    Console.WriteLine(me);
    //test3
    var user = new UserInfo()
    {
        Age = 4,
        Email = "1",
        Name = "2",
        Phone = "34"
    };
    var logpass1 = new UserService.LogPass()
    {
        Login = "Coff@mail.ru",
        Password = "1234"
    };
    var fullUserInfo = new UserService.FullUserInfo()
    {
        UserInfo = user,
        LogPasswords = logpass1
    };

    var userUpdate = await userClient.ChangeFullUserInfoAsync(new ChangeInfo()
    {
        Token = t,
        UserInfo = fullUserInfo
    });
    Console.WriteLine(userUpdate);
    //test4
    var jwt = await userClient.LogOutAsync(t);
    Console.WriteLine(jwt);
}
catch (Exception ex)
{
    Console.Write(ex.Message);
}