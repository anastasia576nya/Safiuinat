using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class NameProduct
{
    public int IdnameProduct { get; set; }

    public string NameProduct1 { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
