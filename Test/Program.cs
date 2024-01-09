
using Grpc.Net.Client;
using AuthService;
using PlayerService;
using PlaylistService;

var authChannel = GrpcChannel.ForAddress("http://localhost:5264");
var authClient =  new Auth.AuthClient(authChannel);
var channel = GrpcChannel.ForAddress("http://localhost:5006");
var client = new Play.PlayClient(channel);
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
    //test5
    var task23 = new Music()
    {
        Id = 1
    };
    var r =await  client.GetMusicPathAsync(task23);
    Console.Write(r.Uri);
}
catch (Exception ex)
{
    Console.Write(ex.Message);
}