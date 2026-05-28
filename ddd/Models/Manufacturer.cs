using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class Manufacturer
{
    public int Idmanufacturer { get; set; }

    public string ManufacturerName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
