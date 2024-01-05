
using Grpc.Net.Client;
using AuthService;
using PlaylistService;

var authChannel = GrpcChannel.ForAddress("http://localhost:5264");
var authClient =  new Auth.AuthClient(authChannel);
var channel = GrpcChannel.ForAddress("http://localhost:5116");
var client = new Playlist.PlaylistClient(channel);
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
    var task23 = new IdPlaylist()
    {
        JwtUser = t.Jwt,
        Id = 2
    };
    var r =await  client.DeletePlaylistAsync(task23);
    Console.Write(r.JwtUser);
}
catch (Exception ex)
{
    Console.Write(ex.Message);
}