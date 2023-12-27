using System;
using System.Collections.Generic;

namespace PlaylistService.Entities;

public partial class PlaylistsMusic
{
    public long IdPlaylist { get; set; }

    public long IdMusic { get; set; }

    public long IdPlaylistMusic { get; set; }

    public virtual Music IdMusicNavigation { get; set; } = null!;

    public virtual Playlist IdPlaylistNavigation { get; set; } = null!;
}
