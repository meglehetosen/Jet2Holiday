using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Foglala
{
    public int FoglalasId { get; set; }

    public int UserId { get; set; }

    public Guid ProductBvin { get; set; }

    public string? Telefon { get; set; }

    public string Lokacio { get; set; } = null!;

    public DateOnly ErkezesDatum { get; set; }

    public DateOnly TavozasDatum { get; set; }

    public int? VendegSzam { get; set; }

    public DateTime? LetrehozasDatuma { get; set; }

    public string Status { get; set; } = null!;

    public bool IsCancelled { get; set; }

    public string? CancellationReason { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public int? HandledByUserId { get; set; }

    public string? BookingReference { get; set; }

    public int? EjszakakSzama { get; set; }

    public Guid? OrderBvin { get; set; }

    public virtual User? HandledByUser { get; set; }

    public virtual HccOrder? OrderBvinNavigation { get; set; }

    public virtual HccProduct ProductBvinNavigation { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
