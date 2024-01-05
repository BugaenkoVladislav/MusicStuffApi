using PlaylistService.Entities;

namespace PlaylistService.Entities;

public  class LoginPassword
{
    public long IdLoginPassword { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
