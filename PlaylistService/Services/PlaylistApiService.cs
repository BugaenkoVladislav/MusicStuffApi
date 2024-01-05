using Grpc.Core;
using PlaylistService.Context;
using PlaylistService.Entities;

namespace PlaylistService.Services;

public class PlaylistApiService:Playlist.PlaylistBase
{
    private ILogger<PlaylistApiService> _logger;
    private MyDbContext _db;
    public PlaylistApiService(ILogger<PlaylistApiService> logger,MyDbContext db)
    {
        _db = db;
        _logger = logger;
    }

    public override Task<NewPlaylist> CreatePlaylist(NewPlaylist request, ServerCallContext context)
    {
        try
        {
            _db.Playlists.Add(new Entities.Playlist()
            {
                Name = request.Name,
                Photo = request.Photopath,
                IdUser = AuthOptions.ReturnUserFromJwt(request.JwtUser,_db).IdUser,
                IsPublic = request.IsPublic
            });
            _db.SaveChanges();
            context.Status = new Status(StatusCode.OK, "Success");
        }
        catch (Exception ex)
        {
            context.Status = new Status(StatusCode.Unknown, ex.Message);
        }

        return Task.FromResult(new NewPlaylist());
    }

    public override Task<IdPlaylist> DeletePlaylist(IdPlaylist request, ServerCallContext context)
    {
        try
        {
            var playlist = _db.Playlists.FirstOrDefault(x => x.IdPlaylist == request.Id);
            if (playlist == null || playlist.IdUser != AuthOptions.ReturnUserFromJwt(request.JwtUser, _db).IdUser)
            {
                context.Status = new Status(StatusCode.Aborted, "Forbid");
                return Task.FromResult(new IdPlaylist());
            }
            _db.Playlists.Remove(playlist);
            _db.SaveChanges();
            context.Status = new Status(StatusCode.OK, "Success");
        }
        catch (Exception ex)
        {
            context.Status = new Status(StatusCode.Unknown, ex.Message);
        }
        return Task.FromResult(new IdPlaylist());
    }

    public override Task<Track> AddInPlaylist(Track request, ServerCallContext context)
    {
        try
        {
            var playlist = _db.Playlists.FirstOrDefault(x => x.IdPlaylist == request.IdPlaylist);
            if (playlist == null || playlist.IdUser != AuthOptions.ReturnUserFromJwt(request.JwtUser, _db).IdUser)
            {
                context.Status = new Status(StatusCode.Aborted, "Forbid");
                return Task.FromResult(new Track());
            }

            _db.PlaylistsMusics.Add(new PlaylistsMusic()
            {
                IdPlaylist = request.IdPlaylist,
                IdMusic = request.IdTrack
            });
            _db.SaveChanges();
            context.Status = new Status(StatusCode.OK, "Success");
        }
        catch (Exception ex)
        {
            context.Status = new Status(StatusCode.Unknown, ex.Message);
        }

        return Task.FromResult(new Track());

    }

    public override Task<Track> DeleteFromPlaylist(Track request, ServerCallContext context)
    {
        try
        {
            var position =
                _db.PlaylistsMusics.FirstOrDefault(x => x.IdPlaylist == request.IdPlaylist && x.IdMusic == request.IdTrack);
            var playlist = _db.Playlists.FirstOrDefault(x => x.IdPlaylist == request.IdPlaylist);
            if (position == null ||playlist==null || playlist.IdUser != AuthOptions.ReturnUserFromJwt(request.JwtUser, _db).IdUser)
            {
                context.Status = new Status(StatusCode.Aborted, "Forbid");
                return Task.FromResult(new Track());
            }
            _db.PlaylistsMusics.Remove(position);
            _db.SaveChanges();
            context.Status = new Status(StatusCode.OK, "Success");
        }
        catch (Exception ex)
        {
            context.Status = new Status(StatusCode.Unknown, ex.Message);
        }
        return Task.FromResult(new Track());
    }

    public override Task<Playlists> GetMyPlaylists(Playlists request, ServerCallContext context)
    {
        var output = new Playlists();
        try
        {
            var playlists = _db.Playlists
                .Where(x => x.IdUser == AuthOptions.ReturnUserFromJwt(request.JwtUser, _db).IdUser).ToList();
            context.Status = new Status(StatusCode.OK, "Success");
            foreach (var i in playlists)
            {
                output.Playlists_.Add( new NewPlaylist()
                {
                    IsPublic = i.IsPublic,
                    Name = i.Name,
                    Photopath = i.Photo
                });
            }
        }
        catch (Exception ex)
        {
            context.Status = new Status(StatusCode.Unknown, ex.Message);    
        }
        return Task.FromResult(output);
    }
}