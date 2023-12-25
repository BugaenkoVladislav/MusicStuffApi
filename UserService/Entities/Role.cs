using System;
using System.Collections.Generic;

namespace UserService.Entities;

public partial class Role
{
    public long IdRole { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
