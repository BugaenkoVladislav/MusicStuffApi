using System;
using System.Collections.Generic;

namespace MusicWorkService.Entities;

public partial class User
{
    public long IdUser { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public long Age { get; set; }

    public long IdRole { get; set; }

    public long IdLoginPassword { get; set; }
    
}
