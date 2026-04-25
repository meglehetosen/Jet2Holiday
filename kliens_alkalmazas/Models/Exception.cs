using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Exception
{
    public string ExceptionHash { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? StackTrace { get; set; }

    public string? InnerMessage { get; set; }

    public string? InnerStackTrace { get; set; }

    public string? Source { get; set; }
}
