using System;
using System.Collections.Generic;

namespace AuthService.Entities;

public  class Role
{
    public long IdRole { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
