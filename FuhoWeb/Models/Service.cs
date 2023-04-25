using System;
using System.Collections.Generic;

namespace FuhoWeb.Models;

public partial class Service
{
    public string ServiceId { get; set; } = null!;

    public string? ServiceName { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }
}
