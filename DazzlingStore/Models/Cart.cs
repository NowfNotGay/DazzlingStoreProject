using System;
using System.Collections.Generic;

namespace DazzlingStore.Models;

public partial class Cart
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Account Account { get; set; } = null!;
}
