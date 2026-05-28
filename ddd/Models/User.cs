using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class User
{
    public int Iduser { get; set; }

    public int UserRoleId { get; set; }

    public string UserSurname { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserPatronoimic { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual UserRole UserRole { get; set; } = null!;
}
