using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using PlayerService.Context;

namespace PlayerService.Services;

public class Player:Play.PlayBase
{
    private ILogger<Player> _logger;
    private MyDbContext _db;

    public Player(ILogger<Player> logger, MyDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public override Task<Music> GetMusicPath(Music request, ServerCallContext context)
    {
        try
        {
            var path = _db.Musics.First(x => x.IdMusic == request.Id).Path;
            context.Status = new Status(StatusCode.OK, "Success");
            return Task.FromResult(new Music() { Id = request.Id, Uri = path });
        }
        catch (Exception ex)
        {
            context.Status = new Status(StatusCode.Unknown, ex.Message);
            return Task.FromResult(new Music());
        }
    }
}