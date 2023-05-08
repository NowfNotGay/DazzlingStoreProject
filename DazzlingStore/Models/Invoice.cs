using System;
using System.Collections.Generic;

namespace DazzlingStore.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public int InvoiceNumbet { get; set; }

    public string? Payment { get; set; }

    public int AccountId { get; set; }

    public bool Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Account Account { get; set; } = null!;
}
