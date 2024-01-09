using System;
using System.Collections.Generic;

namespace PlayerService.Entities;

public partial class Music
{
    public long IdMusic { get; set; }

    public string Name { get; set; } = null!;

    public string Path { get; set; } = null!;

    public long IdAlbum { get; set; }

    public long IdAgeConstraint { get; set; }

    public virtual ICollection<GenresMusic> GenresMusics { get; set; } = new List<GenresMusic>();

    public virtual Album IdAlbumNavigation { get; set; } = null!;

    public virtual ICollection<PlaylistsMusic> PlaylistsMusics { get; set; } = new List<PlaylistsMusic>();
}
