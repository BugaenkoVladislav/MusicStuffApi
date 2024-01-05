using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using MusicFindService.Context;
using MusicFindService.Entities;

namespace MusicFindService.Services;

public class MusicFindApiService:Find.FindBase
{
    private ILogger<MusicFindApiService> _logger;
    private readonly MyDbContext _db;

    public MusicFindApiService(ILogger<MusicFindApiService> logger, MyDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public override Task<ResultAlbum> FindAlbum(Name request, ServerCallContext context)
    {
        var result = new ResultAlbum();
        var music = _db.Albums.Where(x => x.Name.ToLower() == request.Name_.ToLower()).ToList();
        foreach (var i in music)
        {
            result.Albums.Add(new Album()
            {
                Author = _db.Users.First(x=>x.IdUser == i.IdUser).Name,
                Id = i.IdAlbum,
                Name = i.Name,
                Photo = i.Photo
            });
        }

        return Task.FromResult(result);
    }

    public override Task<ResultMusic> FindMusic(Name request, ServerCallContext context){
        var result = new ResultMusic();
        List<Entities.Music> music = _db.Musics.Where(x => x.Name.ToLower() == request.Name_.ToLower()).ToList();
        foreach (var i in music)
        {
            var user = _db.Albums.First(x => x.IdAlbum == i.IdAlbum);
            result.Music.Add(new Music()
            {
                Author = user.Name,
                Id = i.IdMusic,
                NameMusic = i.Name,
                NameAlbum = _db.Albums.First(x=>x.IdAlbum == i.IdAlbum).Name,
                TrackPath = i.Path
            });
        }
        return Task.FromResult(result);
        

    }
}