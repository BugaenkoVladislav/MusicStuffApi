using System;
using System.Collections.Generic;

namespace AuthService.Entities;

public  class User
{
    public long IdUser { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public long Age { get; set; }

    public long IdRole { get; set; }

    public long IdLoginPassword { get; set; }

    public virtual LoginPassword IdLoginPasswordNavigation { get; set; } = null!;

    public virtual Role IdRoleNavigation { get; set; } = null!;
}
