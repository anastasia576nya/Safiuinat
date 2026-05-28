using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class StatusOrder
{
    public int IdstatusOrder { get; set; }

    public string StatusOrderName { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
