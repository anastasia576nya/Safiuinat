using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class Address
{
    public int Idaddress { get; set; }

    public string AddressName { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
