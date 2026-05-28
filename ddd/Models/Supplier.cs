using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class Supplier
{
    public int Idsupplier { get; set; }

    public string SupplierName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
