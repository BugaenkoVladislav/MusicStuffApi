using System;
using System.Collections.Generic;

namespace PlayerService.Entities;

public partial class Album
{
    public long IdAlbum { get; set; }

    public string Name { get; set; } = null!;

    public string Photo { get; set; } = null!;

    public long IdUser { get; set; }

    public virtual ICollection<Music> Musics { get; set; } = new List<Music>();
}
