using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccOrderTransaction
{
    public Guid Id { get; set; }

    public long StoreId { get; set; }

    public Guid OrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public int Action { get; set; }

    public decimal Amount { get; set; }

    public string CreditCard { get; set; } = null!;

    public bool Success { get; set; }

    public bool Voided { get; set; }

    public string RefNum1 { get; set; } = null!;

    public string RefNum2 { get; set; } = null!;

    public string LinkedToTransaction { get; set; } = null!;

    public string Messages { get; set; } = null!;

    public string CheckNumber { get; set; } = null!;

    public string PurchaseOrderNumber { get; set; } = null!;

    public string CompanyAccountNumber { get; set; } = null!;

    public string AdditionalSettings { get; set; } = null!;

    public string? GiftCard { get; set; }

    public string? MethodId { get; set; }

    public long? LineItemId { get; set; }

    public virtual HccOrder Order { get; set; } = null!;

    public virtual HccStore Store { get; set; } = null!;
}
