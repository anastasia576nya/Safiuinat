using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class UserRole
{
    public int IduserRole { get; set; }

    public string UserRoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
