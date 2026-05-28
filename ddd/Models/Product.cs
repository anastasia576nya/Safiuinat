using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class Product
{
    public int Idproduct { get; set; }

    public string Article { get; set; } = null!;

    public int ProductNameId { get; set; }

    public string Unit { get; set; } = null!;

    public int Price { get; set; }

    public int SupplierId { get; set; }

    public int ManufactuterId { get; set; }

    public int CategoriaProductId { get; set; }

    public int Discount { get; set; }

    public int Count { get; set; }

    public string Description { get; set; } = null!;

    public string? Photo { get; set; }

    public virtual CategoriaProduct CategoriaProduct { get; set; } = null!;

    public virtual Manufacturer Manufactuter { get; set; } = null!;

    public virtual NameProduct ProductName { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
