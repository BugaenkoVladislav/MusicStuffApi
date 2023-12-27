using System;
using System.Collections.Generic;

namespace MusicFindService.Entities;

public partial class GenresMusic
{
    public long IdGenreMusic { get; set; }

    public long IdMusic { get; set; }

    public long IdGenre { get; set; }

    public virtual Genre IdGenreNavigation { get; set; } = null!;

    public virtual Music IdMusicNavigation { get; set; } = null!;
}
