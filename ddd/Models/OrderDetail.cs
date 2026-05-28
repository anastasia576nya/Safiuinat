using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class OrderDetail
{
    public int IdorderDetails { get; set; }

    public int OrderId { get; set; }

    public string ArticleProduct { get; set; } = null!;

    public int Count { get; set; }

    public virtual Order Order { get; set; } = null!;
}
