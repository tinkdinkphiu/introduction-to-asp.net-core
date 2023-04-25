using System;
using System.Collections.Generic;

namespace FuhoWeb.Models;

public partial class Client
{
    public string ClientId { get; set; } = null!;

    public string? ClientName { get; set; }

    public string? Job { get; set; }

    public string? Comment { get; set; }

    public string? Image { get; set; }
}
