using System;
using System.Collections.Generic;

namespace ddd.Models;

public partial class Order
{
    public int Idorders { get; set; }

    public DateOnly DataOrders { get; set; }

    public DateOnly DataDelivery { get; set; }

    public int AddresId { get; set; }

    public int SnpUserId { get; set; }

    public int Code { get; set; }

    public int StatusId { get; set; }

    public virtual Address Addres { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual User SnpUser { get; set; } = null!;

    public virtual StatusOrder Status { get; set; } = null!;
}
