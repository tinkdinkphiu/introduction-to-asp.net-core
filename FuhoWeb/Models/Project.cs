using System;
using System.Collections.Generic;

namespace FuhoWeb.Models;

public partial class Project
{
    public string ProjectId { get; set; } = null!;

    public string? ProjectName { get; set; }

    public string? Address { get; set; }

    public string? Image { get; set; }
}
