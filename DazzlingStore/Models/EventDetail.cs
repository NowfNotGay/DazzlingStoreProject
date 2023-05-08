﻿using System;
using System.Collections.Generic;

namespace DazzlingStore.Models;

public partial class EventDetail
{
    public int ProductId { get; set; }

    public int EventId { get; set; }

    public int Price { get; set; }

    public int Quantity { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
