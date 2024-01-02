
using Grpc.Net.Client;
using MusicFindService;

var channel = GrpcChannel.ForAddress("http://localhost:5106");
var client = new Find.FindClient(channel);
try
{
    //test
    var task = new Name()
    {
        Name_ = "Nude"

    };
    var work = await client.FindMusicAsync(task);
    Console.Write(work.Music);
}
catch (Exception ex)
{
    Console.Write(ex.Message);
}