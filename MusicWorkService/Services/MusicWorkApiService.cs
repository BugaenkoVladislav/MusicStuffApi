using Grpc.Core;
using MusicWorkService.Context;
using MusicWorkService.Entities;

namespace MusicWorkService.Services;

public class MusicWorkApiService:Work.WorkBase
{
    private MyDbContext _db;
    private ILogger<MusicWorkApiService> _logger;
    public MusicWorkApiService(ILogger<MusicWorkApiService> logger, MyDbContext db)
    {
        _db = db;
        _logger = logger;
    }

    public override Task<NewAlbum>? AddAlbum(NewAlbum request, ServerCallContext context)
    {
        try
        {
            _db.Albums.Add(new Entities.Album()
            {
                 Name = request.Name,
                 Photo = request.Photo,
                 IdUser = AuthOptions.ReturnUserFromJwt(request.JwtAuthor,_db).IdUser
                  
            });
            _db.SaveChanges();
        }
        catch (Exception)
        {
            return null;
        }

        return Task.FromResult(new NewAlbum()
        {
            JwtAuthor = request.JwtAuthor,
            Name = request.Name,
            Photo = request.Photo
        });
    }
    public override Task<NewTrack>? AddMusic(NewTrack request, ServerCallContext context)
    {
        try
        {
            var album = _db.Albums.FirstOrDefault(x => x.IdAlbum == request.IdAlbum);
                if (album == null || album.IdUser != AuthOptions.ReturnUserFromJwt(request.JwtAuthor, _db).IdUser)
                context.Status = new Grpc.Core.Status(StatusCode.Aborted,"Forbid");
            _db.Musics.Add(new Music()
            {
                Name = request.NameMusic,
                IdAlbum = request.IdAlbum,
                Path = "/",
                IdAgeConstraint = request.Age
            });
            _db.SaveChanges();
            foreach (var i in request.Genres)
            {
                _db.GenresMusics.Add(new GenresMusic()
                {
                    IdGenre = i.Id,
                    IdMusic = _db.Musics.First(x => x.Name == request.NameMusic && x.IdAlbum == request.IdAlbum).IdMusic
                });
                
            }
            _db.SaveChanges();
        }
        catch (Exception ex)
        {
            context.Status = new Grpc.Core.Status(StatusCode.Unknown, ex.Message);
            return Task.FromResult<NewTrack>(new NewTrack());
        }

        context.Status = new Grpc.Core.Status(StatusCode.OK, "Succeess");
        return Task.FromResult<NewTrack>(new NewTrack());
    }

    public override Task<Album> DeleteAlbum(Album request, ServerCallContext context)
    {
        try
        {
            var album = _db.Albums.FirstOrDefault(x => x.IdAlbum == request.IdAlbum);
            if (album == null || album.IdUser != AuthOptions.ReturnUserFromJwt(request.JwtAuthor, _db).IdUser)
            {
                context.Status = new Status(StatusCode.Aborted, "Forbid");
                return Task.FromResult(new Album());
            }
            _db.Albums.Remove(album);
            _db.SaveChanges();
        }
        catch (Exception)
        {
            context.Status = new Grpc.Core.Status(StatusCode.Unknown, "Error");
            return Task.FromResult(new Album());
        }
        context.Status = new Grpc.Core.Status(StatusCode.OK, "Succeess");
        return Task.FromResult(new Album());
        
    }

    public override Task<Track> DeleteMusic(Track request, ServerCallContext context)
    {
        try
        {
            var track = _db.Musics.FirstOrDefault(x => x.IdMusic == request.IdTrack);
            if (track == null || _db.Albums.First(x=>x.IdAlbum == track.IdAlbum).IdUser != AuthOptions.ReturnUserFromJwt(request.JwtAuthor, _db).IdUser)
            {
                context.Status = new Status(StatusCode.Aborted, "Forbid");
                return Task.FromResult(new Track());
            }
            _db.Musics.Remove(track);
            _db.SaveChanges();

        }
        catch (Exception)
        {
            context.Status = new Grpc.Core.Status(StatusCode.Unknown, "Error");
            return Task.FromResult(new Track());
        }
        context.Status = new Grpc.Core.Status(StatusCode.OK, "Succeess");
        return Task.FromResult(new Track());
    }
}