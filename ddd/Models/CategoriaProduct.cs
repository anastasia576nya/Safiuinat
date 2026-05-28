using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class CategoriaProduct
{
    public int IdcategoriaProduct { get; set; }

    public string CategoriaProductName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
