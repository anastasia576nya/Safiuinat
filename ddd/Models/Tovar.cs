using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class Tovar
{
    public int Idtovar { get; set; }

    public int TovarNameId { get; set; }

    public string Unit { get; set; } = null!;

    public int Price { get; set; }

    public int ManufacturerId { get; set; }

    public int SupplierId { get; set; }

    public int CategoriaTovarId { get; set; }

    public int Discount { get; set; }

    public int Count { get; set; }

    public string Description { get; set; } = null!;

    public string? Photo { get; set; }
}
