using System;
using System.Collections.Generic;

namespace PlaylistService.Entities;

public partial class Playlist
{
    public long IdPlaylist { get; set; }

    public string Photo { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long IdUser { get; set; }

    public bool IsPublic { get; set; }

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<PlaylistsMusic> PlaylistsMusics { get; set; } = new List<PlaylistsMusic>();
}
