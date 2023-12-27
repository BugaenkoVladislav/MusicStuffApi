using System;
using System.Collections.Generic;

namespace PlaylistService.Entities;

public partial class Music
{
    public long IdMusic { get; set; }

    public string Name { get; set; } = null!;

    public string Path { get; set; } = null!;

    public long IdAlbum { get; set; }

    public long IdAgeConstraint { get; set; }

    public virtual ICollection<PlaylistsMusic> PlaylistsMusics { get; set; } = new List<PlaylistsMusic>();
}
