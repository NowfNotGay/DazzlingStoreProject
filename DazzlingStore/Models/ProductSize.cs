﻿using System;
using System.Collections.Generic;

namespace DazzlingStore.Models;

public partial class ProductSize
{
    public int ProductId { get; set; }

    public int SizeId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Size Size { get; set; } = null!;
}
