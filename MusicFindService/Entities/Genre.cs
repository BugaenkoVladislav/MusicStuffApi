using System;
using System.Collections.Generic;

namespace MusicFindService.Entities;

public partial class Genre
{
    public long IdGenre { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GenresMusic> GenresMusics { get; set; } = new List<GenresMusic>();
}
